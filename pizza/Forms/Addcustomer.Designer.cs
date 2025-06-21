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
            label69 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            txttotal = new TextBox();
            txtgovttax = new TextBox();
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
            label1.Location = new Point(287, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 27);
            label1.TabIndex = 0;
            label1.Text = "ADD CUSTOMER";
            // 
            // txtcustomername
            // 
            txtcustomername.AutoSize = true;
            txtcustomername.Location = new Point(225, 78);
            txtcustomername.Margin = new Padding(2, 0, 2, 0);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(94, 15);
            txtcustomername.TabIndex = 1;
            txtcustomername.Text = "Customer Name";
            // 
            // txtphoneno
            // 
            txtphoneno.AutoSize = true;
            txtphoneno.Location = new Point(225, 106);
            txtphoneno.Margin = new Padding(2, 0, 2, 0);
            txtphoneno.Name = "txtphoneno";
            txtphoneno.Size = new Size(60, 15);
            txtphoneno.TabIndex = 2;
            txtphoneno.Text = "Phone No";
            // 
            // txtpizzaname
            // 
            txtpizzaname.AutoSize = true;
            txtpizzaname.Location = new Point(225, 136);
            txtpizzaname.Margin = new Padding(2, 0, 2, 0);
            txtpizzaname.Name = "txtpizzaname";
            txtpizzaname.Size = new Size(68, 15);
            txtpizzaname.TabIndex = 3;
            txtpizzaname.Text = "Pizza Name";
            // 
            // txtsalad
            // 
            txtsalad.AutoSize = true;
            txtsalad.Location = new Point(225, 168);
            txtsalad.Margin = new Padding(2, 0, 2, 0);
            txtsalad.Name = "txtsalad";
            txtsalad.Size = new Size(35, 15);
            txtsalad.TabIndex = 4;
            txtsalad.Text = "Salad";
            // 
            // txtdrink
            // 
            txtdrink.AutoSize = true;
            txtdrink.Location = new Point(225, 202);
            txtdrink.Margin = new Padding(2, 0, 2, 0);
            txtdrink.Name = "txtdrink";
            txtdrink.Size = new Size(35, 15);
            txtdrink.TabIndex = 5;
            txtdrink.Text = "Drink";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(225, 235);
            label69.Margin = new Padding(2, 0, 2, 0);
            label69.Name = "label69";
            label69.Size = new Size(52, 15);
            label69.TabIndex = 6;
            label69.Text = "Govt Tax";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(225, 268);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 9;
            label9.Text = "Total";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 72);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 10;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(424, 266);
            txttotal.Margin = new Padding(2);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(164, 23);
            txttotal.TabIndex = 11;
            // 
            // txtgovttax
            // 
            txtgovttax.Location = new Point(424, 232);
            txtgovttax.Margin = new Padding(2);
            txtgovttax.Name = "txtgovttax";
            txtgovttax.Size = new Size(164, 23);
            txtgovttax.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(424, 106);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(164, 23);
            textBox4.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sausage", "Supreme", "Fajita", "Tikka", "Vegetable", "Cheese" });
            comboBox1.Location = new Point(424, 136);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Russian Salad", "Pakistani Salad", "Canadian Salad", "Israeli Salad" });
            comboBox2.Location = new Point(424, 168);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(164, 23);
            comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Wine", "Beer", "Cola", "Red Apple", "Gold Apple", "Milk" });
            comboBox3.Location = new Point(424, 197);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(164, 23);
            comboBox3.TabIndex = 16;
            // 
            // btnback
            // 
            btnback.Location = new Point(8, 329);
            btnback.Margin = new Padding(2);
            btnback.Name = "btnback";
            btnback.Size = new Size(76, 28);
            btnback.TabIndex = 17;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(731, 329);
            btnexit.Margin = new Padding(2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(76, 28);
            btnexit.TabIndex = 18;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(731, 289);
            btnadd.Margin = new Padding(2);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(76, 28);
            btnadd.TabIndex = 19;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // Addcustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 364);
            Controls.Add(btnadd);
            Controls.Add(btnexit);
            Controls.Add(btnback);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(txtgovttax);
            Controls.Add(txttotal);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label69);
            Controls.Add(txtdrink);
            Controls.Add(txtsalad);
            Controls.Add(txtpizzaname);
            Controls.Add(txtphoneno);
            Controls.Add(txtcustomername);
            Controls.Add(label1);
            Margin = new Padding(2);
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
        private Label label69;
        private Label label9;
        private TextBox textBox1;
        private TextBox txttotal;
        private TextBox txtgovttax;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button btnback;
        private Button btnexit;
        private Button btnadd;
    }
}