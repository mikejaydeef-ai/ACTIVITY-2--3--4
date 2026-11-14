#nullable disable
using System.Data;
using System.Data.OleDb;

namespace Login_Sign_in
{
    public static class PDb
    {
        private static object N(string s) =>
            string.IsNullOrWhiteSpace(s) ? DBNull.Value : s.Trim();

        public static void EnsureTable()
        {
            using var conn = new OleDbConnection(Db.ConnStr);
            conn.Open();
            var found = conn.GetSchema("Tables", new string[] { null, null, "Products", "TABLE" });
            if (found.Rows.Count > 0) return;

            using var cmd = new OleDbCommand(
                "CREATE TABLE Products (" +
                "ProductID COUNTER PRIMARY KEY, " +
                "ProductName TEXT(100) NOT NULL, " +
                "Category TEXT(50), " +
                "[Description] TEXT(255), " +
                "UnitPrice CURRENCY, " +
                "Quantity LONG, " +
                "ReorderLevel LONG, " +
                "CreatedAt DATETIME)", conn);
            cmd.ExecuteNonQuery();
        }

        public static DataTable GetAll(string search = "")
        {
            using var conn = new OleDbConnection(Db.ConnStr);
            using var cmd = new OleDbCommand(
                "SELECT ProductID, ProductName, Category, [Description], UnitPrice, Quantity, ReorderLevel, CreatedAt " +
                "FROM Products WHERE ProductName LIKE ? OR Category LIKE ? ORDER BY ProductID DESC", conn);
            cmd.Parameters.AddWithValue("?", "%" + search + "%");
            cmd.Parameters.AddWithValue("?", "%" + search + "%");

            var table = new DataTable();
            new OleDbDataAdapter(cmd).Fill(table);
            return table;
        }

        public static void Add(string name, string category, string description,
                               decimal price, int quantity, int reorderLevel)
        {
            using var conn = new OleDbConnection(Db.ConnStr);
            using var cmd = new OleDbCommand(
                "INSERT INTO Products (ProductName, Category, [Description], UnitPrice, Quantity, ReorderLevel, CreatedAt) " +
                "VALUES (?, ?, ?, ?, ?, ?, ?)", conn);
            cmd.Parameters.AddWithValue("?", name.Trim());
            cmd.Parameters.AddWithValue("?", N(category));
            cmd.Parameters.AddWithValue("?", N(description));
            cmd.Parameters.Add("?", OleDbType.Currency).Value = price;
            cmd.Parameters.AddWithValue("?", quantity);
            cmd.Parameters.AddWithValue("?", reorderLevel);
            cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void Update(int id, string name, string category, string description,
                                  decimal price, int quantity, int reorderLevel)
        {
            using var conn = new OleDbConnection(Db.ConnStr);
            using var cmd = new OleDbCommand(
                "UPDATE Products SET ProductName = ?, Category = ?, [Description] = ?, " +
                "UnitPrice = ?, Quantity = ?, ReorderLevel = ? WHERE ProductID = ?", conn);
            cmd.Parameters.AddWithValue("?", name.Trim());
            cmd.Parameters.AddWithValue("?", N(category));
            cmd.Parameters.AddWithValue("?", N(description));
            cmd.Parameters.Add("?", OleDbType.Currency).Value = price;
            cmd.Parameters.AddWithValue("?", quantity);
            cmd.Parameters.AddWithValue("?", reorderLevel);
            cmd.Parameters.AddWithValue("?", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static void Delete(int id)
        {
            using var conn = new OleDbConnection(Db.ConnStr);
            using var cmd = new OleDbCommand("DELETE FROM Products WHERE ProductID = ?", conn);
            cmd.Parameters.AddWithValue("?", id);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static (int total, int inStock, int low, int outOfStock) GetStats()
        {
            using var conn = new OleDbConnection(Db.ConnStr);
            conn.Open();

            int Count(string where)
            {
                using var cmd = new OleDbCommand("SELECT COUNT(*) FROM Products" + where, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }

            return (
                Count(""),
                Count(" WHERE Quantity > ReorderLevel"),
                Count(" WHERE Quantity > 0 AND Quantity <= ReorderLevel"),
                Count(" WHERE Quantity <= 0")
            );
        }
    }
}
