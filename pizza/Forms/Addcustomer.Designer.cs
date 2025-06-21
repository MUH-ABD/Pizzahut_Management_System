namespace pizza.Forms
{
    partial class Addcustomer
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
            txtphoneno = new Label();
            txtpizzaname = new Label();
            txtsalad = new Label();
            txtdrink = new Label();
            txtgovttax = new Label();
            txttotal = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            btnback = new Button();
            btnexit = new Button();
            btnadd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 24);
            label1.Name = "label1";
            label1.Size = new Size(332, 41);
            label1.TabIndex = 0;
            label1.Text = "ADD CUSTOMER";
            // 
            // txtcustomername
            // 
            txtcustomername.AutoSize = true;
            txtcustomername.Location = new Point(321, 130);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(141, 25);
            txtcustomername.TabIndex = 1;
            txtcustomername.Text = "Customer Name";
            // 
            // txtphoneno
            // 
            txtphoneno.AutoSize = true;
            txtphoneno.Location = new Point(321, 176);
            txtphoneno.Name = "txtphoneno";
            txtphoneno.Size = new Size(91, 25);
            txtphoneno.TabIndex = 2;
            txtphoneno.Text = "Phone No";
            // 
            // txtpizzaname
            // 
            txtpizzaname.AutoSize = true;
            txtpizzaname.Location = new Point(321, 226);
            txtpizzaname.Name = "txtpizzaname";
            txtpizzaname.Size = new Size(103, 25);
            txtpizzaname.TabIndex = 3;
            txtpizzaname.Text = "Pizza Name";
            // 
            // txtsalad
            // 
            txtsalad.AutoSize = true;
            txtsalad.Location = new Point(321, 280);
            txtsalad.Name = "txtsalad";
            txtsalad.Size = new Size(55, 25);
            txtsalad.TabIndex = 4;
            txtsalad.Text = "Salad";
            // 
            // txtdrink
            // 
            txtdrink.AutoSize = true;
            txtdrink.Location = new Point(321, 337);
            txtdrink.Name = "txtdrink";
            txtdrink.Size = new Size(54, 25);
            txtdrink.TabIndex = 5;
            txtdrink.Text = "Drink";
            // 
            // txtgovttax
            // 
            txtgovttax.AutoSize = true;
            txtgovttax.Location = new Point(321, 392);
            txtgovttax.Name = "txtgovttax";
            txtgovttax.Size = new Size(79, 25);
            txtgovttax.TabIndex = 6;
            txtgovttax.Text = "Govt Tax";
            // 
            // txttotal
            // 
            txttotal.AutoSize = true;
            txttotal.Location = new Point(321, 446);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(49, 25);
            txttotal.TabIndex = 9;
            txttotal.Text = "Total";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(606, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 31);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(606, 443);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(606, 386);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(232, 31);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(606, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(232, 31);
            textBox4.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sausage", "Supreme", "Fajita", "Tikka", "Vegetable", "Cheese" });
            comboBox1.Location = new Point(606, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 33);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Russian Salad", "Pakistani Salad", "Canadian Salad", "Israeli Salad" });
            comboBox2.Location = new Point(606, 280);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 33);
            comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Wine", "Beer", "Cola", "Red Apple", "Gold Apple", "Milk" });
            comboBox3.Location = new Point(606, 329);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(232, 33);
            comboBox3.TabIndex = 16;
            // 
            // btnback
            // 
            btnback.Location = new Point(12, 548);
            btnback.Name = "btnback";
            btnback.Size = new Size(109, 46);
            btnback.TabIndex = 17;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(1044, 548);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 46);
            btnexit.TabIndex = 18;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(1044, 481);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(109, 46);
            btnadd.TabIndex = 19;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // Addcustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 606);
            Controls.Add(btnadd);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txttotal);
            Controls.Add(txtgovttax);
            Controls.Add(txtdrink);
            Controls.Add(txtsalad);
            Controls.Add(txtpizzaname);
            Controls.Add(txtphoneno);
            Controls.Add(txtcustomername);
            Controls.Add(label1);
            Name = "Addcustomer";
            Text = "Addcustomer";
            Load += Addcustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtcustomername;
        private Label txtphoneno;
        private Label txtpizzaname;
        private Label txtsalad;
        private Label txtdrink;
        private Label txtgovttax;
        private Label txttotal;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button btnback;
        private Button btnexit;
        private Button btnadd;
    }
}