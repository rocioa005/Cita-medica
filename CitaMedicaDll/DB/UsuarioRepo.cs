using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CitaMedicaDll.Models;

namespace CitaMedicaDll.DB
{
    public class UsuarioRepo
    {
        private string connectionStr;

        public UsuarioRepo()
        {
            connectionStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString; ;
        }

        public Usuario Login(string userName)
        {
            Usuario user = new Usuario();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString))
                {
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@userName", SqlDbType.VarChar);
                    param[0].Value = userName;

                    SqlCommand cmd = new SqlCommand("dbo.GetUserData", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(param);
                    
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        user.UserName = rdr["UserName"].ToString();
                        user.Password = rdr["Password"].ToString();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return user;
        }
    }
}
