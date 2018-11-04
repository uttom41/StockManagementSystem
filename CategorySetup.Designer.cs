namespace StockManagementSystem
{
    partial class CategorySetup
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategorySaveButton = new System.Windows.Forms.Button();
            this.CategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.companyIdComboBox = new System.Windows.Forms.ComboBox();
            this.companyClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.companyClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClassBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Setup :";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTextBox.Location = new System.Drawing.Point(153, 101);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(205, 23);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // CategorySaveButton
            // 
            this.CategorySaveButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySaveButton.Location = new System.Drawing.Point(283, 139);
            this.CategorySaveButton.Name = "CategorySaveButton";
            this.CategorySaveButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.CategorySaveButton.Size = new System.Drawing.Size(75, 26);
            this.CategorySaveButton.TabIndex = 2;
            this.CategorySaveButton.Text = "Save";
            this.CategorySaveButton.UseVisualStyleBackColor = true;
            this.CategorySaveButton.Click += new System.EventHandler(this.CategorySaveButton_Click);
            // 
            // CategoryDataGridView
            // 
            this.CategoryDataGridView.AutoGenerateColumns = false;
            this.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.nameDataGridViewTextBoxColumn,
            this.companyIdDataGridViewTextBoxColumn});
            this.CategoryDataGridView.DataSource = this.categoryClassBindingSource1;
            this.CategoryDataGridView.Location = new System.Drawing.Point(30, 206);
            this.CategoryDataGridView.Name = "CategoryDataGridView";
            this.CategoryDataGridView.Size = new System.Drawing.Size(328, 131);
            this.CategoryDataGridView.TabIndex = 3;
            this.CategoryDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.CategoryDataGridView_RowPostPaint);
            // 
            // sno
            // 
            this.sno.HeaderText = "Sl";
            this.sno.Name = "sno";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // companyIdDataGridViewTextBoxColumn
            // 
            this.companyIdDataGridViewTextBoxColumn.DataPropertyName = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.HeaderText = "CompanyId";
            this.companyIdDataGridViewTextBoxColumn.Name = "companyIdDataGridViewTextBoxColumn";
            this.companyIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryClassBindingSource1
            // 
            this.categoryClassBindingSource1.DataSource = typeof(StockManagementSystem.Module.Category);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.companyIdComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CategoryDataGridView);
            this.groupBox1.Controls.Add(this.CategorySaveButton);
            this.groupBox1.Controls.Add(this.categoryNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 352);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Setup";
            // 
            // companyIdComboBox
            // 
            this.companyIdComboBox.DataSource = this.companyClassBindingSource1;
            this.companyIdComboBox.DisplayMember = "Name";
            this.companyIdComboBox.FormattingEnabled = true;
            this.companyIdComboBox.Location = new System.Drawing.Point(153, 58);
            this.companyIdComboBox.Name = "companyIdComboBox";
            this.companyIdComboBox.Size = new System.Drawing.Size(205, 27);
            this.companyIdComboBox.TabIndex = 6;
            this.companyIdComboBox.ValueMember = "Id";
            // 
            // companyClassBindingSource1
            // 
            this.companyClassBindingSource1.DataSource = typeof(StockManagementSystem.Module.Company);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Company Name :";
            // 
            // companyClassBindingSource
            // 
            this.companyClassBindingSource.DataSource = typeof(StockManagementSystem.Module.Company);
            // 
            // CategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(424, 376);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategorySetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategorySetup";
            this.Load += new System.EventHandler(this.CategorySetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryClassBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button CategorySaveButton;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource categoryClassBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companyIdComboBox;
        private System.Windows.Forms.BindingSource companyClassBindingSource;
        private System.Windows.Forms.BindingSource companyClassBindingSource1;
    }
}