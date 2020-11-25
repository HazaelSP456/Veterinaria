using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

namespace SistemaDeControl
{
   public class CONEXION
    {
        
           static public SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-IDJCKBS\\MSSQLSERVER01;Initial Catalog=Pboleta;Integrated Security=True");
           static public string CadenaConexion = "Data Source=DESKTOP-IDJCKBS\\MSSQLSERVER01;Initial Catalog=Pboleta;Integrated Security=True";
           public SqlConnection conexioon = new SqlConnection(CadenaConexion);

          public  SqlConnection AbrirConexion()
            {
                if (conexioon.State == System.Data.ConnectionState.Closed)
                conectar.Open();
                return conectar;
            }
          public  SqlConnection CerrarConexion()
            {
                if (conexioon.State == System.Data.ConnectionState.Open)
                    conectar.Close();
                return conectar;
            }
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectarr = new SqlConnection("Data Source=DESKTOP-IDJCKBS\\MSSQLSERVER01;Initial Catalog=Pboleta;Integrated Security=True");
            conectarr.Open();
            return conectarr;
        }
        
    }
}
