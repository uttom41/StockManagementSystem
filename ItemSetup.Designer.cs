namespace StockManagementSystem
{
    partial class ItemSetup
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemSetupdataGridView = new System.Windows.Forms.DataGridView();
            this.ItemSetupSaveButton = new System.Windows.Forms.Button();
            this.ItemReorderLaveTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemCompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.companyClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemCategoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.categoryClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetupdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClassBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.groupBox1.Controls.Add(this.ItemSetupdataGridView);
            this.groupBox1.Controls.Add(this.ItemSetupSaveButton);
            this.groupBox1.Controls.Add(this.ItemReorderLaveTextBox);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Controls.Add(this.ItemCompanyNameComboBox);
            this.groupBox1.Controls.Add(this.ItemCategoryNameComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Setup";
            // 
            // ItemSetupdataGridView
            // 
            this.ItemSetupdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemSetupdataGridView.Location = new System.Drawing.Point(11, 265);
            this.ItemSetupdataGridView.Name = "ItemSetupdataGridView";
            this.ItemSetupdataGridView.Size = new System.Drawing.Size(587, 189);
            this.ItemSetupdataGridView.TabIndex = 9;
            // 
            // ItemSetupSaveButton
            // 
            this.ItemSetupSaveButton.Location = new System.Drawing.Point(395, 216);
            this.ItemSetupSaveButton.Name = "ItemSetupSaveButton";
            this.ItemSetupSaveButton.Size = new System.Drawing.Size(75, 32);
            this.ItemSetupSaveButton.TabIndex = 8;
            this.ItemSetupSaveButton.Text = "Save";
            this.ItemSetupSaveButton.UseVisualStyleBackColor = true;
            this.ItemSetupSaveButton.Click += new System.EventHandler(this.ItemSetupSaveButton_Click);
            // 
            // ItemReorderLaveTextBox
            // 
            this.ItemReorderLaveTextBox.Location = new System.Drawing.Point(248, 168);
            this.ItemReorderLaveTextBox.Name = "ItemReorderLaveTextBox";
            this.ItemReorderLaveTextBox.Size = new System.Drawing.Size(222, 26);
            this.ItemReorderLaveTextBox.TabIndex = 7;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(248, 129);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(222, 26);
            this.itemNameTextBox.TabIndex = 6;
            // 
            // ItemCompanyNameComboBox
            // 
            this.ItemCompanyNameComboBox.DataSource = this.companyClassBindingSource;
            this.ItemCompanyNameComboBox.DisplayMember = "Name";
            this.ItemCompanyNameComboBox.FormattingEnabled = true;
            this.ItemCompanyNameComboBox.Location = new System.Drawing.Point(248, 41);
            this.ItemCompanyNameComboBox.Name = "ItemCompanyNameComboBox";
            this.ItemCompanyNameComboBox.Size = new System.Drawing.Size(222, 28);
            this.ItemCompanyNameComboBox.TabIndex = 5;
            this.ItemCompanyNameComboBox.ValueMember = "Id";
            // 
            // companyClassBindingSource
            // 
            this.companyClassBindingSource.DataSource = typeof(StockManagementSystem.Module.Company);
            // 
            // ItemCategoryNameComboBox
            // 
            this.ItemCategoryNameComboBox.DataSource = this.categoryClassBindingSource;
            this.ItemCategoryNameComboBox.DisplayMember = "Name";
            this.ItemCategoryNameComboBox.FormattingEnabled = true;
            this.ItemCategoryNameComboBox.Location = new System.Drawing.Point(248, 85);
            this.ItemCategoryNameComboBox.Name = "ItemCategoryNameComboBox";
            this.ItemCategoryNameComboBox.Size = new System.Drawing.Size(222, 28);
            this.ItemCategoryNameComboBox.TabIndex = 4;
            this.ItemCategoryNameComboBox.ValueMember = "Id";
            // 
            // categoryClassBindingSource
            // 
            this.categoryClassBindingSource.DataSource = typeof(StockManagementSystem.Module.Category);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(122, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reorder Level :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(142, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(149, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(150, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category :";
            // 
            // categoryClassBindingSource1
            // 
            this.categoryClassBindingSource1.DataSource = typeof(StockManagementSystem.Module.Category);
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "ItemSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemSetup";
            this.Load += new System.EventHandler(this.ItemSetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemSetupdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClassBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ItemSetupdataGridView;
        private System.Windows.Forms.Button ItemSetupSaveButton;
        private System.Windows.Forms.TextBox ItemReorderLaveTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.ComboBox ItemCompanyNameComboBox;
        private System.Windows.Forms.ComboBox ItemCategoryNameComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource companyClassBindingSource;
        private System.Windows.Forms.BindingSource categoryClassBindingSource;
        private System.Windows.Forms.BindingSource categoryClassBindingSource1;
    }
}