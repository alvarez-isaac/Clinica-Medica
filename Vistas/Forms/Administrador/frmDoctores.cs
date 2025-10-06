using Modelos.Entidades;
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
    public partial class frmDoctores : Form
    {
        public frmDoctores()
        {
            InitializeComponent();
        }

        private void frmDoctores_Load(object sender, EventArgs e)
        {
            Medicos medico = new Medicos();
            dgvMedicos.DataSource = medico.Listar();
            // Ocultar la columna idCita
            dgvMedicos.Columns["idMedico"].Visible = false;
            dtpNacimiento.MaxDate = DateTime.Today;
            txtNombre.MaxLength = 50;
            txtDui.MaxLength = 9;
            txtNumero.MaxLength = 8;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }
            Medicos medicos = new Medicos()
            {
                Nombre = txtNombre.Text,
                Dui = int.Parse(txtDui.Text),
                Numero = int.Parse(txtNumero.Text),
                fechaNacimiento = dtpNacimiento.Value,
                idUsuario = 1 // Asignar un valor predeterminado o obtenerlo de otro lugar
            };

            medicos.Insertar();
            MessageBox.Show("Medico agregado correctamente");
            dgvMedicos.DataSource = medicos.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Medicos med = new Medicos();
            med.idMedico = int.Parse(dgvMedicos.CurrentRow.Cells[0].Value.ToString());
            med.Nombre = txtNombre.Text;
            med.Dui = int.Parse(txtDui.Text);
            med.Numero = int.Parse(txtNumero.Text);
            med.fechaNacimiento = dtpNacimiento.Value;
            med.Actualizar();
            MessageBox.Show("La informacion del Medico ha sido actualizada");
            dgvMedicos.DataSource = med.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDui.Clear();
            txtNumero.Clear();
            txtNombre.Clear();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la tecla
            }
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacio
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtDui.Text)) return false;

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Medicos Eliminar = new Medicos();
            int id = int.Parse(dgvMedicos.CurrentRow.Cells[0].Value.ToString());
            string registroEliminar = dgvMedicos.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro\n" + registroEliminar, "Advertencia eliminaras un Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (Eliminar.Eliminar(id) == true)
                    MessageBox.Show("Registro Eliminados\n" + registroEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMedicos.DataSource = Eliminar.Listar();
            }
        }

        private void dgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvMedicos.Rows[e.RowIndex];
            txtNombre.Text = row.Cells["Nombre del Médico"].Value.ToString();
            txtDui.Text = row.Cells["DUI"].Value.ToString();
            txtNumero.Text = row.Cells["Número Telefónico"].Value.ToString();
        }
    }
}
