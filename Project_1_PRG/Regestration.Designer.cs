
namespace Project_1_PRG
{
    partial class Regestration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRPassword = new System.Windows.Forms.Label();
            this.lbRUsername = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lbConfPassword = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.btnLoginredirect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRPassword
            // 
            this.lbRPassword.AutoSize = true;
            this.lbRPassword.Location = new System.Drawing.Point(51, 84);
            this.lbRPassword.Name = "lbRPassword";
            this.lbRPassword.Size = new System.Drawing.Size(53, 13);
            this.lbRPassword.TabIndex = 12;
            this.lbRPassword.Text = "Password";
            // 
            // lbRUsername
            // 
            this.lbRUsername.AutoSize = true;
            this.lbRUsername.Location = new System.Drawing.Point(51, 21);
            this.lbRUsername.Name = "lbRUsername";
            this.lbRUsername.Size = new System.Drawing.Size(55, 13);
            this.lbRUsername.TabIndex = 11;
            this.lbRUsername.Text = "Username";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(65, 225);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 10;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(54, 46);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 9;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(54, 114);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 8;
            // 
            // lbConfPassword
            // 
            this.lbConfPassword.AutoSize = true;
            this.lbConfPassword.Location = new System.Drawing.Point(51, 144);
            this.lbConfPassword.Name = "lbConfPassword";
            this.lbConfPassword.Size = new System.Drawing.Size(91, 13);
            this.lbConfPassword.TabIndex = 14;
            this.lbConfPassword.Text = "Confirm Password";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(54, 174);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.PasswordChar = '*';
            this.txtconfirmpassword.Size = new System.Drawing.Size(100, 20);
            this.txtconfirmpassword.TabIndex = 13;
            // 
            // btnLoginredirect
            // 
            this.btnLoginredirect.Location = new System.Drawing.Point(29, 254);
            this.btnLoginredirect.Name = "btnLoginredirect";
            this.btnLoginredirect.Size = new System.Drawing.Size(157, 23);
            this.btnLoginredirect.TabIndex = 15;
            this.btnLoginredirect.Text = "Have Account? Login Now";
            this.btnLoginredirect.UseVisualStyleBackColor = true;
            this.btnLoginredirect.Click += new System.EventHandler(this.btnLoginredirect_Click);
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 316);
            this.Controls.Add(this.btnLoginredirect);
            this.Controls.Add(this.lbConfPassword);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.lbRPassword);
            this.Controls.Add(this.lbRUsername);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Name = "Regestration";
            this.Text = "Regestration";
            this.Load += new System.EventHandler(this.Regestration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbRPassword;
        private System.Windows.Forms.Label lbRUsername;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lbConfPassword;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Button btnLoginredirect;
    }
}