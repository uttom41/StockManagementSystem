using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL.CategoryModule;
using StockManagementSystem.Module;

namespace StockManagementSystem
{
    public partial class CategorySetup : Form
    {
        CategoryClass _categoryClass=new CategoryClass();
        CategoryManager _categoryManager =new CategoryManager();
        public CategorySetup()
        {
            InitializeComponent();
        }

        private void CategorySaveButton_Click(object sender, EventArgs e)
        {
            _categoryClass.Name = categoryNameTextBox.Text;
            CheckEmpty(Name);
        }

        public void CheckEmpty(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name Is Required!");
            }
            else
            {
                bool isSave = _categoryManager.Save(_categoryClass);
                if (isSave)
                {
                    MessageBox.Show("Save SuccessFully");
                }
                else
                {
                    MessageBox.Show("Save Unsuccessfully");
                }
            }
        }

        private void CategorySetup_Load(object sender, EventArgs e)
        {

            List<CategoryClass> studentsoutput = _categoryManager.GetDataSource();
            CategoryDataGridView.DataSource = studentsoutput;
            int rowno = 0;
            int cellsnum = 0;
            foreach (DataGridViewRow row in CategoryDataGridView.Rows)
            {
                cellsnum = cellsnum + 1;
                CategoryDataGridView.Rows[rowno].Cells[0].Value = cellsnum;
                rowno = rowno + 1;
            }

        }

        private void CategoryDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //int rowno = 0;
            //int cellsnum = 0;
            //foreach (DataGridViewRow row in CategoryDataGridView.Rows)
            //{
            //    cellsnum = cellsnum + 1;
            //    CategoryDataGridView.Rows[rowno].Cells[0].Value = cellsnum;
            //    rowno = rowno + 1;
            //}
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CategoryClass> studentsoutput = _categoryManager.GetDataSource();
            CategoryDataGridView.DataSource = studentsoutput;
            int rowno = 0;
            int cellsnum = 0;
            foreach (DataGridViewRow row in CategoryDataGridView.Rows)
            {
                cellsnum = cellsnum + 1;
                CategoryDataGridView.Rows[rowno].Cells[0].Value = cellsnum;
                rowno = rowno + 1;
            }
        }


       
    }
}
