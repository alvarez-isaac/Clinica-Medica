using Modelos.Conexion;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicaMedica.Models
{
    public class Especialidades
    {
        public int idEspecialidad;
        private string nombreEspecialidad;

        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
        public string NombreEspecialidad { get => nombreEspecialidad; set => nombreEspecialidad = value; }

        public bool InsertarEspecialidad()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string consultaQueryInsert = @"
                        INSERT INTO Especialidades (nombreEspecialidad) 
                        VALUES (@nombreEspecialidad)";

                    using (SqlCommand insertar = new SqlCommand(consultaQueryInsert, conexion))
                    {
                        insertar.Parameters.AddWithValue("@nombreEspecialidad", nombreEspecialidad);

                        int filas = insertar.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar especialidad: " + ex.Message,
                    "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool ActualizarEspecialidad(int id)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string consultaQueryUpdate = @"
                        UPDATE Especialidades 
                        SET nombreEspecialidad = @nombreEspecialidad 
                        WHERE idEspecialidad = @id";

                    using (SqlCommand actualizar = new SqlCommand(consultaQueryUpdate, conexion))
                    {
                        actualizar.Parameters.AddWithValue("@nombreEspecialidad", nombreEspecialidad);
                        actualizar.Parameters.AddWithValue("@id", id);

                        int filas = actualizar.ExecuteNonQuery();
                        return filas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar especialidad: " + ex.Message,
                    "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarEspecialidad(int id)
        {
            try
            {
                using (SqlConnection conectar = ConexionDB.Conectar())
                {
                    string consultaDelete = "DELETE FROM Especialidades WHERE idEspecialidad = @id";

                    using (SqlCommand delete = new SqlCommand(consultaDelete, conectar))
                    {
                        delete.Parameters.AddWithValue("@id", id);
                        delete.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la especialidad: " + ex.Message,
                    "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable CargarEspecialidades()
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string cadena = "SELECT * FROM Especialidades";

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
                MessageBox.Show("Error al cargar las especialidades: " + ex.Message,
                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable BuscarEspecialidades(string termino)
        {
            try
            {
                using (SqlConnection conexion = ConexionDB.Conectar())
                {
                    string comando = "SELECT * FROM Especialidades WHERE nombreEspecialidad LIKE '%' + @termino + '%'";

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
                MessageBox.Show("Error al buscar especialidades: " + ex.Message,
                    "Error en búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}