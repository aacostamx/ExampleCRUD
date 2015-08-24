using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCRUD
{
    class Datos
    {
        string cadenaConexion = string.Empty;

        public Datos()
        {
            cadenaConexion = "Data Source=Matrix;Initial Catalog=Ejemplo;User ID=sa;Password=SOPTEC";
        }

        private void InsertaEmpleado(int empleado, string nombre, string departamento)
        {
            using (SqlConnection conexion = new SqlConnection())
            {
                conexion.Open();
                SqlDataAdapter AsistenteSQL = new SqlDataAdapter();
                SqlCommand comando = new SqlCommand();
                SqlParameter[] parametros = new SqlParameter[3];
                parametros[0] = new SqlParameter("@Empleado", SqlDbType.Int);
                parametros[0].Value = empleado;
                parametros[0] = new SqlParameter("@Nombre", SqlDbType.Char);
                parametros[0].Value = nombre;
                parametros[0] = new SqlParameter("@Departamento", SqlDbType.Char);
                parametros[0].Value = departamento;

            }
        }

        private void ActualizaEmpleado()
        {

        }
    }
}
