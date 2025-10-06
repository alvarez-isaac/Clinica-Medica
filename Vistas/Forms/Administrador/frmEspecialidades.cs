using ClinicaMedica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Forms.Forms_menu
{
    public partial class frmEspecialidades : Form
    {
        private Especialidades especialidad = new Especialidades();
        private bool isNuevo = true;

        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void FormEspecialidades_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            HabilitarBotones(true);
            LimpiarCampos();
        }

        private void CargarEspecialidades()
        {
            try
            {
                DataTable dt = Especialidades.CargarEspecialidades();
                if (dt != null)
                {
                    dgvEspecialidades.DataSource = dt;
                    dgvEspecialidades.Columns["idEspecialidad"].Visible = false;
                    dgvEspecialidades.Columns["nombreEspecialidad"].HeaderText = "Nombre de la Especialidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especialidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarBotones(bool nuevo)
        {
            btnAgregar.Enabled = nuevo;
            btnActualizar.Enabled = !nuevo;
            btnCancelar.Enabled = !nuevo;
            btnEliminar.Enabled = !nuevo;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            isNuevo = true;
            HabilitarBotones(true);
            txtNombre.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la especialidad es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                especialidad.NombreEspecialidad = txtNombre.Text.Trim();

                if (especialidad.InsertarEspecialidad())
                {
                    MessageBox.Show("Especialidad registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarEspecialidades();
                }
                else
                {
                    MessageBox.Show("Error al registrar la especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (dgvEspecialidades.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una especialidad para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idEspecialidad = Convert.ToInt32(dgvEspecialidades.CurrentRow.Cells["idEspecialidad"].Value);
                especialidad.NombreEspecialidad = txtNombre.Text.Trim();

                if (especialidad.ActualizarEspecialidad(idEspecialidad))
                {
                    MessageBox.Show("Especialidad actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarEspecialidades();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEspecialidades.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una especialidad para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("¿Está seguro de eliminar esta especialidad?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idEspecialidad = Convert.ToInt32(dgvEspecialidades.CurrentRow.Cells["idEspecialidad"].Value);

                    if (especialidad.EliminarEspecialidad(idEspecialidad))
                    {
                        MessageBox.Show("Especialidad eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarEspecialidades();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la especialidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEspecialidades();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarEspecialidades();
                e.Handled = true;
            }
        }

        private void BuscarEspecialidades()
        {
            try
            {
                string termino = txtBuscar.Text.Trim();
                DataTable dt = Especialidades.BuscarEspecialidades(termino);

                if (dt != null)
                {
                    dgvEspecialidades.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron especialidades con ese criterio", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar especialidades: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEspecialidades.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["nombreEspecialidad"].Value.ToString();

                isNuevo = false;
                HabilitarBotones(false);
            }
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
            HabilitarBotones(true);
            LimpiarCampos();
        }
    }
}