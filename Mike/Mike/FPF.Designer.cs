#nullable disable
namespace Login_Sign_in
{
    partial class FPF
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
            txtNewPassword = new TextBox();
            txtConfirm = new TextBox();
            btnReset = new Button();
            linkBack = new LinkLabel();
            pnlCard.SuspendLayout();
            SuspendLayout();

            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(lblSubtitle);
            pnlCard.Controls.Add(txtUser);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(txtNewPassword);
            pnlCard.Controls.Add(txtConfirm);
            pnlCard.Controls.Add(btnReset);
            pnlCard.Controls.Add(linkBack);
            pnlCard.Location = new Point(30, 30);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(380, 470);
            pnlCard.Tag = "card";

            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(28, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Tag = "title";
            lblTitle.Text = "Reset password";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(31, 76);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Tag = "muted";
            lblSubtitle.Text = "Enter your username and email";

            txtUser.Location = new Point(30, 125);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Username";
            txtUser.Size = new Size(320, 27);
            txtUser.TabIndex = 0;

            txtEmail.Location = new Point(30, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email on your account";
            txtEmail.Size = new Size(320, 27);
            txtEmail.TabIndex = 1;

            txtNewPassword.Location = new Point(30, 235);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "New password (min 8 characters)";
            txtNewPassword.Size = new Size(320, 27);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.UseSystemPasswordChar = true;

            txtConfirm.Location = new Point(30, 290);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderText = "Confirm new password";
            txtConfirm.Size = new Size(320, 27);
            txtConfirm.TabIndex = 3;
            txtConfirm.UseSystemPasswordChar = true;

            btnReset.Location = new Point(30, 350);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(320, 42);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset password";
            btnReset.Click += btnReset_Click;

            linkBack.AutoSize = true;
            linkBack.Location = new Point(30, 412);
            linkBack.Name = "linkBack";
            linkBack.TabIndex = 5;
            linkBack.TabStop = true;
            linkBack.Text = "Back to log in";
            linkBack.LinkClicked += linkBack_LinkClicked;

            AcceptButton = btnReset;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 244, 253);
            ClientSize = new Size(440, 530);
            Controls.Add(pnlCard);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FPF";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LGSI - Reset password";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlCard;
        private Label lblTitle;
        private Label lblSubtitle;
        private TextBox txtUser;
        private TextBox txtEmail;
        private TextBox txtNewPassword;
        private TextBox txtConfirm;
        private Button btnReset;
        private LinkLabel linkBack;
    }
}
