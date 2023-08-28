using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Windows.Forms;
using ProblemaBanco.Dominio;

namespace ProblemaBanco
{
    internal class AccesoDatos
    {
        SqlCommand cmd;
        SqlConnection conn;
        public AccesoDatos() 
        {
            cmd = new SqlCommand();
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=LAPTOP-3LODEEDE;Initial Catalog=BancoProblemaPrograII;Integrated Security=True";
        }

        private void Conectar()
        {
            
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
        }
        private void Desconectar()
        {
            conn.Close();
        }

        internal DataTable CargarTabla(DataTable t)
        {
            
            Conectar();
            cmd.CommandText = "SP_MOSTRAR_TIPOS";
            t.Load(cmd.ExecuteReader());
            Desconectar();
            return t;
        }

        public int ProximoCodigo()
        {

            Conectar();
            cmd.CommandText = "SP_ULTIMO_NRO_CUENTA";
            SqlParameter param = new SqlParameter ("@next",SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add (param);        
            cmd.ExecuteNonQuery();
            int proximo = Convert.ToInt32(param.Value);
            Desconectar();

            return proximo;
        }

        public int CargarCliente(Cliente c)
        {
            int aux = 0;
            Conectar();
            
            cmd.CommandText = "SP_CARGAR_CLIENTES";
            cmd.Parameters.AddWithValue("@id_cliente",c.id);
            cmd.Parameters.AddWithValue("@nombre",c.nombre);
            cmd.Parameters.AddWithValue("@apellido",c.apellido);
            cmd.Parameters.AddWithValue("@dni",c.dni);
            SqlParameter param = new SqlParameter();
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            aux=Convert.ToInt32(param.Value);
            Desconectar ();
            return aux;
        }





        
    }
}
