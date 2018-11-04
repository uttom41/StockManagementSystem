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
   public class CompanyRepository
    {
        string Constring = @"Server=DESKTOP-SDC4J0E; Database=StockManagement;Integrated Security=true;";
     public   bool DuplicateCheck(CompanyClass _companyClass)
        {
            SqlConnection con = new SqlConnection(Constring);
            string quary = @"Select * from CompanyTable Where Name='" + _companyClass.Name + "' ";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }

            return false;
        }

     public bool Save(CompanyClass _companyClass)
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"Insert into  CompanyTable (Name) Values('" + _companyClass.Name + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<CompanyClass> GetDataSource()
        {

            SqlConnection con = new SqlConnection(Constring);
            string query = @"SELECT * FROM CompanyTable";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            List<CompanyClass> company = new List<CompanyClass>();
            foreach (DataRow a in dt.Rows)
            {
                CompanyClass companyc = new CompanyClass();
                // dipstudent.Id = Convert.ToInt32(a["Id"]);
                companyc.Name = a["Name"].ToString();
                //dipstudent.Code = a["Code"].ToString();
                //dipstudent.Address = a["Address"].ToString();
                company.Add(companyc);

            }
            return company;
        }

    }
}
