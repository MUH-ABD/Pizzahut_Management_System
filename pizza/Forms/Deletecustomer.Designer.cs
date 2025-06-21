namespace pizza.Forms
{
    partial class Deletecustomer
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
            dataGridView1 = new DataGridView();
            btnback = new Button();
            btnexit = new Button();
            btndelete = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtcustomerphone = new Label();
            txtcustomername = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-19, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1209, 262);
            dataGridView1.TabIndex = 17;
            // 
            // btnback
            // 
            btnback.Location = new Point(-6, 554);
            btnback.Name = "btnback";
            btnback.RightToLeft = RightToLeft.No;
            btnback.Size = new Size(112, 34);
            btnback.TabIndex = 16;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1066, 554);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 15;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(714, 246);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(112, 34);
            btndelete.TabIndex = 14;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(610, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 31);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(610, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 31);
            textBox1.TabIndex = 12;
            // 
            // txtcustomerphone
            // 
            txtcustomerphone.AutoSize = true;
            txtcustomerphone.Location = new Point(355, 176);
            txtcustomerphone.Name = "txtcustomerphone";
            txtcustomerphone.Size = new Size(173, 25);
            txtcustomerphone.TabIndex = 11;
            txtcustomerphone.Text = "Customer Phone No";
            // 
            // txtcustomername
            // 
            txtcustomername.AutoSize = true;
            txtcustomername.Location = new Point(355, 118);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(141, 25);
            txtcustomername.TabIndex = 10;
            txtcustomername.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 17);
            label1.Name = "label1";
            label1.Size = new Size(396, 41);
            label1.TabIndex = 9;
            label1.Text = "DELETE CUSTOMER";
            // 
            // Deletecustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 604);
            Controls.Add(dataGridView1);
            Controls.Add(btnback);
            Controls.Add(btnexit);
            Controls.Add(btndelete);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtcustomerphone);
            Controls.Add(txtcustomername);
            Controls.Add(label1);
            Name = "Deletecustomer";
            Text = "Deletecustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnback;
        private Button btnexit;
        private Button btndelete;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label txtcustomerphone;
        private Label txtcustomername;
        private Label label1;
    }
}