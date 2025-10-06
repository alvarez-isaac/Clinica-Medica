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
    public class Citas
    {
        private int idCita;
        private int idPaciente;
        private int idMedico;
        private int idEspecialidad;
        private string motivo;
        private string observaciones;

        public int IdCita { get => idCita; set => idCita = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdMedico { get => idMedico; set => idMedico = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        public DataTable Listar() //Mostrar los Medicos en el dgv
        {
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string sql = "select*from VerCitas";
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
                string query = "INSERT INTO Citas (idPaciente, idMedico, idEspecialidad, motivo, observaciones) " +
                                 "VALUES (@paciente, @medico, @especialidad, @motivo, @obser)";
                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@paciente", idPaciente);
                cmd.Parameters.AddWithValue("@medico", idMedico);
                cmd.Parameters.AddWithValue("@especialidad", idEspecialidad);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@obser", observaciones);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar esta correcta" + ex, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Eliminar(int idCita)
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string query = "DELETE FROM Citas WHERE idCita = @idCita";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idCita", idCita);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void Actualizar()
        {
            try
            {
                SqlConnection conexion = ConexionDB.Conectar();
                string query = "UPDATE Citas SET idPaciente = @paciente, idMedico = @medico, idEspecialidad = @especialidad, motivo = @motivo, observaciones = @obser " +
                               "WHERE idCita = @idCitas";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idCitas", idCita);
                cmd.Parameters.AddWithValue("@paciente", idPaciente);
                cmd.Parameters.AddWithValue("@medico", idMedico);
                cmd.Parameters.AddWithValue("@especialidad", idEspecialidad);
                cmd.Parameters.AddWithValue("@motivo", motivo);
                cmd.Parameters.AddWithValue("@obser", observaciones);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
