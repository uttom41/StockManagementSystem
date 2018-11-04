namespace StockManagementSystem
{
    partial class SearchAndViewItemSummary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchAndViewItemButton = new System.Windows.Forms.Button();
            this.SearchAndViewItemdataGridView = new System.Windows.Forms.DataGridView();
            this.SearchAndViewCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SearchAndViewCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAndViewItemdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.groupBox1.Controls.Add(this.SearchAndViewItemButton);
            this.groupBox1.Controls.Add(this.SearchAndViewItemdataGridView);
            this.groupBox1.Controls.Add(this.SearchAndViewCategoryComboBox);
            this.groupBox1.Controls.Add(this.SearchAndViewCompanyComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(25, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search And View Item Summary";
            // 
            // SearchAndViewItemButton
            // 
            this.SearchAndViewItemButton.Location = new System.Drawing.Point(437, 123);
            this.SearchAndViewItemButton.Name = "SearchAndViewItemButton";
            this.SearchAndViewItemButton.Size = new System.Drawing.Size(75, 23);
            this.SearchAndViewItemButton.TabIndex = 5;
            this.SearchAndViewItemButton.Text = "Search";
            this.SearchAndViewItemButton.UseVisualStyleBackColor = true;
            // 
            // SearchAndViewItemdataGridView
            // 
            this.SearchAndViewItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchAndViewItemdataGridView.Location = new System.Drawing.Point(15, 166);
            this.SearchAndViewItemdataGridView.Name = "SearchAndViewItemdataGridView";
            this.SearchAndViewItemdataGridView.Size = new System.Drawing.Size(655, 257);
            this.SearchAndViewItemdataGridView.TabIndex = 4;
            // 
            // SearchAndViewCategoryComboBox
            // 
            this.SearchAndViewCategoryComboBox.FormattingEnabled = true;
            this.SearchAndViewCategoryComboBox.Location = new System.Drawing.Point(268, 79);
            this.SearchAndViewCategoryComboBox.Name = "SearchAndViewCategoryComboBox";
            this.SearchAndViewCategoryComboBox.Size = new System.Drawing.Size(244, 24);
            this.SearchAndViewCategoryComboBox.TabIndex = 3;
            // 
            // SearchAndViewCompanyComboBox
            // 
            this.SearchAndViewCompanyComboBox.FormattingEnabled = true;
            this.SearchAndViewCompanyComboBox.Location = new System.Drawing.Point(268, 37);
            this.SearchAndViewCompanyComboBox.Name = "SearchAndViewCompanyComboBox";
            this.SearchAndViewCompanyComboBox.Size = new System.Drawing.Size(244, 24);
            this.SearchAndViewCompanyComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company :";
            // 
            // SearchAndViewItemSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 463);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchAndViewItemSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchAndViewItemSummary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAndViewItemdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView SearchAndViewItemdataGridView;
        private System.Windows.Forms.ComboBox SearchAndViewCategoryComboBox;
        private System.Windows.Forms.ComboBox SearchAndViewCompanyComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchAndViewItemButton;
    }
}