using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Conexion
{
    public class ConexionDB
    {
        private static string servidor = "localhost";
        private static string dataBase = "ClinicaMedica";

        public static SqlConnection Conectar()
        {
            try
            {
                string cadena = $"Data source={servidor};Initial Catalog={dataBase};Integrated Security=true;";
                // creando el objeto constructor de la conexion
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
