namespace JatiHotel
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.foodAndDrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_checkin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_LogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_tanggal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_frontOffice = new System.Windows.Forms.ToolStripLabel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem_Employee,
            this.foodAndDrinkToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.roomTypeToolStripMenuItem,
            this.roomToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.transactionToolStripMenuItem.Text = "Master";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem_Employee
            // 
            this.checkOutToolStripMenuItem_Employee.Name = "checkOutToolStripMenuItem_Employee";
            this.checkOutToolStripMenuItem_Employee.Size = new System.Drawing.Size(180, 22);
            this.checkOutToolStripMenuItem_Employee.Text = "Employee";
            this.checkOutToolStripMenuItem_Employee.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // foodAndDrinkToolStripMenuItem
            // 
            this.foodAndDrinkToolStripMenuItem.Name = "foodAndDrinkToolStripMenuItem";
            this.foodAndDrinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.foodAndDrinkToolStripMenuItem.Text = "Food and Drink";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // roomTypeToolStripMenuItem
            // 
            this.roomTypeToolStripMenuItem.Name = "roomTypeToolStripMenuItem";
            this.roomTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomTypeToolStripMenuItem.Text = "Room Type";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_checkin,
            this.toolStripSeparator1,
            this.toolStripButton_LogOut,
            this.toolStripButton_Exit,
            this.toolStripLabel_tanggal,
            this.toolStripLabel_frontOffice});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1066, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_checkin
            // 
            this.toolStripButton_checkin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_checkin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_checkin.Image")));
            this.toolStripButton_checkin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_checkin.Name = "toolStripButton_checkin";
            this.toolStripButton_checkin.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton_checkin.Text = "Employee";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_LogOut
            // 
            this.toolStripButton_LogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_LogOut.Image")));
            this.toolStripButton_LogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_LogOut.MergeIndex = 0;
            this.toolStripButton_LogOut.Name = "toolStripButton_LogOut";
            this.toolStripButton_LogOut.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton_LogOut.Text = "Log Out";
            this.toolStripButton_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton_LogOut.Click += new System.EventHandler(this.toolStripButton_LogOut_Click);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(30, 22);
            this.toolStripButton_Exit.Text = "Exit";
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // toolStripLabel_tanggal
            // 
            this.toolStripLabel_tanggal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_tanggal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel_tanggal.Name = "toolStripLabel_tanggal";
            this.toolStripLabel_tanggal.Size = new System.Drawing.Size(137, 22);
            this.toolStripLabel_tanggal.Text = "23-December-2019 12:00";
            // 
            // toolStripLabel_frontOffice
            // 
            this.toolStripLabel_frontOffice.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_frontOffice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel_frontOffice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.toolStripLabel_frontOffice.Name = "toolStripLabel_frontOffice";
            this.toolStripLabel_frontOffice.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.toolStripLabel_frontOffice.Size = new System.Drawing.Size(93, 23);
            this.toolStripLabel_frontOffice.Text = "Admin";
            this.toolStripLabel_frontOffice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel_frontOffice.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(0, 52);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1066, 572);
            this.panel_main.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 626);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_checkin;
        private System.Windows.Forms.ToolStripButton toolStripButton_LogOut;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_tanggal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_frontOffice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem_Employee;
        private System.Windows.Forms.ToolStripMenuItem foodAndDrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.Panel panel_main;
    }
}