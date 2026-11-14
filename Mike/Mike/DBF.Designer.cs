#nullable disable
namespace Login_Sign_in
{
    partial class DBF
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            lblBrand = new Label();
            lblWelcome = new Label();
            lblAvatar = new Label();
            btnLogout = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();
            tlpCards = new TableLayoutPanel();
            pnlTotal = new Panel();
            stripTotal = new Panel();
            lblTotalTitle = new Label();
            lblTotalCount = new Label();
            lblTotalNote = new Label();
            pnlInStock = new Panel();
            stripInStock = new Panel();
            lblInStockTitle = new Label();
            lblInStockCount = new Label();
            lblInStockNote = new Label();
            pnlLow = new Panel();
            stripLow = new Panel();
            lblLowTitle = new Label();
            lblLowCount = new Label();
            lblLowNote = new Label();
            pnlOut = new Panel();
            stripOut = new Panel();
            lblOutTitle = new Label();
            lblOutCount = new Label();
            lblOutNote = new Label();
            pnlForm = new Panel();
            lblFormTitle = new Label();
            lblCapName = new Label();
            txtName = new TextBox();
            lblCapCategory = new Label();
            cboCategory = new ComboBox();
            lblCapPrice = new Label();
            txtPrice = new TextBox();
            lblCapQuantity = new Label();
            txtQuantity = new TextBox();
            lblCapReorder = new Label();
            txtReorder = new TextBox();
            lblCapDescription = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            pnlList = new Panel();
            lblList = new Label();
            lblListHint = new Label();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            pnlTop.SuspendLayout();
            tlpCards.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlInStock.SuspendLayout();
            pnlLow.SuspendLayout();
            pnlOut.SuspendLayout();
            pnlForm.SuspendLayout();
            pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            
            pnlTop.BackColor = Color.FromArgb(15, 45, 74);
            pnlTop.Controls.Add(lblBrand);
            pnlTop.Controls.Add(lblWelcome);
            pnlTop.Controls.Add(lblAvatar);
            pnlTop.Controls.Add(btnLogout);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1120, 56);
            pnlTop.TabIndex = 0;
            pnlTop.Tag = "header";
            
            lblBrand.AutoSize = true;
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(24, 11);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(83, 15);
            lblBrand.TabIndex = 0;
            lblBrand.Tag = "brand";
            lblBrand.Text = "LGSI Inventory";
             
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(704, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(240, 32);
            lblWelcome.TabIndex = 1;
            lblWelcome.Tag = "headerText";
            lblWelcome.Text = "Welcome!";
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            
            lblAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAvatar.BackColor = Color.FromArgb(37, 125, 214);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(954, 11);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(34, 34);
            lblAvatar.TabIndex = 2;
            lblAvatar.Tag = "avatar";
            lblAvatar.Text = "U";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(1000, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(96, 32);
            btnLogout.TabIndex = 3;
            btnLogout.Tag = "secondary";
            btnLogout.Text = "Log out";
            btnLogout.Click += btnLogout_Click;
            
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(22, 64);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Tag = "title";
            lblTitle.Text = "Product Management";
             
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(26, 104);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(180, 15);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "Manage your inventory products";
            
            tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(pnlTotal, 0, 0);
            tlpCards.Controls.Add(pnlInStock, 1, 0);
            tlpCards.Controls.Add(pnlLow, 2, 0);
            tlpCards.Controls.Add(pnlOut, 3, 0);
            tlpCards.Location = new Point(24, 136);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1072, 84);
            tlpCards.TabIndex = 3;
             
            pnlTotal.BackColor = Color.White;
            pnlTotal.Controls.Add(stripTotal);
            pnlTotal.Controls.Add(lblTotalTitle);
            pnlTotal.Controls.Add(lblTotalCount);
            pnlTotal.Controls.Add(lblTotalNote);
            pnlTotal.Dock = DockStyle.Fill;
            pnlTotal.Location = new Point(0, 0);
            pnlTotal.Margin = new Padding(0, 0, 16, 0);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(252, 84);
            pnlTotal.TabIndex = 0;
            pnlTotal.Tag = "card";
            
            stripTotal.BackColor = Color.FromArgb(37, 125, 214);
            stripTotal.Dock = DockStyle.Left;
            stripTotal.Location = new Point(0, 0);
            stripTotal.Name = "stripTotal";
            stripTotal.Size = new Size(5, 84);
            stripTotal.TabIndex = 0;
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Location = new Point(22, 10);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(82, 15);
            lblTotalTitle.TabIndex = 1;
            lblTotalTitle.Tag = "cardTitle";
            lblTotalTitle.Text = "Total Products";
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(20, 30);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(13, 15);
            lblTotalCount.TabIndex = 2;
            lblTotalCount.Tag = "cardValue";
            lblTotalCount.Text = "0";
            lblTotalNote.AutoSize = true;
            lblTotalNote.Location = new Point(88, 52);
            lblTotalNote.Name = "lblTotalNote";
            lblTotalNote.Size = new Size(96, 15);
            lblTotalNote.TabIndex = 3;
            lblTotalNote.Tag = "caption";
            lblTotalNote.Text = "products tracked";
            pnlInStock.BackColor = Color.White;
            pnlInStock.Controls.Add(stripInStock);
            pnlInStock.Controls.Add(lblInStockTitle);
            pnlInStock.Controls.Add(lblInStockCount);
            pnlInStock.Controls.Add(lblInStockNote);
            pnlInStock.Dock = DockStyle.Fill;
            pnlInStock.Location = new Point(268, 0);
            pnlInStock.Margin = new Padding(0, 0, 16, 0);
            pnlInStock.Name = "pnlInStock";
            pnlInStock.Size = new Size(252, 84);
            pnlInStock.TabIndex = 1;
            pnlInStock.Tag = "card";
            stripInStock.BackColor = Color.FromArgb(15, 45, 74);
            stripInStock.Dock = DockStyle.Left;
            stripInStock.Location = new Point(0, 0);
            stripInStock.Name = "stripInStock";
            stripInStock.Size = new Size(5, 84);
            stripInStock.TabIndex = 0;
            lblInStockTitle.AutoSize = true;
            lblInStockTitle.Location = new Point(22, 10);
            lblInStockTitle.Name = "lblInStockTitle";
            lblInStockTitle.Size = new Size(49, 15);
            lblInStockTitle.TabIndex = 1;
            lblInStockTitle.Tag = "cardTitle";
            lblInStockTitle.Text = "In Stock";
            lblInStockCount.AutoSize = true;
            lblInStockCount.Location = new Point(20, 30);
            lblInStockCount.Name = "lblInStockCount";
            lblInStockCount.Size = new Size(13, 15);
            lblInStockCount.TabIndex = 2;
            lblInStockCount.Tag = "cardValue";
            lblInStockCount.Text = "0";
            lblInStockNote.AutoSize = true;
            lblInStockNote.Location = new Point(88, 52);
            lblInStockNote.Name = "lblInStockNote";
            lblInStockNote.Size = new Size(107, 15);
            lblInStockNote.TabIndex = 3;
            lblInStockNote.Tag = "caption";
            lblInStockNote.Text = "above reorder level";
            
            pnlLow.BackColor = Color.White;
            pnlLow.Controls.Add(stripLow);
            pnlLow.Controls.Add(lblLowTitle);
            pnlLow.Controls.Add(lblLowCount);
            pnlLow.Controls.Add(lblLowNote);
            pnlLow.Dock = DockStyle.Fill;
            pnlLow.Location = new Point(536, 0);
            pnlLow.Margin = new Padding(0, 0, 16, 0);
            pnlLow.Name = "pnlLow";
            pnlLow.Size = new Size(252, 84);
            pnlLow.TabIndex = 2;
            pnlLow.Tag = "card";
            
            stripLow.BackColor = Color.FromArgb(96, 165, 250);
            stripLow.Dock = DockStyle.Left;
            stripLow.Location = new Point(0, 0);
            stripLow.Name = "stripLow";
            stripLow.Size = new Size(5, 84);
            stripLow.TabIndex = 0;
           
            lblLowTitle.AutoSize = true;
            lblLowTitle.Location = new Point(22, 10);
            lblLowTitle.Name = "lblLowTitle";
            lblLowTitle.Size = new Size(61, 15);
            lblLowTitle.TabIndex = 1;
            lblLowTitle.Tag = "cardTitle";
            lblLowTitle.Text = "Low Stock";
            
            lblLowCount.AutoSize = true;
            lblLowCount.Location = new Point(20, 30);
            lblLowCount.Name = "lblLowCount";
            lblLowCount.Size = new Size(13, 15);
            lblLowCount.TabIndex = 2;
            lblLowCount.Tag = "cardValue";
            lblLowCount.Text = "0";
           
            lblLowNote.AutoSize = true;
            lblLowNote.Location = new Point(88, 52);
            lblLowNote.Name = "lblLowNote";
            lblLowNote.Size = new Size(134, 15);
            lblLowNote.TabIndex = 3;
            lblLowNote.Tag = "caption";
            lblLowNote.Text = "at or below reorder level";
            
            pnlOut.BackColor = Color.White;
            pnlOut.Controls.Add(stripOut);
            pnlOut.Controls.Add(lblOutTitle);
            pnlOut.Controls.Add(lblOutCount);
            pnlOut.Controls.Add(lblOutNote);
            pnlOut.Dock = DockStyle.Fill;
            pnlOut.Location = new Point(804, 0);
            pnlOut.Margin = new Padding(0);
            pnlOut.Name = "pnlOut";
            pnlOut.Size = new Size(268, 84);
            pnlOut.TabIndex = 3;
            pnlOut.Tag = "card";
           
            stripOut.BackColor = Color.FromArgb(84, 110, 138);
            stripOut.Dock = DockStyle.Left;
            stripOut.Location = new Point(0, 0);
            stripOut.Name = "stripOut";
            stripOut.Size = new Size(5, 84);
            stripOut.TabIndex = 0;
            
            lblOutTitle.AutoSize = true;
            lblOutTitle.Location = new Point(22, 10);
            lblOutTitle.Name = "lblOutTitle";
            lblOutTitle.Size = new Size(73, 15);
            lblOutTitle.TabIndex = 1;
            lblOutTitle.Tag = "cardTitle";
            lblOutTitle.Text = "Out of Stock";
            
            lblOutCount.AutoSize = true;
            lblOutCount.Location = new Point(20, 30);
            lblOutCount.Name = "lblOutCount";
            lblOutCount.Size = new Size(13, 15);
            lblOutCount.TabIndex = 2;
            lblOutCount.Tag = "cardValue";
            lblOutCount.Text = "0";
            
            lblOutNote.AutoSize = true;
            lblOutNote.Location = new Point(88, 52);
            lblOutNote.Name = "lblOutNote";
            lblOutNote.Size = new Size(71, 15);
            lblOutNote.TabIndex = 3;
            lblOutNote.Tag = "caption";
            lblOutNote.Text = "quantity is 0";
           
            pnlForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlForm.AutoScroll = true;
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(lblFormTitle);
            pnlForm.Controls.Add(lblCapName);
            pnlForm.Controls.Add(txtName);
            pnlForm.Controls.Add(lblCapCategory);
            pnlForm.Controls.Add(cboCategory);
            pnlForm.Controls.Add(lblCapPrice);
            pnlForm.Controls.Add(txtPrice);
            pnlForm.Controls.Add(lblCapQuantity);
            pnlForm.Controls.Add(txtQuantity);
            pnlForm.Controls.Add(lblCapReorder);
            pnlForm.Controls.Add(txtReorder);
            pnlForm.Controls.Add(lblCapDescription);
            pnlForm.Controls.Add(txtDescription);
            pnlForm.Controls.Add(btnAdd);
            pnlForm.Controls.Add(btnUpdate);
            pnlForm.Controls.Add(btnDelete);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Location = new Point(24, 236);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(340, 444);
            pnlForm.TabIndex = 4;
            pnlForm.Tag = "card";
            
            lblFormTitle.AutoSize = true;
            lblFormTitle.Location = new Point(18, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(87, 15);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Tag = "section";
            lblFormTitle.Text = "Product Details";
            
            lblCapName.AutoSize = true;
            lblCapName.Location = new Point(20, 52);
            lblCapName.Name = "lblCapName";
            lblCapName.Size = new Size(84, 15);
            lblCapName.TabIndex = 1;
            lblCapName.Tag = "caption";
            lblCapName.Text = "Product Name";
            
            txtName.Location = new Point(20, 70);
            txtName.MaxLength = 100;
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 23);
            txtName.TabIndex = 0;
            
            lblCapCategory.AutoSize = true;
            lblCapCategory.Location = new Point(20, 106);
            lblCapCategory.Name = "lblCapCategory";
            lblCapCategory.Size = new Size(55, 15);
            lblCapCategory.TabIndex = 2;
            lblCapCategory.Tag = "caption";
            lblCapCategory.Text = "Category";
            
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Font = new Font("Segoe UI", 11F);
            cboCategory.Items.AddRange(new object[] { "Computer Hardware", "Phone Accessories", "Peripherals", "Software", "Networking", "Other" });
            cboCategory.Location = new Point(20, 124);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(300, 28);
            cboCategory.TabIndex = 1;
            
            lblCapPrice.AutoSize = true;
            lblCapPrice.Location = new Point(20, 162);
            lblCapPrice.Name = "lblCapPrice";
            lblCapPrice.Size = new Size(58, 15);
            lblCapPrice.TabIndex = 3;
            lblCapPrice.Tag = "caption";
            lblCapPrice.Text = "Unit Price";
            
            txtPrice.Location = new Point(20, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "0.00";
            txtPrice.Size = new Size(142, 23);
            txtPrice.TabIndex = 2;
            
            lblCapQuantity.AutoSize = true;
            lblCapQuantity.Location = new Point(178, 162);
            lblCapQuantity.Name = "lblCapQuantity";
            lblCapQuantity.Size = new Size(53, 15);
            lblCapQuantity.TabIndex = 4;
            lblCapQuantity.Tag = "caption";
            lblCapQuantity.Text = "Quantity";
            
            txtQuantity.Location = new Point(178, 180);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "0";
            txtQuantity.Size = new Size(142, 23);
            txtQuantity.TabIndex = 3;
            
            lblCapReorder.AutoSize = true;
            lblCapReorder.Location = new Point(20, 216);
            lblCapReorder.Name = "lblCapReorder";
            lblCapReorder.Size = new Size(78, 15);
            lblCapReorder.TabIndex = 5;
            lblCapReorder.Tag = "caption";
            lblCapReorder.Text = "Reorder Level";
            
            txtReorder.Location = new Point(20, 234);
            txtReorder.Name = "txtReorder";
            txtReorder.PlaceholderText = "0";
            txtReorder.Size = new Size(300, 23);
            txtReorder.TabIndex = 4;
            
            lblCapDescription.AutoSize = true;
            lblCapDescription.Location = new Point(20, 270);
            lblCapDescription.Name = "lblCapDescription";
            lblCapDescription.Size = new Size(67, 15);
            lblCapDescription.TabIndex = 6;
            lblCapDescription.Tag = "caption";
            lblCapDescription.Text = "Description";
           
            txtDescription.Location = new Point(20, 288);
            txtDescription.MaxLength = 255;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(300, 54);
            txtDescription.TabIndex = 5;
             
            btnAdd.Location = new Point(20, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(300, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Product";
            
            btnUpdate.Location = new Point(20, 398);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 32);
            btnUpdate.TabIndex = 7;
            btnUpdate.Tag = "secondary";
            btnUpdate.Text = "Update";
            
            btnDelete.Location = new Point(124, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 32);
            btnDelete.TabIndex = 8;
            btnDelete.Tag = "dark";
            btnDelete.Text = "Delete";
            
            btnClear.Location = new Point(228, 398);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 32);
            btnClear.TabIndex = 9;
            btnClear.Tag = "secondary";
            btnClear.Text = "Clear";
            
            pnlList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlList.BackColor = Color.White;
            pnlList.Controls.Add(lblList);
            pnlList.Controls.Add(lblListHint);
            pnlList.Controls.Add(btnRefresh);
            pnlList.Controls.Add(txtSearch);
            pnlList.Controls.Add(dgvProducts);
            pnlList.Location = new Point(380, 236);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(716, 444);
            pnlList.TabIndex = 5;
            pnlList.Tag = "card";
            
            lblList.AutoSize = true;
            lblList.Location = new Point(18, 14);
            lblList.Name = "lblList";
            lblList.Size = new Size(70, 15);
            lblList.TabIndex = 0;
            lblList.Tag = "section";
            lblList.Text = "Product List";
            
            lblListHint.AutoSize = true;
            lblListHint.Location = new Point(140, 22);
            lblListHint.Name = "lblListHint";
            lblListHint.Size = new Size(112, 15);
            lblListHint.TabIndex = 1;
            lblListHint.Tag = "caption";
            lblListHint.Text = "Click a row to edit it";
            
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(364, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(84, 30);
            btnRefresh.TabIndex = 10;
            btnRefresh.Tag = "secondary";
            btnRefresh.Text = "Refresh";
            
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(456, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search name or category";
            txtSearch.Size = new Size(240, 23);
            txtSearch.TabIndex = 11;
            
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 249, 254);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 125, 214);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 236, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 45, 74);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(222, 236, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 45, 74);
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeight = 36;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(15, 45, 74);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(37, 125, 214);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.FromArgb(214, 228, 242);
            dgvProducts.Location = new Point(20, 56);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowTemplate.Height = 30;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(676, 368);
            dgvProducts.TabIndex = 12;
             
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 244, 253);
            ClientSize = new Size(1120, 700);
            Controls.Add(pnlTop);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(tlpCards);
            Controls.Add(pnlForm);
            Controls.Add(pnlList);
            MinimumSize = new Size(1056, 640);
            Name = "DBF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LGSI - Dashboard";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tlpCards.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            pnlInStock.ResumeLayout(false);
            pnlInStock.PerformLayout();
            pnlLow.ResumeLayout(false);
            pnlLow.PerformLayout();
            pnlOut.ResumeLayout(false);
            pnlOut.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            pnlList.ResumeLayout(false);
            pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlTop;
        private Label lblBrand;
        private Label lblWelcome;
        private Label lblAvatar;
        private Button btnLogout;
        private Label lblTitle;
        private Label lblSubtitle;

        private TableLayoutPanel tlpCards;
        private Panel pnlTotal; private Panel stripTotal; private Label lblTotalTitle; private Label lblTotalCount; private Label lblTotalNote;
        private Panel pnlInStock; private Panel stripInStock; private Label lblInStockTitle; private Label lblInStockCount; private Label lblInStockNote;
        private Panel pnlLow; private Panel stripLow; private Label lblLowTitle; private Label lblLowCount; private Label lblLowNote;
        private Panel pnlOut; private Panel stripOut; private Label lblOutTitle; private Label lblOutCount; private Label lblOutNote;

        private Panel pnlForm;
        private Label lblFormTitle;
        private Label lblCapName; private TextBox txtName;
        private Label lblCapCategory; private ComboBox cboCategory;
        private Label lblCapPrice; private TextBox txtPrice;
        private Label lblCapQuantity; private TextBox txtQuantity;
        private Label lblCapReorder; private TextBox txtReorder;
        private Label lblCapDescription; private TextBox txtDescription;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private Panel pnlList;
        private Label lblList;
        private Label lblListHint;
        private Button btnRefresh;
        private TextBox txtSearch;
        private DataGridView dgvProducts;
    }
}