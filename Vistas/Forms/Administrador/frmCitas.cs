using ClinicaMedica.Models;
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
    public partial class frmCitas : Form
    {
        public frmCitas()
        {
            InitializeComponent();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            Citas citas = new Citas();
            dgvCitas.DataSource = citas.Listar();
            // Ocultar la columna idCita
            dgvCitas.Columns["idCita"].Visible = false;
            txtMotivo.MaxLength = 100;
            txtObservacion.MaxLength = 500;
            tipoPacientes();
            tipoEspecialidad();
            tipoDoctor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Faltan campos por llenar");
                return;
            }
            Citas citas = new Citas()
            {
                IdEspecialidad = 1, // Asignar un valor predeterminado o obtenerlo de otro lugar
                IdMedico = 1,
                IdPaciente = 1,
                Observaciones = txtObservacion.Text,
                Motivo = txtMotivo.Text,
            };

            citas.Insertar();
            MessageBox.Show("CIta agregado correctamente");
            dgvCitas.DataSource = citas.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Citas med = new Citas();
            med.IdCita = int.Parse(dgvCitas.CurrentRow.Cells[0].Value.ToString());
            med.IdEspecialidad = Convert.ToInt32(cmbEspecialidad.SelectedValue);
            med.IdMedico = Convert.ToInt32(cmbDoctor.SelectedValue);
            med.IdPaciente = Convert.ToInt32(cmbPaciente.SelectedValue);
            med.Motivo = txtMotivo.Text;
            med.Observaciones = txtObservacion.Text;
            med.Actualizar();
            MessageBox.Show("La informacion de la cita ha sido actualizada");
            dgvCitas.DataSource = med.Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtObservacion.Clear();
            txtMotivo.Clear();
            cmbEspecialidad.SelectedIndex = -1;
            cmbPaciente.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
        }

        private void tipoPacientes()
        {
            cmbPaciente.DataSource = null;
            cmbPaciente.DataSource = Pacientes.tipoPacientes();

            cmbPaciente.DisplayMember = "nombrePaciente";
            cmbPaciente.ValueMember = "idPaciente";
            cmbPaciente.SelectedIndex = -1;
        }

        private void tipoEspecialidad()
        {
            cmbEspecialidad.DataSource = null;
            cmbEspecialidad.DataSource = Especialidades.tipoEspecialidad();

            cmbEspecialidad.DisplayMember = "nombreEspecialidad";
            cmbEspecialidad.ValueMember = "idEspecialidad";
            cmbEspecialidad.SelectedIndex = -1;
        }

        private void tipoDoctor()
        {
            cmbDoctor.DataSource = null;
            cmbDoctor.DataSource = Medicos.tipoDoctor();

            cmbDoctor.DisplayMember = "nombreMedico";
            cmbDoctor.ValueMember = "idMedico";
            cmbDoctor.SelectedIndex = -1;
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtObservacion.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtMotivo.Text)) return false;

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Citas Eliminar = new Citas();
            int id = int.Parse(dgvCitas.CurrentRow.Cells[0].Value.ToString());
            string registroEliminar = dgvCitas.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro\n" + registroEliminar, "Advertencia eliminaras un Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                if (Eliminar.Eliminar(id) == true)
                    MessageBox.Show("Registro Eliminados\n" + registroEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCitas.DataSource = Eliminar.Listar();
            }
        }

        private void ddgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvCitas.Rows[e.RowIndex];
            txtMotivo.Text = row.Cells["Motivo de Consulta"].Value.ToString();
            txtObservacion.Text = row.Cells["Observaciones"].Value.ToString();
            cmbDoctor.Text = row.Cells["Nombre del Médico"].Value?.ToString();
            cmbEspecialidad.Text = row.Cells["Especialidad"].Value?.ToString();
            cmbPaciente.Text = row.Cells["Nombre del Paciente"].Value?.ToString();
        }

    }
}
