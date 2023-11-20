using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace FrontVR
{
    public class AccesoDatos
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=localhost;Initial Catalog=LOGINFORM1;Integrated Security=True");
        
        
        public int Logeo(string usuario, string clave)
        {
            try
            {
                cnn.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnn;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_LOGIN";
                comando.Parameters.AddWithValue("@USUARIO_INGRESADO", usuario);
                comando.Parameters.AddWithValue("@CLAVE_INGRESADA", clave);
                SqlDataReader lector = comando.ExecuteReader();

                if(lector.Read()) 
                {
                    return lector.GetInt32(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }
            return -1;
        }   
    }
}
