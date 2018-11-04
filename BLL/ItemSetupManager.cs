using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.DAL;
using StockManagementSystem.Module;

namespace StockManagementSystem.BLL
{
   public class ItemSetupManager
    {
        ItemSetupRepository _itemSetupRepository=new ItemSetupRepository();
        public List<Company> GetDataSourceCompany()
        {
            List<Company> companyName = _itemSetupRepository.GetDataSourceCompanyName();
            return companyName;
        }

        public List<Category> GetDataCategoryComboBox()
        {
            List<Category> categories = _itemSetupRepository.GetDataCategoryComboBox();
            return categories;
        }

        public bool Save(Item item, Company company, Category category)
        {
            bool dupCheck = _itemSetupRepository.DuplicateCheck(item);
            if (dupCheck)
            {
                return dupCheck;
            }  
            else
            {
                bool isSave = _itemSetupRepository.Save(item, company, category);
                if (isSave)
                {
                   
                }
            }
            return false;
        }

    }
}
