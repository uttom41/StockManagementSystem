﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            _inItemSetupClass.Recoder = ItemReorderLaveTextBox.Text;
            company.Id = Convert.ToInt32(ItemCompanyNameComboBox.SelectedValue);
            category.Id = Convert.ToInt32(ItemCategoryNameComboBox.SelectedValue);
            EmptyChect(_inItemSetupClass.Name, _inItemSetupClass.Recoder);

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
                bool isSave = _itemSetupManager.Save(_inItemSetupClass, category, company);
            }

        }

        private void ItemSetup_Load(object sender, EventArgs e)
        {
            List<Company> company = _itemSetupManager.GetDataSourceCompany();
            companyClassBindingSource.DataSource = company;

            List<Category> category = _itemSetupManager.GetDataCategoryComboBox();
            categoryClassBindingSource.DataSource = category;



        }
    }
}
