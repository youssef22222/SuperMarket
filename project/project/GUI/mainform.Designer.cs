namespace project.GUI
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.productToolStripMenuItem,
            this.billsToolStripMenuItem,
            this.supplierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(684, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductToolStripMenuItem,
            this.listProductToolStripMenuItem});
            this.productToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productToolStripMenuItem.Image")));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageProductToolStripMenuItem.Image")));
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
            // 
            // listProductToolStripMenuItem
            // 
            this.listProductToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listProductToolStripMenuItem.Image")));
            this.listProductToolStripMenuItem.Name = "listProductToolStripMenuItem";
            this.listProductToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.listProductToolStripMenuItem.Text = "List Product";
            this.listProductToolStripMenuItem.Click += new System.EventHandler(this.listProductToolStripMenuItem_Click);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesBillsToolStripMenuItem,
            this.purchaseBillsToolStripMenuItem});
            this.billsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("billsToolStripMenuItem.Image")));
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.billsToolStripMenuItem.Text = "Bills";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // salesBillsToolStripMenuItem
            // 
            this.salesBillsToolStripMenuItem.Image = global::project.Properties.Resources.download__1_;
            this.salesBillsToolStripMenuItem.Name = "salesBillsToolStripMenuItem";
            this.salesBillsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.salesBillsToolStripMenuItem.Text = "Sales Bills";
            this.salesBillsToolStripMenuItem.Click += new System.EventHandler(this.salesBillsToolStripMenuItem_Click);
            // 
            // purchaseBillsToolStripMenuItem
            // 
            this.purchaseBillsToolStripMenuItem.Image = global::project.Properties.Resources.download;
            this.purchaseBillsToolStripMenuItem.Name = "purchaseBillsToolStripMenuItem";
            this.purchaseBillsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.purchaseBillsToolStripMenuItem.Text = "Purchase Bills";
            this.purchaseBillsToolStripMenuItem.Click += new System.EventHandler(this.purchaseBillsToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplierToolStripMenuItem,
            this.manageSuppliersToolStripMenuItem,
            this.editSToolStripMenuItem});
            this.supplierToolStripMenuItem.Image = global::project.Properties.Resources.download__4_;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // addSupplierToolStripMenuItem
            // 
            this.addSupplierToolStripMenuItem.Image = global::project.Properties.Resources.add_icon_button_md;
            this.addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            this.addSupplierToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.addSupplierToolStripMenuItem.Text = "Add Supplier";
            this.addSupplierToolStripMenuItem.Click += new System.EventHandler(this.addSupplierToolStripMenuItem_Click);
            // 
            // manageSuppliersToolStripMenuItem
            // 
            this.manageSuppliersToolStripMenuItem.Image = global::project.Properties.Resources.download__8_;
            this.manageSuppliersToolStripMenuItem.Name = "manageSuppliersToolStripMenuItem";
            this.manageSuppliersToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.manageSuppliersToolStripMenuItem.Text = "Manage Suppliers";
            this.manageSuppliersToolStripMenuItem.Click += new System.EventHandler(this.manageSuppliersToolStripMenuItem_Click);
            // 
            // editSToolStripMenuItem
            // 
            this.editSToolStripMenuItem.Image = global::project.Properties.Resources.download__4_1;
            this.editSToolStripMenuItem.Name = "editSToolStripMenuItem";
            this.editSToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.editSToolStripMenuItem.Text = "List Supplier";
            this.editSToolStripMenuItem.Click += new System.EventHandler(this.editSToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(37, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 92);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(455, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 92);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(455, 211);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 94);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.Location = new System.Drawing.Point(37, 211);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(193, 94);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Purchase Bills";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Suppliers";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sales Bills";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.Location = new System.Drawing.Point(310, 346);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 41);
            this.button7.TabIndex = 93;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLabel.Location = new System.Drawing.Point(305, 94);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(65, 26);
            this.EmployeeLabel.TabIndex = 94;
            this.EmployeeLabel.Text = "label7";
            // 
            // BranchLabel
            // 
            this.BranchLabel.AutoSize = true;
            this.BranchLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchLabel.Location = new System.Drawing.Point(305, 137);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(65, 26);
            this.BranchLabel.TabIndex = 95;
            this.BranchLabel.Text = "label8";
            this.BranchLabel.Click += new System.EventHandler(this.BranchLabel_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.BranchLabel);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainform";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.ToolStripMenuItem salesBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSToolStripMenuItem;
    }
}