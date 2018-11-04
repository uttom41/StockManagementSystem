namespace StockManagementSystem
{
    partial class ViewSalesBetweenTwoDates
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
            this.ViewSalesDatedataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewSalesFromDatesSearchButton = new System.Windows.Forms.Button();
            this.ViewSalesToDateComboBox = new System.Windows.Forms.ComboBox();
            this.ViewSalesFromDateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSalesDatedataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.groupBox1.Controls.Add(this.ViewSalesDatedataGridView1);
            this.groupBox1.Controls.Add(this.ViewSalesFromDatesSearchButton);
            this.groupBox1.Controls.Add(this.ViewSalesToDateComboBox);
            this.groupBox1.Controls.Add(this.ViewSalesFromDateComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Sales Between Two Dates";
            // 
            // ViewSalesDatedataGridView1
            // 
            this.ViewSalesDatedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSalesDatedataGridView1.Location = new System.Drawing.Point(23, 169);
            this.ViewSalesDatedataGridView1.Name = "ViewSalesDatedataGridView1";
            this.ViewSalesDatedataGridView1.Size = new System.Drawing.Size(715, 262);
            this.ViewSalesDatedataGridView1.TabIndex = 5;
            // 
            // ViewSalesFromDatesSearchButton
            // 
            this.ViewSalesFromDatesSearchButton.Location = new System.Drawing.Point(499, 126);
            this.ViewSalesFromDatesSearchButton.Name = "ViewSalesFromDatesSearchButton";
            this.ViewSalesFromDatesSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ViewSalesFromDatesSearchButton.TabIndex = 4;
            this.ViewSalesFromDatesSearchButton.Text = "Search";
            this.ViewSalesFromDatesSearchButton.UseVisualStyleBackColor = true;
            // 
            // ViewSalesToDateComboBox
            // 
            this.ViewSalesToDateComboBox.FormattingEnabled = true;
            this.ViewSalesToDateComboBox.Location = new System.Drawing.Point(316, 79);
            this.ViewSalesToDateComboBox.Name = "ViewSalesToDateComboBox";
            this.ViewSalesToDateComboBox.Size = new System.Drawing.Size(258, 24);
            this.ViewSalesToDateComboBox.TabIndex = 3;
            // 
            // ViewSalesFromDateComboBox
            // 
            this.ViewSalesFromDateComboBox.FormattingEnabled = true;
            this.ViewSalesFromDateComboBox.Location = new System.Drawing.Point(316, 35);
            this.ViewSalesFromDateComboBox.Name = "ViewSalesFromDateComboBox";
            this.ViewSalesFromDateComboBox.Size = new System.Drawing.Size(258, 24);
            this.ViewSalesFromDateComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date :";
            // 
            // ViewSalesBetweenTwoDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 472);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewSalesBetweenTwoDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSalesBetweenTwoDates";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSalesDatedataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ViewSalesDatedataGridView1;
        private System.Windows.Forms.Button ViewSalesFromDatesSearchButton;
        private System.Windows.Forms.ComboBox ViewSalesToDateComboBox;
        private System.Windows.Forms.ComboBox ViewSalesFromDateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}