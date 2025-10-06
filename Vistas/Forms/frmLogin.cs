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

namespace Vistas.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Evento que se ejecuta cuando el usuario hace clic en el campo de texto de usuario
        private void txtUsuario_Enter(object sender, EventArgs e) //
        {
            if (txtUsuario.Text == "USUARIO")// Si el campo contiene el texto "USUARIO", lo borra para que el usuario pueda escribir
            {
                txtUsuario.Text = "";
            }
        }
        // Evento que se ejecuta cuando el usuario deja de enfocar el campo de usuario (deja de estar en click)
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Si el campo queda vacío, se vuelve a mostrar el texto "USUARIO"
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        // Evento que se ejecuta cuando el usuario entra al campo de contraseña
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA") // Si el campo queda vacío, se vuelve a mostrar "CONTRASEÑA" y se desactiva el ocultamiento
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        // Evento que se ejecuta cuando el usuario deja de enfocar el campo de contraseña
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")// Si el campo queda vacío, se vuelve a mostrar "CONTRASEÑA" y se desactiva el ocultamiento
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();// Cierra el formulario
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // minimiza el formulario
        }



        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    var user = new Usuarios(txtUsuario.Text, txtContraseña.Text);

                    if (user.ValidarLogin())
                    {
                        // Redirigir según el rol
                        switch (user.IdRol)
                        {
                            case 1: // Administrador
                                new frmInterfazAdmin().Show();
                                break;
                            case 2: // Médico
                                new frmInterfazMedico().Show();
                                break;
                            case 3: // Recepcionista
                                new frmInterfazRecepcionista().Show();
                                break;
                            default:
                                msgError("Rol no válido");
                                return;
                        }
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos");
                        txtContraseña.Clear();
                        txtUsuario.Clear();
                    }
                }
                else msgError("Ingrese contraseña");
            }
            else msgError("Ingrese usuario");
        }
        // Método que muestra un mensaje de error en una etiqueta lblErsor
        private void msgError(string msg)
        {
            lblError.Text = msg;// Asigna el mensaje a la etiqueta (basicamente recive un string por eje ('Ingrese Usuario') y lo muestra en lbl error)
            lblError.Visible = true;
        }
    }
}
