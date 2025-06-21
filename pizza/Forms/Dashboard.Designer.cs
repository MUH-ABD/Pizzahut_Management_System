namespace pizza.Forms
{
    partial class Dashboard
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
            btnaddcustomer = new Button();
            btnupdatecustomer = new Button();
            btndeletecustomer = new Button();
            btnsearchcustomer = new Button();
            btndisplaydata = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(571, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 36);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(295, 556);
            dataGridView1.TabIndex = 1;
            // 
            // btnaddcustomer
            // 
            btnaddcustomer.Location = new Point(44, 110);
            btnaddcustomer.Name = "btnaddcustomer";
            btnaddcustomer.Size = new Size(171, 44);
            btnaddcustomer.TabIndex = 2;
            btnaddcustomer.Text = "Add Customer";
            btnaddcustomer.UseVisualStyleBackColor = true;
            btnaddcustomer.Click += btnaddcustomer_Click;
            // 
            // btnupdatecustomer
            // 
            btnupdatecustomer.Location = new Point(44, 181);
            btnupdatecustomer.Name = "btnupdatecustomer";
            btnupdatecustomer.Size = new Size(171, 44);
            btnupdatecustomer.TabIndex = 3;
            btnupdatecustomer.Text = "Update Customer";
            btnupdatecustomer.UseVisualStyleBackColor = true;
            btnupdatecustomer.Click += btnupdatecustomer_Click;
            // 
            // btndeletecustomer
            // 
            btndeletecustomer.Location = new Point(44, 251);
            btndeletecustomer.Name = "btndeletecustomer";
            btndeletecustomer.Size = new Size(171, 44);
            btndeletecustomer.TabIndex = 4;
            btndeletecustomer.Text = "Delete Customer";
            btndeletecustomer.UseVisualStyleBackColor = true;
            btndeletecustomer.Click += btndeletecustomer_Click;
            // 
            // btnsearchcustomer
            // 
            btnsearchcustomer.Location = new Point(44, 324);
            btnsearchcustomer.Name = "btnsearchcustomer";
            btnsearchcustomer.Size = new Size(171, 44);
            btnsearchcustomer.TabIndex = 5;
            btnsearchcustomer.Text = "Search Customer";
            btnsearchcustomer.UseVisualStyleBackColor = true;
            btnsearchcustomer.Click += btnsearchcustomer_Click;
            // 
            // btndisplaydata
            // 
            btndisplaydata.Location = new Point(44, 394);
            btndisplaydata.Name = "btndisplaydata";
            btndisplaydata.Size = new Size(171, 44);
            btndisplaydata.TabIndex = 6;
            btndisplaydata.Text = "Display Data";
            btndisplaydata.UseVisualStyleBackColor = true;
            btndisplaydata.Click += btndisplaydata_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1022, 499);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(112, 34);
            btnexit.TabIndex = 8;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 554);
            Controls.Add(btnexit);
            Controls.Add(btndisplaydata);
            Controls.Add(btnsearchcustomer);
            Controls.Add(btndeletecustomer);
            Controls.Add(btnupdatecustomer);
            Controls.Add(btnaddcustomer);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnaddcustomer;
        private Button btnupdatecustomer;
        private Button btndeletecustomer;
        private Button btnsearchcustomer;
        private Button btndisplaydata;
        private Button btnexit;
    }
}