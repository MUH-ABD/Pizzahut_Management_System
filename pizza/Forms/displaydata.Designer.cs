namespace pizza.Forms
{
    partial class displaydata
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
            dataGridView1 = new DataGridView();
            btnback = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 34);
            label1.Name = "label1";
            label1.Size = new Size(314, 41);
            label1.TabIndex = 0;
            label1.Text = "DISPLAY DATA";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1135, 406);
            dataGridView1.TabIndex = 1;
            // 
            // btnback
            // 
            btnback.Location = new Point(1, 553);
            btnback.Name = "btnback";
            btnback.Size = new Size(112, 34);
            btnback.TabIndex = 2;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1013, 554);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 3;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // displaydata
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 600);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "displaydata";
            Text = "displaydata";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnback;
        private Button btnexit;
    }
}