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
        Category _category = new Category();
        CategoryManager _categoryManager =new CategoryManager();
        Company _company =new Company();
        public CategorySetup()
        {
            InitializeComponent();
        }

        private void CategorySaveButton_Click(object sender, EventArgs e)
        {
           // _categoryClass.CompanyName = companyIdComboBox.Text;
            _company.Id = Convert.ToInt32(companyIdComboBox.SelectedValue);
            _category.Name = categoryNameTextBox.Text;
            CheckEmpty(Name);



            // Grid View Data Showing//

            List<Category> studentsoutput = _categoryManager.GetDataGridView();
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

        public void CheckEmpty(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name Is Required!");
            }
            else
            {
                bool isSave = _categoryManager.Save(_category, _company);
                if (isSave)
                {
                    MessageBox.Show("Name Already Exist");
                }
                else
                {
                    MessageBox.Show("Save Successfully");
                }
            }


           
        }

        private void CategorySetup_Load(object sender, EventArgs e)
        {

            List<Category> studentsoutput = _categoryManager.GetDataGridView();
            CategoryDataGridView.DataSource = studentsoutput;
            int rowno = 0;
            int cellsnum = 0;
            foreach (DataGridViewRow row in CategoryDataGridView.Rows)
            {
                cellsnum = cellsnum + 1;
                CategoryDataGridView.Rows[rowno].Cells[0].Value = cellsnum;
                rowno = rowno + 1;
            }

            /*  Company name upload   **********************************/

            List<Company> companyN = _categoryManager.GetDataComboBox();
            companyClassBindingSource1.DataSource = companyN;

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

       /* private void button1_Click(object sender, EventArgs e)
        {
            List<Category> studentsoutput = _categoryManager.GetDataGridView();
            CategoryDataGridView.DataSource = studentsoutput;
            int rowno = 0;
            int cellsnum = 0;
            foreach (DataGridViewRow row in CategoryDataGridView.Rows)
            {
                cellsnum = cellsnum + 1;
                CategoryDataGridView.Rows[rowno].Cells[0].Value = cellsnum;
                rowno = rowno + 1;
            }
        }*/


       
    }
}
