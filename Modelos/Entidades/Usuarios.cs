using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Usuarios(string NombreUsuario, string password) // que inicializa el nombre y contraseña
        {
            nombreUsuario = NombreUsuario;
            contraseña = password;
        }

        public bool ValidarLogin()
        {
            {
                SqlConnection conexion = ConexionDB.Conectar();
                // Se define la consulta SQL que cuenta cuántos registros existen en la tabla Usuario
                string query = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @usuario AND contraseña = @pass";
                // donde el nombre de usuario y la clave coincidan con los ingresados
                SqlCommand cmd = new SqlCommand(query, conexion);
                // Se ejecuta el comando y se convierte el resultado a un número entero

                cmd.Parameters.AddWithValue("@usuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", Contraseña);
                // Esto devuelve cuántos registros coinciden que seréa 0 o 1
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                // Si el conteo es mayor que 0, significa que hay un usuario válido (o seaq ue tenga la contra y user iguales), por lo tanto devuelve true
                return count > 0;
            }
        }

    }
}
