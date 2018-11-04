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
        public bool Save(CategoryClass _categoryClass)
        {
            bool dupcheck = _categoryRepository.DuplicateCheck(_categoryClass);
            if (dupcheck)
            {
                bool isSave = _categoryRepository.Save(_categoryClass);
                if (isSave)
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Name Is Exist");
            }
          

            return false;
        }

        public List<CategoryClass> GetDataSource()
        {

            List<CategoryClass> dt = _categoryRepository.GetDataScource();
            return dt;

        }

    }
}
