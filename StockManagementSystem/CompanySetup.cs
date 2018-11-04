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
        CompanyClass _companyClass =new CompanyClass();
        CompanyManager _companyManager=new CompanyManager();
        public CompanySetup()
        {
            InitializeComponent();
        }

        private void CompanySavebutton_Click(object sender, EventArgs e)
        {

            _companyClass.Name = companyNameTextBox.Text;
            EmptyCheck(_companyClass.Name);

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
                    MessageBox.Show("Save Successfully");

                }
                else
                {
                    MessageBox.Show("Save UnsuccessFully");
                }
            }
        }

        private void CompanySetup_Load(object sender, EventArgs e)
        {
            List<CompanyClass> dt = _companyManager.GetDataSource();
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<CompanyClass> dt = _companyManager.GetDataSource();
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
    }
}
