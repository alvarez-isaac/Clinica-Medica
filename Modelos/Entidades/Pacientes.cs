using Modelos.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaMedica.Models
{
    public class Pacientes
    {
        public int idPaciente;
        private string nombrePaciente;
        private string telefono;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public bool InsertarPaciente()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string consultaQueryInsert = @"
                        INSERT INTO Pacientes (nombrePaciente, Telefono) 
                        VALUES (@nombrePaciente, @telefono)";

                    using (SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion))
                    {
                        insertar.Parameters.AddWithValue("@nombrePaciente", nombrePaciente);
                        insertar.Parameters.AddWithValue("@telefono", telefono ?? (object)DBNull.Value);

                        int filas = insertar.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar paciente: " + ex.Message,
                    "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarPaciente(int id)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string consultaQueryUpdate = @"
                        UPDATE Pacientes 
                        SET nombrePaciente = @nombrePaciente, 
                            Telefono = @telefono 
                        WHERE idPaciente = @id";

                    using (SqlCommand actualizar = new SqlCommand(consultaQueryUpdate, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@nombrePaciente", nombrePaciente);
                        actualizar.Parameters.AddWithValue("@telefono", telefono ?? (object)DBNull.Value);
                        actualizar.Parameters.AddWithValue("@id", id);

                        int filas = actualizar.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar paciente: " + ex.Message,
                    "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarPaciente(int id)
        {
            try
            {
                using (SqlConnection conectar = ConexionDB.Conectar())
                {
                    string consultaDelete = "DELETE FROM Pacientes WHERE idPaciente = @id";

                    using (SqlCommand delete = new SqlCommand(consultaDelete, conectar))
                    {
                        delete.Parameters.AddWithValue("@id", id);
                        int filas = delete.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el paciente: " + ex.Message,
                    "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable CargarPacientes()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB. Conectar())
                {
                    string cadena = "SELECT * FROM Pacientes";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexion))
                    {
                        DataTable tablaCargar = new DataTable();
                        adapter.Fill(tablaCargar);
                        return tablaCargar;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los pacientes: " + ex.Message,
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable BuscarPacientes(string termino)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB. Conectar())
                {
                    string comando = @"
                        SELECT * FROM Pacientes 
                        WHERE nombrePaciente LIKE '%' + @termino + '%' 
                           OR Telefono LIKE '%' + @termino + '%'";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(comando, conexion))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@termino", termino);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pacientes: " + ex.Message,
                    "Error en búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable CargarPacientesParaCombobox()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string cadena = "SELECT idPaciente, nombrePaciente FROM Pacientes ORDER BY nombrePaciente";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        return tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes para combobox: " + ex.Message,
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}