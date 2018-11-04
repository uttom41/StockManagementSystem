using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void categorySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategorySetup CategorySetup = new CategorySetup();
            CategorySetup.Show();
        }

        private void companySetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanySetup companySetup = new CompanySetup();
            companySetup.Show();
        }

        private void itemSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemSetup itemSetup = new ItemSetup();
            itemSetup.Show();
        }

        private void stockInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIn stockin = new StockIn();
            stockin.Show();
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockOut stockout = new StockOut();
            stockout.Show();

        }

        private void searchViewItemsSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchAndViewItemSummary searchandviewitem = new SearchAndViewItemSummary();
            searchandviewitem.Show();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSalesBetweenTwoDates viewSalesBetweenTwoDates = new ViewSalesBetweenTwoDates();
            viewSalesBetweenTwoDates.Show();
        }
    }
}
