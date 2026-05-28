using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Window_Form_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LbTitle = new Label();
            LbEmail = new Label();
            txtEmail = new TextBox();
            LbMatKhau = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // LbTitle
            // 
            LbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LbTitle.AutoSize = true;
            LbTitle.Location = new Point(280, 71);
            LbTitle.Name = "LbTitle";
            LbTitle.Size = new Size(150, 32);
            LbTitle.TabIndex = 0;
            LbTitle.Text = "ĐĂNG NHẬP";
            // 
            // LbEmail
            // 
            LbEmail.AutoSize = true;
            LbEmail.Location = new Point(92, 194);
            LbEmail.Name = "LbEmail";
            LbEmail.Size = new Size(71, 32);
            LbEmail.TabIndex = 1;
            LbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 247);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(476, 39);
            txtEmail.TabIndex = 2;
            // 
            // LbMatKhau
            // 
            LbMatKhau.AutoSize = true;
            LbMatKhau.Location = new Point(92, 329);
            LbMatKhau.Name = "LbMatKhau";
            LbMatKhau.Size = new Size(115, 32);
            LbMatKhau.TabIndex = 3;
            LbMatKhau.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(92, 382);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(476, 39);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(280, 527);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 718);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(LbMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(LbEmail);
            Controls.Add(LbTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitle;
        private Label LbEmail;
        private TextBox txtEmail;
        private Label LbMatKhau;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
