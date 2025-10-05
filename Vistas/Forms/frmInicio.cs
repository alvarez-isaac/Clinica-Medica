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
    public partial class frmInicio : Form
    {
        public frmInicio()
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
            if (txtUsuario.Text != "USUARIO")// Verifica que el campo de usuario no tenga el texto por defecto (o sea que el usuario no haya escrito ususario)
            {
                if (txtContraseña.Text != "CONTRASEÑA")// Verifica que el campo de contraseña no tenga el texto por defecto (o sea que el usuario no haya escrito contraseña)
                {
                    var user = new Usuarios(txtUsuario.Text, txtContraseña.Text);// Crea un nuevo objeto Usuario con los datos ingresados

                    if (user.ValidarLogin())// Valida si kos datos son correctos 
                    {


                        new frmInterfazAdmin().Show();//si lo es muestra la interfaz admin y cierra esta


                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrectos");//si no lo es muestra mensaje de error y limpia los campos
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
