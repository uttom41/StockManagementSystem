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
        public bool Save(Company _companyClass)
        {
            bool dupCheck = _companyRepository.DuplicateCheck(_companyClass);
            if (dupCheck)
            {
                return dupCheck;

            }
            else
            {
                bool isSave =_companyRepository.Save(_companyClass);
                if (isSave)
                {

                }
                return dupCheck;
                
            }

        }

        public List<Company> GetDataSource()
        {
            List<Company> dt = _companyRepository.GetDataSource();
            return dt;
        }

        public bool DeleteDataSource()
        {
            bool delete = _companyRepository.DeleteDataSource();
            if (delete)
            {
                return true;
            }

            return false;
        }
    }
}
