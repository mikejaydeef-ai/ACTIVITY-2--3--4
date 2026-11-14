#nullable disable
namespace Login_Sign_in
{
    partial class LGF
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
            txtPassword = new TextBox();
            btnLogin = new Button();
            linkForgot = new LinkLabel();
            linkSignUp = new LinkLabel();
            pnlCard.SuspendLayout();
            SuspendLayout();

            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(txtPassword);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(linkForgot);
            pnlCard.Controls.Add(linkSignUp);
            pnlCard.Location = new Point(30, 30);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(380, 400);
            pnlCard.Tag = "card";

            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(28, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Tag = "title";
            lblTitle.Text = "Welcome back";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(31, 76);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "Log in to your account";

            txtUser.Location = new Point(30, 125);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(320, 27);
            txtUser.TabIndex = 0;

            txtPassword.Location = new Point(30, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(320, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;

            btnLogin.Location = new Point(30, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log in";
            btnLogin.Click += btnLogin_Click;

            linkForgot.AutoSize = true;
            linkForgot.Location = new Point(30, 302);
            linkForgot.Name = "linkForgot";
            linkForgot.TabIndex = 3;
            linkForgot.TabStop = true;
            linkForgot.Text = "Forgot password?";
            linkForgot.LinkClicked += linkForgot_LinkClicked;

            linkSignUp.AutoSize = true;
            linkSignUp.Location = new Point(30, 340);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.TabIndex = 4;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Don't have an account? Sign up";
            linkSignUp.LinkArea = new LinkArea(23, 7);
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;

            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 244, 253);
            ClientSize = new Size(440, 460);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LGF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LGSI - Log in";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkForgot;
        private LinkLabel linkSignUp;
    }
}
