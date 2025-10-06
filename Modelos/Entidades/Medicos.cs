using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public class Medicos
    {
        public int idMedico { get; set; }
        public string Nombre { get; set; }
        public int Dui { get; set; }
        public int Numero { get; set; }
        public int idUsuario { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public DataTable Listar() //Mostrar los Medicos en el dgv
        {
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string sql = "select*from VerDoctores";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void Insertar()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string query = "INSERT INTO Medicos (nombreMedico, fechaNacimiento, numero, dui, idUsuario) " +
                                 "VALUES (@nombre, @fecha, @numero, @dui, @usuario)";
                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
                cmd.Parameters.AddWithValue("@numero", Numero);
                cmd.Parameters.AddWithValue("@dui", Dui);
                cmd.Parameters.AddWithValue("@usuario", idUsuario);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar esta correcta" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Eliminar(int idMedico)
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string query = "DELETE FROM Medicos WHERE idMedico = @idMedico";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idMedico", idMedico);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el medico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void Actualizar()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string query = "UPDATE Medicos SET nombreMedico = @Nombre, fechaNacimiento = @fecha, numero = @numero, dui = @Dui, idUsuario = @idUsuario " +
                               "WHERE idMedico = @idMedico";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idMedico", idMedico);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
                cmd.Parameters.AddWithValue("@numero", Numero);
                cmd.Parameters.AddWithValue("@Dui", Dui);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el medico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable tipoDoctor()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaEstado = "select idMedico, nombreMedico from Medicos\r\n";
            SqlDataAdapter ada = new SqlDataAdapter(consultaEstado, conexion);
            DataTable carcarEstadoTabla = new DataTable();
            ada.Fill(carcarEstadoTabla);
            return carcarEstadoTabla;

        }

    }
}
