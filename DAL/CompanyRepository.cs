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
        Company _company =new Company();
        string Constring = @"Server=.; Database=StockManagement;Integrated Security=true;";
     public   bool DuplicateCheck(Company company)
        {
            SqlConnection con = new SqlConnection(Constring);
            string quary = @"Select * from Companies Where Name='" + company.Name + "' ";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }

            return false;
        }

     public bool Save(Company company)
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"Insert into  Companies (Name) Values('" + company.Name + "')";
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

        public List<Company> GetDataSource()
        {

            SqlConnection con = new SqlConnection(Constring);
            string query = @"SELECT * FROM Companies";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();


            List<Company> company = new List<Company>();
            foreach (DataRow a in dt.Rows)
            {
                Company companyc = new Company();
                // dipstudent.Id = Convert.ToInt32(a["Id"]);
                companyc.Name = a["Name"].ToString();
                //dipstudent.Code = a["Code"].ToString();
                //dipstudent.Address = a["Address"].ToString();
                company.Add(companyc);

            }
            return company;
        }

        public bool DeleteDataSource()
        {
            SqlConnection con=new SqlConnection(Constring);
            string query = @"DELETE FROM Companies Where Id='" + _company.rowId + "'";
            SqlCommand cmd=new SqlCommand(query,con);
            con.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read())
            {
                return true;
            }
            con.Close();
            return false;
          

        }
    }
}
