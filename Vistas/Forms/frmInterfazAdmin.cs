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
using Vistas.Forms.Forms_menu;

namespace Vistas.Forms
{
    public partial class frmInterfazAdmin : Form
    {
        private frmPacientes Pacientes;
        private frmCitas Citas;
        private frmDoctores Doctores;
        private frmEspecialidades Especialidades;

        public frmInterfazAdmin()
        {
            InitializeComponent();
        }

        public void AbrirFormulario(Form formulario)// Método para abrir formularios hijos dentro del panel principal (PanelForms)
        {
            if (!PanelForms.Controls.Contains(formulario))
            {
                // Verifica si el formulario aún no está agregado al panel
                formulario.TopLevel = false; // El formulario no será de nivel superior
                formulario.FormBorderStyle = FormBorderStyle.None; // Se oculta el borde del formulario hijo
                formulario.Dock = DockStyle.Fill; // El formulario se ajusta al tamaño del panel
                pnlFormularios.Controls.Add(formulario); // Se agrega al panel principal
                formulario.Show(); // Se muestra el formulario
            }
            formulario.BringToFront();

        }

        private void btnCerrar_Click(object sender, EventArgs e)//Cierra el programa 
        {
            Environment.Exit(0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)//Minimiza el programa a segundo plano
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenu_Click(object sender, EventArgs e)//Cambia el tamaño de el dashboard
        {
            if (pnlMenu.Width == 60)
            {
                pnlMenu.Width = 240;
            }
            else
            {
                pnlMenu.Width = 60;
            }
        }

        #region

        private void pnlPaciente_Click(object sender, EventArgs e)//abre forms clientes
        {
            if (Pacientes == null || Pacientes.IsDisposed)//Si el formulario Clientes es nulo muestra este formulario
                Pacientes = new frmPacientes(); //envía a Abrir formulario, este formulario
            //cerrar


            AbrirFormulario(Pacientes);

        }

        private void pnlDoctores_Click(object sender, EventArgs e)//abre forms inventario
        {
            if (Doctores == null || Doctores.IsDisposed)//Si el formulario Clientes es nulo muestra este formulario
                Doctores = new frmDoctores(); //envía a Abrir formulario, este formulario
            //cerrar


            AbrirFormulario(Doctores);
        }

        private void pnlCitas_Click(object sender, EventArgs e)//abre forms Empleados
        {
            if (Citas == null || Citas.IsDisposed)//Si el formulario Clientes es nulo muestra este formulario
                Citas = new frmCitas(); //envía a Abrir formulario, este formulario
            //cerrar


            AbrirFormulario(Citas);
        }
        private void pnlEspecialidades_Click(object sender, EventArgs e)
        {
            if (Especialidades == null || Especialidades.IsDisposed)//Si el formulario Clientes es nulo muestra este formulario
                Especialidades = new frmEspecialidades(); //envía a Abrir formulario, este formulario
            //cerrar


            AbrirFormulario(Especialidades);
        }

        #endregion
    }
}
