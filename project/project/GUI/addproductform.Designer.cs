namespace project.GUI
{
    partial class addproductform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addproductform));
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MarketPriceTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(182, 251);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 50);
            this.button2.TabIndex = 108;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 107;
            this.label5.Text = "Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 104;
            this.label10.Text = "Price";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.Transparent;
            this.AddProductButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddProductButton.BackgroundImage")));
            this.AddProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddProductButton.Location = new System.Drawing.Point(538, 251);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(91, 50);
            this.AddProductButton.TabIndex = 100;
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 46);
            this.label3.TabIndex = 99;
            this.label3.Text = "Add Product";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MarketPriceTextBox
            // 
            this.MarketPriceTextBox.Location = new System.Drawing.Point(139, 187);
            this.MarketPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MarketPriceTextBox.Name = "MarketPriceTextBox";
            this.MarketPriceTextBox.Size = new System.Drawing.Size(199, 20);
            this.MarketPriceTextBox.TabIndex = 98;
            this.MarketPriceTextBox.TextChanged += new System.EventHandler(this.MarketPriceTextBox_TextChanged);
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(475, 98);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(199, 20);
            this.AmountTextBox.TabIndex = 96;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(139, 139);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(199, 20);
            this.PriceTextBox.TabIndex = 95;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "Market Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(139, 95);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(199, 20);
            this.NameTextBox.TabIndex = 94;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(475, 145);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(199, 20);
            this.TypeTextBox.TabIndex = 110;
            this.TypeTextBox.TextChanged += new System.EventHandler(this.TypeTextBox_TextChanged);
            // 
            // addproductform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 380);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MarketPriceTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addproductform";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.addproductform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MarketPriceTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
    }
}