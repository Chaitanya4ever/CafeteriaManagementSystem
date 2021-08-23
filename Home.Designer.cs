namespace My_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emmployeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coffeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboPackReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coustomer,
            this.employeeToolStripMenuItem,
            this.placeOrderToolStripMenuItem,
            this.productDetailsToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coustomer
            // 
            this.coustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coustomer.Name = "coustomer";
            this.coustomer.Size = new System.Drawing.Size(87, 21);
            this.coustomer.Text = "Coustomer";
            this.coustomer.Click += new System.EventHandler(this.coustomerToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeToolStripMenuItem.BackgroundImage")));
            this.employeeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coffeeToolStripMenuItem,
            this.comboPackToolStripMenuItem,
            this.pizzaToolStripMenuItem});
            this.placeOrderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            // 
            // coffeeToolStripMenuItem
            // 
            this.coffeeToolStripMenuItem.Name = "coffeeToolStripMenuItem";
            this.coffeeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.coffeeToolStripMenuItem.Text = "Coffee";
            this.coffeeToolStripMenuItem.Click += new System.EventHandler(this.coffeeToolStripMenuItem_Click);
            // 
            // comboPackToolStripMenuItem
            // 
            this.comboPackToolStripMenuItem.Name = "comboPackToolStripMenuItem";
            this.comboPackToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.comboPackToolStripMenuItem.Text = "ComboPack";
            this.comboPackToolStripMenuItem.Click += new System.EventHandler(this.comboPackToolStripMenuItem_Click);
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.pizzaToolStripMenuItem_Click);
            // 
            // productDetailsToolStripMenuItem
            // 
            this.productDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDetailsToolStripMenuItem.Name = "productDetailsToolStripMenuItem";
            this.productDetailsToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.productDetailsToolStripMenuItem.Text = "Product Details";
            this.productDetailsToolStripMenuItem.Click += new System.EventHandler(this.productDetailsToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerReportToolStripMenuItem,
            this.emmployeeReportToolStripMenuItem,
            this.productReportToolStripMenuItem,
            this.coffeeReportToolStripMenuItem,
            this.pizzaReportToolStripMenuItem,
            this.comboPackReportToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.customerReportToolStripMenuItem.Text = "Customer Report";
            this.customerReportToolStripMenuItem.Click += new System.EventHandler(this.customerReportToolStripMenuItem_Click);
            // 
            // emmployeeReportToolStripMenuItem
            // 
            this.emmployeeReportToolStripMenuItem.Name = "emmployeeReportToolStripMenuItem";
            this.emmployeeReportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.emmployeeReportToolStripMenuItem.Text = "Employee Report";
            this.emmployeeReportToolStripMenuItem.Click += new System.EventHandler(this.emmployeeReportToolStripMenuItem_Click);
            // 
            // productReportToolStripMenuItem
            // 
            this.productReportToolStripMenuItem.Name = "productReportToolStripMenuItem";
            this.productReportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.productReportToolStripMenuItem.Text = "Product Report";
            this.productReportToolStripMenuItem.Click += new System.EventHandler(this.productReportToolStripMenuItem_Click);
            // 
            // coffeeReportToolStripMenuItem
            // 
            this.coffeeReportToolStripMenuItem.Name = "coffeeReportToolStripMenuItem";
            this.coffeeReportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.coffeeReportToolStripMenuItem.Text = "Coffee Report";
            this.coffeeReportToolStripMenuItem.Click += new System.EventHandler(this.coffeeReportToolStripMenuItem_Click);
            // 
            // pizzaReportToolStripMenuItem
            // 
            this.pizzaReportToolStripMenuItem.Name = "pizzaReportToolStripMenuItem";
            this.pizzaReportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.pizzaReportToolStripMenuItem.Text = "Pizza Report";
            this.pizzaReportToolStripMenuItem.Click += new System.EventHandler(this.pizzaReportToolStripMenuItem_Click);
            // 
            // comboPackReportToolStripMenuItem
            // 
            this.comboPackReportToolStripMenuItem.Name = "comboPackReportToolStripMenuItem";
            this.comboPackReportToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.comboPackReportToolStripMenuItem.Text = "Combo Pack Report";
            this.comboPackReportToolStripMenuItem.Click += new System.EventHandler(this.comboPackReportToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem1});
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.changePasswordToolStripMenuItem.Text = "Setting";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.exitToolStripMenuItem.Text = "Log Out";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(861, 322);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coustomer;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coffeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboPackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emmployeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coffeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboPackReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
    }
}