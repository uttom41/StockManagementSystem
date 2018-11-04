using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.DAL;
using StockManagementSystem.Module;

namespace StockManagementSystem.BLL
{
   public class CompanyManager
    {
        CompanyRepository _companyRepository=new CompanyRepository();
        public bool Save(CompanyClass _companyClass)
        {
            bool dupCheck = _companyRepository.DuplicateCheck(_companyClass);
            if (dupCheck)
            {
                MessageBox.Show("Name is Exist");

            }
            else
            {
                bool isSave =_companyRepository.Save(_companyClass);
                if (isSave)
                {
                    return true;
                }
            }

            return false;
        }

        public List<CompanyClass> GetDataSource()
        {
            List<CompanyClass> dt = _companyRepository.GetDataSource();
            return dt;
        }

    }
}
