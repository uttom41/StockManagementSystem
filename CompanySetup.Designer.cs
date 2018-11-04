namespace StockManagementSystem
{
    partial class CompanySetup
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
            this.CompanyNamedataGridView = new System.Windows.Forms.DataGridView();
            this.cno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.companyClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanySavebutton = new System.Windows.Forms.Button();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNamedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.groupBox1.Controls.Add(this.CompanyNamedataGridView);
            this.groupBox1.Controls.Add(this.CompanySavebutton);
            this.groupBox1.Controls.Add(this.companyNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(30, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Setup";
            // 
            // CompanyNamedataGridView
            // 
            this.CompanyNamedataGridView.AllowUserToAddRows = false;
            this.CompanyNamedataGridView.AutoGenerateColumns = false;
            this.CompanyNamedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyNamedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cno,
            this.nameDataGridViewTextBoxColumn,
            this.Delete,
            this.Edite});
            this.CompanyNamedataGridView.DataSource = this.companyClassBindingSource;
            this.CompanyNamedataGridView.Location = new System.Drawing.Point(0, 147);
            this.CompanyNamedataGridView.Name = "CompanyNamedataGridView";
            this.CompanyNamedataGridView.Size = new System.Drawing.Size(444, 203);
            this.CompanyNamedataGridView.TabIndex = 3;
            this.CompanyNamedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyNamedataGridView_CellClick);
            // 
            // cno
            // 
            this.cno.HeaderText = "Sl";
            this.cno.Name = "cno";
            this.cno.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 75;
            // 
            // Edite
            // 
            this.Edite.HeaderText = "Edite";
            this.Edite.Name = "Edite";
            this.Edite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edite.Text = "Edite";
            this.Edite.UseColumnTextForButtonValue = true;
            this.Edite.Width = 75;
            // 
            // companyClassBindingSource
            // 
            this.companyClassBindingSource.DataSource = typeof(StockManagementSystem.Module.Company);
            // 
            // CompanySavebutton
            // 
            this.CompanySavebutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.CompanySavebutton.Location = new System.Drawing.Point(315, 91);
            this.CompanySavebutton.Name = "CompanySavebutton";
            this.CompanySavebutton.Size = new System.Drawing.Size(75, 28);
            this.CompanySavebutton.TabIndex = 2;
            this.CompanySavebutton.Text = "Save";
            this.CompanySavebutton.UseVisualStyleBackColor = true;
            this.CompanySavebutton.Click += new System.EventHandler(this.CompanySavebutton_Click);
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.companyNameTextBox.Location = new System.Drawing.Point(143, 48);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(247, 23);
            this.companyNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name :";
            // 
            // CompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 410);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompanySetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanySetup";
            this.Load += new System.EventHandler(this.CompanySetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyNamedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CompanyNamedataGridView;
        private System.Windows.Forms.Button CompanySavebutton;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource companyClassBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edite;
    }
}