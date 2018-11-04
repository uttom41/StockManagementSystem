using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Module;

namespace StockManagementSystem.DAL
{
   public class CategoryRepository
   {
       string Constring = @"Server=.; Database=StockManagement;Integrated Security=true;";


       public bool DuplicateCheck(Category category)
       {
           SqlConnection con= new SqlConnection(Constring);
           string quary = @"Select * from Categories Where Name='" + category.Name + "' ";
           SqlCommand cmd=new SqlCommand(quary,con);
           con.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           if (dr.Read())
           {
               return true;
           }

           return false;

       }
        public bool Save(Category category,Company companyClass)
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"INSERT INTO Categories(Name,CompanyId)VALUES('" + category.Name + "', " + companyClass.Id + ")";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int rowAffected = command.ExecuteNonQuery();
            //string query = @"Insert into  CategoryTable (Name,CompanyId,CompanyName) Values('" + _categoryClass.Name + "','" + _categoryClass.CompanyId + "','" + _categoryClass.CompanyName + "')";
            //SqlCommand cmd=new SqlCommand(query,con);
            //con.Open();
            //int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<Category> GetDataGridView()
       {
           SqlConnection con=new SqlConnection(Constring);
           string query = @"SELECT * FROM Categories";
           SqlCommand command = new SqlCommand(query, con);
           con.Open();

           SqlDataAdapter da = new SqlDataAdapter(command);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();


           List<Category> depar = new List<Category>();
           foreach (DataRow a in dt.Rows)
           {
               Category dipstudent = new Category();
               // dipstudent.Id = Convert.ToInt32(a["Id"]);
               dipstudent.Name = a["Name"].ToString();
               //dipstudent.Code = a["Code"].ToString();
               //dipstudent.Address = a["Address"].ToString();
               depar.Add(dipstudent);

           }
           return depar;

       }

       /******************* ComboBox Data Load *************/

        public List<Company> GetDataComboBox()
       {
           SqlConnection con=new SqlConnection(Constring);
           string query = @"SELECT * FROM Companies";
           SqlCommand command = new SqlCommand(query, con);
           con.Open();

           SqlDataAdapter da = new SqlDataAdapter(command);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();


           List<Company> companylist = new List<Company>();
           foreach (DataRow a in dt.Rows)
           {
               Company company = new Company();
               company.Id = Convert.ToInt32(a["Id"]);
               company.Name = a["Name"].ToString();
               // dipstudent.Code = a["Code"].ToString();
               //dipstudent.Address = a["Address"].ToString();
               companylist.Add(company);

           }
           return companylist;
       }

    }
}
