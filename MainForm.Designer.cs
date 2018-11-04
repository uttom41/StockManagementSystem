namespace StockManagementSystem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categorySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSearchDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchViewItemsSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.stockInOutToolStripMenuItem,
            this.reportSearchDataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 0, 7);
            this.menuStrip1.Size = new System.Drawing.Size(852, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(0)))), ((int)(((byte)(71)))));
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorySetupToolStripMenuItem,
            this.companySetupToolStripMenuItem,
            this.itemSetupToolStripMenuItem});
            this.setupToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.setupToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.setupToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // categorySetupToolStripMenuItem
            // 
            this.categorySetupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.categorySetupToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorySetupToolStripMenuItem.Name = "categorySetupToolStripMenuItem";
            this.categorySetupToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.categorySetupToolStripMenuItem.Text = "Category Setup";
            this.categorySetupToolStripMenuItem.Click += new System.EventHandler(this.categorySetupToolStripMenuItem_Click);
            // 
            // companySetupToolStripMenuItem
            // 
            this.companySetupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.companySetupToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companySetupToolStripMenuItem.Name = "companySetupToolStripMenuItem";
            this.companySetupToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.companySetupToolStripMenuItem.Text = "Company Setup";
            this.companySetupToolStripMenuItem.Click += new System.EventHandler(this.companySetupToolStripMenuItem_Click);
            // 
            // itemSetupToolStripMenuItem
            // 
            this.itemSetupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemSetupToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSetupToolStripMenuItem.Name = "itemSetupToolStripMenuItem";
            this.itemSetupToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.itemSetupToolStripMenuItem.Text = "Item Setup";
            this.itemSetupToolStripMenuItem.Click += new System.EventHandler(this.itemSetupToolStripMenuItem_Click);
            // 
            // stockInOutToolStripMenuItem
            // 
            this.stockInOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockInToolStripMenuItem,
            this.stockOutToolStripMenuItem});
            this.stockInOutToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInOutToolStripMenuItem.Name = "stockInOutToolStripMenuItem";
            this.stockInOutToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.stockInOutToolStripMenuItem.Text = "Stock In / Out";
            // 
            // stockInToolStripMenuItem
            // 
            this.stockInToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockInToolStripMenuItem.Name = "stockInToolStripMenuItem";
            this.stockInToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.stockInToolStripMenuItem.Text = "Stock In";
            this.stockInToolStripMenuItem.Click += new System.EventHandler(this.stockInToolStripMenuItem_Click);
            // 
            // stockOutToolStripMenuItem
            // 
            this.stockOutToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            this.stockOutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.stockOutToolStripMenuItem.Text = "Stock Out";
            this.stockOutToolStripMenuItem.Click += new System.EventHandler(this.stockOutToolStripMenuItem_Click);
            // 
            // reportSearchDataToolStripMenuItem
            // 
            this.reportSearchDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchViewItemsSummaryToolStripMenuItem,
            this.viewSalesToolStripMenuItem});
            this.reportSearchDataToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportSearchDataToolStripMenuItem.Name = "reportSearchDataToolStripMenuItem";
            this.reportSearchDataToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.reportSearchDataToolStripMenuItem.Text = "Report / Search Data";
            // 
            // searchViewItemsSummaryToolStripMenuItem
            // 
            this.searchViewItemsSummaryToolStripMenuItem.Name = "searchViewItemsSummaryToolStripMenuItem";
            this.searchViewItemsSummaryToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.searchViewItemsSummaryToolStripMenuItem.Text = "Search And View Items Summary";
            this.searchViewItemsSummaryToolStripMenuItem.Click += new System.EventHandler(this.searchViewItemsSummaryToolStripMenuItem_Click);
            // 
            // viewSalesToolStripMenuItem
            // 
            this.viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            this.viewSalesToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.viewSalesToolStripMenuItem.Text = "View Sales Between Two Dates";
            this.viewSalesToolStripMenuItem.Click += new System.EventHandler(this.viewSalesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(852, 426);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Stock Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categorySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportSearchDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchViewItemsSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSalesToolStripMenuItem;

    }
}

