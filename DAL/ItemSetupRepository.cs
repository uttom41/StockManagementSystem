using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Module;

namespace StockManagementSystem.DAL
{
  public  class ItemSetupRepository
  {
      private string ConString = @"Server=DESKTOP-SDC4J0E; Database=StockManagement;Integrated Security=true;";
        public List<Company> GetDataSourceCompanyName()
        {
            SqlConnection con=new SqlConnection(ConString);
            string query = @"Select * From Companies";
            SqlCommand cmd=new SqlCommand(query,con);
            con.Open();
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            da.Fill(dt);
            con.Close();

            List<Company> companyList = new List<Company>();
            foreach (DataRow a in dt.Rows)
            {
                Company companyName = new Company();
                companyName.Id = Convert.ToInt32(a["Id"]);
                companyName.Name = a["Name"].ToString();
                companyList.Add(companyName);
            }

            return companyList;
        }

      public List<Category> GetDataCategoryComboBox()
      {
          SqlConnection con=new SqlConnection(ConString);
          string query = @"SELECT * From Categories";
          SqlCommand cmd=new SqlCommand(query,con);
          con.Open();
          SqlDataAdapter da=new SqlDataAdapter(cmd);
          DataTable dt=new DataTable();
          da.Fill(dt);
          con.Close();
          List<Category> categories=new List<Category>();
          foreach (DataRow ca in dt.Rows)
          {
              Category category=new Category();
              category.Id = Convert.ToInt32(ca["Id"]);
              category.Name = ca["Name"].ToString();
              categories.Add(category);

          }

          return categories;

      }

    }
}
