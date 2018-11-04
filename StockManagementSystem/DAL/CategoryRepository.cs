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
       private string Constring = @"Server=DESKTOP-SDC4J0E; Database=StockManagement;Integrated Security=true;";


       public bool DuplicateCheck(CategoryClass _categoryClass)
       {
           SqlConnection con= new SqlConnection(Constring);
           string quary = @"Select * from CategoryTable Where Name='" + _categoryClass.Name + "' ";
           SqlCommand cmd=new SqlCommand(quary,con);
           con.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           if (dr.Read())
           {
               return false;
           }

           return true;

       }
        public bool Save(CategoryClass _categoryClass)
        {
            SqlConnection con = new SqlConnection(Constring);
            string query = @"Insert into  CategoryTable (Name) Values('"+_categoryClass.Name+"')";
            SqlCommand cmd=new SqlCommand(query,con);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();
            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public List<CategoryClass> GetDataScource()
       {
           SqlConnection con=new SqlConnection(Constring);
           string query = @"SELECT * FROM CategoryTable";
           SqlCommand command = new SqlCommand(query, con);
           con.Open();

           SqlDataAdapter da = new SqlDataAdapter(command);
           DataTable dt = new DataTable();
           da.Fill(dt);
           con.Close();


           List<CategoryClass> depar = new List<CategoryClass>();
           foreach (DataRow a in dt.Rows)
           {
               CategoryClass dipstudent = new CategoryClass();
               // dipstudent.Id = Convert.ToInt32(a["Id"]);
               dipstudent.Name = a["Name"].ToString();
               //dipstudent.Code = a["Code"].ToString();
               //dipstudent.Address = a["Address"].ToString();
               depar.Add(dipstudent);

           }
           return depar;

       }

    }
}
