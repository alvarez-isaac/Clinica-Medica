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

namespace Vistas.Forms.Administrador
{
    public partial class frmRegistrarUsuarios : UserControl
    {
        public frmRegistrarUsuarios()
        {
            InitializeComponent();
        }

        private void frmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            cargarRoles();
        }

        private void cargarRoles()
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.DataSource=Usuarios.cargarRoles();
            cmbUsuario.DisplayMember = "rol";
            cmbUsuario.ValueMember = "idRol";
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.NombreUsuario = txtNombre.Text;
            user.Contraseña = txtClave.Text;
            user.Correo = txtCorreo.Text;
            user.IdRol = Convert.ToInt32(cmbUsuario.SelectedValue);
            if (user.RegistrarUsuario())
            {
                MessageBox.Show("Usuario creado con exito");
                txtNombre.Text = "";
                txtClave.Text = "";
                txtCorreo.Text = "";
                cmbUsuario.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error al crear el usuario");
            }
        }
    }
}
