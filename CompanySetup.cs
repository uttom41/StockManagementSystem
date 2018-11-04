using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Module;

namespace StockManagementSystem
{
    public partial class CompanySetup : Form
    {
        Company _companyClass =new Company();
        CompanyManager _companyManager=new CompanyManager();
        public int rowId = 0;
        public CompanySetup()
        {
            InitializeComponent();
        }

        private void CompanySavebutton_Click(object sender, EventArgs e)
        {

            _companyClass.Name = companyNameTextBox.Text;
            EmptyCheck(_companyClass.Name);

            ////Gird View Data Show////

            List<Company> dt = _companyManager.GetDataSource();
            CompanyNamedataGridView.DataSource = dt;
            int rowno = 0;
            int cellsnum = 0;
            foreach (DataGridViewRow row in CompanyNamedataGridView.Rows)
            {
                cellsnum = cellsnum + 1;
                CompanyNamedataGridView.Rows[rowno].Cells[0].Value = cellsnum;
                rowno = rowno + 1;
            }

        }

        public void EmptyCheck(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name Is Required!");
            }
            else
            {
                bool isSave = _companyManager.Save(_companyClass);
                if (isSave)
                {
                    MessageBox.Show("Name Is Already Exists");

                }
                else
                {
                    MessageBox.Show("Save SuccessFully");
                }
            }
        }

        private void CompanySetup_Load(object sender, EventArgs e)
        {
            List<Company> dt = _companyManager.GetDataSource();
            CompanyNamedataGridView.DataSource = dt;
            int rowno = 0;
            int cellsnum = 0;
            foreach (DataGridViewRow row in CompanyNamedataGridView.Rows)
            {
                cellsnum = cellsnum + 1;
                CompanyNamedataGridView.Rows[rowno].Cells[0].Value = cellsnum;
                rowno = rowno + 1;
            }
        }

        

        private void CompanyNamedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //if (CompanyNamedataGridView.Columns[e.ColumnIndex].Name == "Delete")
            //{
            //    if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question) == DialogResult.Yes)
            //        companyClassBindingSource.RemoveCurrent();
            //}

            rowId = e.RowIndex;
            bool delete = _companyManager.DeleteDataSource();
            if (delete)
            {
                MessageBox.Show("Delete Successfully");

            }



        }

        private void CompanyNamedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //rowId = e.RowIndex;
            //bool delete = _companyManager.DeleteDataSource();
            //if (delete)
            //{
            //    MessageBox.Show("Delete Successfully");

            //}
        }
    }
}
