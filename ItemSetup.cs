using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.BLL;
using StockManagementSystem.Module;

namespace StockManagementSystem
{
    public partial class ItemSetup : Form
    {
        Item _inItemSetupClass =new Item();
        ItemSetupManager _itemSetupManager=new ItemSetupManager();
        Company company =new Company();
        Category category =new Category();
        public ItemSetup()
        {
            InitializeComponent();
        }

        private void ItemSetupSaveButton_Click(object sender, EventArgs e)
        {
            _inItemSetupClass.Name = itemNameTextBox.Text;
            string record = ItemReorderLaveTextBox.Text;
            company.Id = Convert.ToInt32(ItemCompanyNameComboBox.SelectedValue);
            category.Id = Convert.ToInt32(ItemCategoryNameComboBox.SelectedValue);
            EmptyChect(_inItemSetupClass.Name, record);

        }


        public void EmptyChect(string name, string recoder)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(recoder))
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Name is Required!");
                }
                if (string.IsNullOrEmpty(recoder))
                {
                    MessageBox.Show("Name is Required!");
                }

            }
            else
            {
                _inItemSetupClass.Recoder = Convert.ToInt32(recoder);
                bool isSave = _itemSetupManager.Save(_inItemSetupClass, company, category);
                if (isSave)
                {
                    MessageBox.Show("Name is Exist");
                }
                else
                {
                    MessageBox.Show("Save Successfully");
                }
            }

        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            List<Company> company = _itemSetupManager.GetDataSourceCompany();
            companyClassBindingSource.DataSource = company;

            //List<Category> category = _itemSetupManager.GetDataCategoryComboBox();
            //categoryClassBindingSource.DataSource = category;

            List<Item> itemShow = _itemSetupManager.GetDataGridview();
            ItemSetupdataGridView.DataSource = itemShow;


        }

        private void ItemCompanyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            company.Id = Convert.ToInt32(ItemCompanyNameComboBox.SelectedValue);
            //List<Category> category = _itemSetupManager.GetDataCategoryComboBox();
            //categoryClassBindingSource.DataSource = category;
            
            string ConString = @"Server=.; Database=StockManagement;Integrated Security=true;";
            SqlConnection con = new SqlConnection(ConString);
            string query = @"SELECT* From Categories Where CompanyId = '" + company.Id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            categoryClassBindingSource.DataSource = dt;
        }
    }
}
