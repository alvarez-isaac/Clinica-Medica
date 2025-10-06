namespace Vistas.Forms
{
    partial class frmDashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenulateral = new System.Windows.Forms.Panel();
            this.pnlPacientes = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbInvrentario = new System.Windows.Forms.PictureBox();
            this.pnlMedicos = new System.Windows.Forms.Panel();
            this.lblGestion = new System.Windows.Forms.Label();
            this.pbGestion = new System.Windows.Forms.PictureBox();
            this.pnlCitas = new System.Windows.Forms.Panel();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEspecialidades = new System.Windows.Forms.Panel();
            this.pbVehiculos = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlMenulateral.SuspendLayout();
            this.pnlPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvrentario)).BeginInit();
            this.pnlMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestion)).BeginInit();
            this.pnlCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            this.pnlEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.PanelForms);
            this.pnlMenu.Controls.Add(this.pnlMenulateral);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(271, 555);
            this.pnlMenu.TabIndex = 53;
            // 
            // pnlMenulateral
            // 
            this.pnlMenulateral.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenulateral.Controls.Add(this.pnlEspecialidades);
            this.pnlMenulateral.Controls.Add(this.pnlCitas);
            this.pnlMenulateral.Controls.Add(this.pnlMedicos);
            this.pnlMenulateral.Controls.Add(this.pnlPacientes);
            this.pnlMenulateral.Location = new System.Drawing.Point(0, 138);
            this.pnlMenulateral.Name = "pnlMenulateral";
            this.pnlMenulateral.Size = new System.Drawing.Size(271, 454);
            this.pnlMenulateral.TabIndex = 54;
            // 
            // pnlPacientes
            // 
            this.pnlPacientes.Controls.Add(this.pbInvrentario);
            this.pnlPacientes.Controls.Add(this.label4);
            this.pnlPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPacientes.Location = new System.Drawing.Point(0, 0);
            this.pnlPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPacientes.Name = "pnlPacientes";
            this.pnlPacientes.Size = new System.Drawing.Size(271, 51);
            this.pnlPacientes.TabIndex = 2;
            this.pnlPacientes.Click += new System.EventHandler(this.pnlPaciente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(65, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Pacientes";
            this.label4.Click += new System.EventHandler(this.pnlPaciente_Click);
            // 
            // pbInvrentario
            // 
            this.pbInvrentario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInvrentario.Image = global::Vistas.Properties.Resources.icons8_pacientes_642;
            this.pbInvrentario.Location = new System.Drawing.Point(4, 4);
            this.pbInvrentario.Margin = new System.Windows.Forms.Padding(2);
            this.pbInvrentario.Name = "pbInvrentario";
            this.pbInvrentario.Size = new System.Drawing.Size(44, 41);
            this.pbInvrentario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInvrentario.TabIndex = 43;
            this.pbInvrentario.TabStop = false;
            // 
            // pnlMedicos
            // 
            this.pnlMedicos.Controls.Add(this.pbGestion);
            this.pnlMedicos.Controls.Add(this.lblGestion);
            this.pnlMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMedicos.Location = new System.Drawing.Point(0, 51);
            this.pnlMedicos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMedicos.Name = "pnlMedicos";
            this.pnlMedicos.Size = new System.Drawing.Size(271, 51);
            this.pnlMedicos.TabIndex = 49;
            this.pnlMedicos.Click += new System.EventHandler(this.pnlDoctores_Click);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGestion.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblGestion.Location = new System.Drawing.Point(66, 8);
            this.lblGestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(86, 25);
            this.lblGestion.TabIndex = 48;
            this.lblGestion.Text = "Medicos";
            this.lblGestion.Click += new System.EventHandler(this.pnlDoctores_Click);
            // 
            // pbGestion
            // 
            this.pbGestion.Image = global::Vistas.Properties.Resources.icons8_doctores_641;
            this.pbGestion.Location = new System.Drawing.Point(4, 4);
            this.pbGestion.Margin = new System.Windows.Forms.Padding(2);
            this.pbGestion.Name = "pbGestion";
            this.pbGestion.Size = new System.Drawing.Size(40, 38);
            this.pbGestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGestion.TabIndex = 0;
            this.pbGestion.TabStop = false;
            // 
            // pnlCitas
            // 
            this.pnlCitas.Controls.Add(this.label2);
            this.pnlCitas.Controls.Add(this.pbClientes);
            this.pnlCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCitas.Location = new System.Drawing.Point(0, 102);
            this.pnlCitas.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCitas.Name = "pnlCitas";
            this.pnlCitas.Size = new System.Drawing.Size(271, 51);
            this.pnlCitas.TabIndex = 0;
            this.pnlCitas.Click += new System.EventHandler(this.pnlCitas_Click);
            // 
            // pbClientes
            // 
            this.pbClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClientes.Image = global::Vistas.Properties.Resources.icons8_citas_50;
            this.pbClientes.Location = new System.Drawing.Point(6, 6);
            this.pbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(38, 41);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClientes.TabIndex = 41;
            this.pbClientes.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Citas";
            this.label2.Click += new System.EventHandler(this.pnlCitas_Click);
            // 
            // pnlEspecialidades
            // 
            this.pnlEspecialidades.Controls.Add(this.label3);
            this.pnlEspecialidades.Controls.Add(this.pbVehiculos);
            this.pnlEspecialidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEspecialidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEspecialidades.Location = new System.Drawing.Point(0, 153);
            this.pnlEspecialidades.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEspecialidades.Name = "pnlEspecialidades";
            this.pnlEspecialidades.Size = new System.Drawing.Size(271, 51);
            this.pnlEspecialidades.TabIndex = 1;
            this.pnlEspecialidades.Click += new System.EventHandler(this.pnlEspecialidades_Click);
            // 
            // pbVehiculos
            // 
            this.pbVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVehiculos.Image = global::Vistas.Properties.Resources.icons8_mayores_50;
            this.pbVehiculos.Location = new System.Drawing.Point(6, 6);
            this.pbVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.pbVehiculos.Name = "pbVehiculos";
            this.pbVehiculos.Size = new System.Drawing.Size(38, 41);
            this.pbVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVehiculos.TabIndex = 42;
            this.pbVehiculos.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(65, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Especialidades";
            this.label3.Click += new System.EventHandler(this.pnlEspecialidades_Click);
            // 
            // PanelForms
            // 
            this.PanelForms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelForms.Location = new System.Drawing.Point(271, 5);
            this.PanelForms.Margin = new System.Windows.Forms.Padding(2);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(915, 548);
            this.PanelForms.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(71, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(274, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 553);
            this.panel2.TabIndex = 54;
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.Controls.Add(this.panel2);
            this.pnlFormularios.Controls.Add(this.pnlMenu);
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormularios.Location = new System.Drawing.Point(0, -2);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(1188, 555);
            this.pnlFormularios.TabIndex = 54;
            // 
            // frmDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 553);
            this.Controls.Add(this.pnlFormularios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDashboardAdmin";
            this.Text = "frmInterfazAdmin";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenulateral.ResumeLayout(false);
            this.pnlPacientes.ResumeLayout(false);
            this.pnlPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInvrentario)).EndInit();
            this.pnlMedicos.ResumeLayout(false);
            this.pnlMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestion)).EndInit();
            this.pnlCitas.ResumeLayout(false);
            this.pnlCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            this.pnlEspecialidades.ResumeLayout(false);
            this.pnlEspecialidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlFormularios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelForms;
        private System.Windows.Forms.Panel pnlMenulateral;
        private System.Windows.Forms.Panel pnlEspecialidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbVehiculos;
        private System.Windows.Forms.Panel pnlCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.Panel pnlMedicos;
        private System.Windows.Forms.PictureBox pbGestion;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Panel pnlPacientes;
        private System.Windows.Forms.PictureBox pbInvrentario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFormularios;
    }
}