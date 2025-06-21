namespace pizza.Forms
{
    partial class searchcustomer
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
            txtcustomername = new Label();
            txtcustomerphone = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnsearch = new Button();
            btnexit = new Button();
            btnback = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 27);
            label1.Name = "label1";
            label1.Size = new Size(405, 41);
            label1.TabIndex = 0;
            label1.Text = "SEARCH CUSTOMER";
            // 
            // txtcustomername
            // 
            txtcustomername.AutoSize = true;
            txtcustomername.Location = new Point(373, 128);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(141, 25);
            txtcustomername.TabIndex = 1;
            txtcustomername.Text = "Customer Name";
            // 
            // txtcustomerphone
            // 
            txtcustomerphone.AutoSize = true;
            txtcustomerphone.Location = new Point(373, 186);
            txtcustomerphone.Name = "txtcustomerphone";
            txtcustomerphone.Size = new Size(173, 25);
            txtcustomerphone.TabIndex = 2;
            txtcustomerphone.Text = "Customer Phone No";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(628, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(628, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 31);
            textBox2.TabIndex = 4;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(732, 256);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(112, 34);
            btnsearch.TabIndex = 5;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1084, 564);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 6;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            btnback.Location = new Point(12, 564);
            btnback.Name = "btnback";
            btnback.RightToLeft = RightToLeft.No;
            btnback.Size = new Size(112, 34);
            btnback.TabIndex = 7;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1209, 262);
            dataGridView1.TabIndex = 8;
            // 
            // searchcustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 610);
            Controls.Add(dataGridView1);
            Controls.Add(btnback);
            Controls.Add(btnexit);
            Controls.Add(btnsearch);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtcustomerphone);
            Controls.Add(txtcustomername);
            Controls.Add(label1);
            Name = "searchcustomer";
            Text = "searchcustomer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtcustomername;
        private Label txtcustomerphone;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnsearch;
        private Button btnexit;
        private Button btnback;
        private DataGridView dataGridView1;
    }
}