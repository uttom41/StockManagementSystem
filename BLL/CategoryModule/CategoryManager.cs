using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.DAL;
using StockManagementSystem.Module;

namespace StockManagementSystem.BLL.CategoryModule
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository=new CategoryRepository();
        public bool Save(Category category,Company company)
        {
            bool dupcheck = _categoryRepository.DuplicateCheck(category);
            if (dupcheck)
            {
                return dupcheck;
            }
            else
            {
                bool isSave = _categoryRepository.Save(category, company);
                if (isSave)
                {

                }
                return dupcheck;
                
            }
          

            
        }

        public List<Category> GetDataGridView()
        {

            List<Category> dt = _categoryRepository.GetDataGridView();
            return dt;

        }

        /******** Company Name Manager Code ********/

        public List<Company> GetDataComboBox()
        {
            List<Company> companyN = _categoryRepository.GetDataComboBox();
            return companyN;
        }

    }
}
