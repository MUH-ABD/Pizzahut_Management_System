using System.Windows.Forms;

namespace pizza
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            txtpassword = new Label();
            txtusername = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            btnexit = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 28);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 111);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(213, 174);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(87, 25);
            txtpassword.TabIndex = 2;
            txtpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(365, 108);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(235, 31);
            txtusername.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(365, 171);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(235, 31);
            txtpass.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(365, 290);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(112, 34);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(644, 429);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new Point(365, 229);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(235, 40);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 475);
            Controls.Add(chkShowPassword);
            Controls.Add(btnexit);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtusername);
            Controls.Add(txtpassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label txtpassword;
        private TextBox txtusername;
        private TextBox txtpass;
        private Button btnlogin;
        private Button btnexit;
        private CheckBox chkShowPassword;
    }
}