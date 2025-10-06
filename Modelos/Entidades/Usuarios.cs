using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Usuarios
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contraseña;
        private int idRol;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int IdRol { get => idRol; set => idRol = value; }

        public Usuarios(string NombreUsuario, string password)
        {
            nombreUsuario = NombreUsuario;
            contraseña = password;
        }

        public bool ValidarLogin()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                // Modificamos la consulta para obtener el idRol
                string query = "SELECT idUsuario, idRol FROM Usuarios WHERE nombreUsuario = @usuario AND contraseña = @pass";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", Contraseña);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Guardamos el idRol del usuario
                    this.IdRol = Convert.ToInt32(reader["idRol"]);
                    this.IdUsuario = Convert.ToInt32(reader["idUsuario"]);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar login: " + ex.Message);
                return false;
            }
        }
    }
}