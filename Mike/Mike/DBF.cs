#nullable disable
namespace Login_Sign_in
{
    public partial class DBF : Form
    {
        private int selectedId = 0;

        public bool LoggedOut { get; private set; }

        public DBF(string userName)
        {
            InitializeComponent();
            Thm.Apply(this);
            lblWelcome.Text = $"Welcome, {userName}!";
            lblAvatar.Text = string.IsNullOrEmpty(userName) ? "?" : userName.Substring(0, 1).ToUpper();

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += (s, e) => ClearForm();
            btnRefresh.Click += btnRefresh_Click;
            txtSearch.TextChanged += (s, e) => LoadProducts();
            dgvProducts.CellClick += dgvProducts_CellClick;
            Load += DBF_Load;
        }

        private void DBF_Load(object sender, EventArgs e)
        {
            try
            {
                PDb.EnsureTable();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoggedOut = true;
            Close();
        }

        private void LoadProducts()
        {
            try
            {
                dgvProducts.DataSource = PDb.GetAll(txtSearch.Text.Trim());
                FormatGrid();
                dgvProducts.ClearSelection();

                var (total, inStock, low, outOfStock) = PDb.GetStats();
                lblTotalCount.Text = total.ToString();
                lblInStockCount.Text = inStock.ToString();
                lblLowCount.Text = low.ToString();
                lblOutCount.Text = outOfStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvProducts.Columns.Count == 0) return;

            dgvProducts.Columns["ProductID"].HeaderText = "ID";
            dgvProducts.Columns["ProductID"].FillWeight = 35;
            dgvProducts.Columns["ProductName"].HeaderText = "Name";
            dgvProducts.Columns["Category"].HeaderText = "Category";
            dgvProducts.Columns["Description"].HeaderText = "Description";
            dgvProducts.Columns["Description"].FillWeight = 130;
            dgvProducts.Columns["UnitPrice"].HeaderText = "Price";
            dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
            dgvProducts.Columns["UnitPrice"].FillWeight = 60;
            dgvProducts.Columns["Quantity"].HeaderText = "Qty";
            dgvProducts.Columns["Quantity"].FillWeight = 45;
            dgvProducts.Columns["ReorderLevel"].HeaderText = "Reorder";
            dgvProducts.Columns["ReorderLevel"].FillWeight = 55;
            dgvProducts.Columns["CreatedAt"].HeaderText = "Created";
            dgvProducts.Columns["CreatedAt"].DefaultCellStyle.Format = "MM/dd/yyyy h:mm tt";
            dgvProducts.Columns["CreatedAt"].FillWeight = 90;
        }

        private bool ReadInputs(out string name, out string category, out string description,
                                out decimal price, out int quantity, out int reorder)
        {
            name = txtName.Text.Trim();
            category = cboCategory.Text;
            description = txtDescription.Text.Trim();
            price = 0; quantity = 0; reorder = 0;

            if (name == "") { MessageBox.Show("Please enter the product name."); return false; }
            if (cboCategory.SelectedIndex < 0) { MessageBox.Show("Please choose a category."); return false; }
            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            { MessageBox.Show("Unit price must be a number (0 or higher)."); return false; }
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            { MessageBox.Show("Quantity must be a whole number (0 or higher)."); return false; }
            if (!int.TryParse(txtReorder.Text, out reorder) || reorder < 0)
            { MessageBox.Show("Reorder level must be a whole number (0 or higher)."); return false; }

            return true;
        }

        private void ClearForm()
        {
            selectedId = 0;
            txtName.Clear();
            cboCategory.SelectedIndex = -1;
            txtPrice.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            txtReorder.Clear();
            dgvProducts.ClearSelection();
            txtName.Focus();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvProducts.Rows[e.RowIndex];

            selectedId = Convert.ToInt32(row.Cells["ProductID"].Value);
            txtName.Text = row.Cells["ProductName"].Value.ToString();
            cboCategory.SelectedIndex = cboCategory.FindStringExact(row.Cells["Category"].Value.ToString());
            txtDescription.Text = row.Cells["Description"].Value.ToString();
            txtPrice.Text = Convert.ToDecimal(row.Cells["UnitPrice"].Value).ToString("0.00");
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtReorder.Text = row.Cells["ReorderLevel"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ReadInputs(out var name, out var category, out var description,
                            out var price, out var quantity, out var reorder)) return;
            try
            {
                PDb.Add(name, category, description, price, quantity, reorder);
                ClearForm();
                LoadProducts();
                MessageBox.Show("Product added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Click a product in the list first."); return; }
            if (!ReadInputs(out var name, out var category, out var description,
                            out var price, out var quantity, out var reorder)) return;
            try
            {
                PDb.Update(selectedId, name, category, description, price, quantity, reorder);
                ClearForm();
                LoadProducts();
                MessageBox.Show("Product updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0) { MessageBox.Show("Click a product in the list first."); return; }

            var answer = MessageBox.Show($"Delete \"{txtName.Text}\"? This cannot be undone.",
                "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes) return;

            try
            {
                PDb.Delete(selectedId);
                ClearForm();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearForm();
            LoadProducts();
        }
    }
}