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
    public partial class frmPacientes : Form
    {
        private Pacientes pacientes = new Pacientes();
        private bool isNuevo = true;
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            HabilitarBotones(true);
            LimpiarCampos();
        }
        private void CargarPacientes()
        {
            try
            {
                DataTable dt = Pacientes.CargarPacientes();
                if (dt != null)
                {
                    dgvPacientes.DataSource = dt;
                    dgvPacientes.Columns["idPaciente"].Visible = false;
                    dgvPacientes.Columns["nombrePaciente"].HeaderText = "Nombre del Paciente";
                    dgvPacientes.Columns["Telefono"].HeaderText = "Teléfono";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtNombre.Clear();
            txtTelefono.Clear();
            txtBuscar.Clear();
            isNuevo = true;
            HabilitarBotones(true);
            txtNombre.Focus();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del paciente es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                pacientes.NombrePaciente = txtNombre.Text.Trim();
                pacientes.Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim();

                if (pacientes.InsertarPaciente())
                {
                    MessageBox.Show("Paciente registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("Error al registrar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente para actualizar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["idPaciente"].Value);
                pacientes.NombrePaciente = txtNombre.Text.Trim();
                pacientes.Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim();

                if (pacientes.ActualizarPaciente(idPaciente))
                {
                    MessageBox.Show("Paciente actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un paciente para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("¿Está seguro de eliminar este paciente?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idPaciente = Convert.ToInt32(dgvPacientes.CurrentRow.Cells["idPaciente"].Value);

                    if (pacientes.EliminarPaciente(idPaciente))
                    {
                        MessageBox.Show("Paciente eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarPacientes();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            BuscarPacientes();
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BuscarPacientes();
                e.Handled = true;
            }
        }
        private void BuscarPacientes()
        {
            try
            {
                string termino = txtBuscar.Text.Trim();
                DataTable dt = Pacientes.BuscarPacientes(termino);

                if (dt != null)
                {
                    dgvPacientes.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron pacientes con ese criterio", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPacientes.Rows[e.RowIndex];
                txtNombre.Text = row.Cells["nombrePaciente"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";

                isNuevo = false;
                HabilitarBotones(false);
            }
        }
        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            CargarPacientes();
        }
    }
}
