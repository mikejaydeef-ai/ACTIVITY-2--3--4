#nullable disable
namespace Login_Sign_in
{
    partial class SUF
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlCard = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtUser = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnRegister = new Button();
            linkLogin = new LinkLabel();
            pnlCard.SuspendLayout();
            SuspendLayout();

            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(txtConfirm);
            pnlCard.Controls.Add(btnRegister);
            pnlCard.Controls.Add(linkLogin);
            pnlCard.Location = new Point(30, 30);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(380, 470);
            pnlCard.Tag = "card";

            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(28, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Tag = "title";
            lblTitle.Text = "Create account";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(31, 76);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "Sign up to get started";

            txtUser.Location = new Point(30, 125);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(320, 27);
            txtUser.TabIndex = 0;

            txtEmail.Location = new Point(30, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(320, 27);
            txtEmail.TabIndex = 1;

            txtPassword.Location = new Point(30, 235);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password (min 8 characters)";
            txtPassword.Size = new Size(320, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;

            txtConfirm.Location = new Point(30, 290);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Confirm password";
            txtConfirm.Size = new Size(320, 27);
            txtConfirm.TabIndex = 3;
            txtConfirm.UseSystemPasswordChar = true;

            btnRegister.Location = new Point(30, 350);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(320, 42);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Create account";
            btnRegister.Click += btnRegister_Click;

            linkLogin.AutoSize = true;
            linkLogin.Location = new Point(30, 412);
            linkLogin.Name = "linkLogin";
            linkLogin.TabIndex = 5;
            linkLogin.TabStop = true;
            linkLogin.Text = "Already have an account? Log in";
            linkLogin.LinkArea = new LinkArea(25, 6);
            linkLogin.LinkClicked += linkLogin_LinkClicked;

            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 244, 253);
            ClientSize = new Size(440, 530);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SUF";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LGSI - Sign up";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUser;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Button btnRegister;
        private LinkLabel linkLogin;
    }
}
