namespace Vistas.Forms
{
    partial class frmInterfazMedico
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenulateral = new System.Windows.Forms.Panel();
            this.pnlCitas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pnlBotonesInterfaz = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelForms = new System.Windows.Forms.Panel();
            this.pnlFormularios = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenulateral.SuspendLayout();
            this.pnlCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Controls.Add(this.PanelForms);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.pnlMenulateral);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(271, 553);
            this.pnlMenu.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(63, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMenulateral
            // 
            this.pnlMenulateral.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenulateral.Controls.Add(this.pnlCitas);
            this.pnlMenulateral.Location = new System.Drawing.Point(0, 99);
            this.pnlMenulateral.Name = "pnlMenulateral";
            this.pnlMenulateral.Size = new System.Drawing.Size(271, 454);
            this.pnlMenulateral.TabIndex = 54;
            // 
            // pnlCitas
            // 
            this.pnlCitas.Controls.Add(this.label2);
            this.pnlCitas.Controls.Add(this.pbClientes);
            this.pnlCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCitas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCitas.Location = new System.Drawing.Point(0, 0);
            this.pnlCitas.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCitas.Name = "pnlCitas";
            this.pnlCitas.Size = new System.Drawing.Size(271, 51);
            this.pnlCitas.TabIndex = 0;
            this.pnlCitas.Click += new System.EventHandler(this.pnlCitas_Click);
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
            // pnlBotonesInterfaz
            // 
            this.pnlBotonesInterfaz.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotonesInterfaz.Location = new System.Drawing.Point(819, 0);
            this.pnlBotonesInterfaz.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBotonesInterfaz.Name = "pnlBotonesInterfaz";
            this.pnlBotonesInterfaz.Size = new System.Drawing.Size(152, 49);
            this.pnlBotonesInterfaz.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pnlBotonesInterfaz);
            this.panel1.Location = new System.Drawing.Point(274, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 49);
            this.panel1.TabIndex = 53;
            // 
            // PanelForms
            // 
            this.PanelForms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelForms.Location = new System.Drawing.Point(271, 2);
            this.PanelForms.Margin = new System.Windows.Forms.Padding(2);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.Size = new System.Drawing.Size(915, 548);
            this.PanelForms.TabIndex = 51;
            // 
            // pnlFormularios
            // 
            this.pnlFormularios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormularios.Location = new System.Drawing.Point(271, -76);
            this.pnlFormularios.Name = "pnlFormularios";
            this.pnlFormularios.Size = new System.Drawing.Size(917, 629);
            this.pnlFormularios.TabIndex = 54;
            // 
            // frmInterfazMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 553);
            this.Controls.Add(this.pnlFormularios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInterfazMedico";
            this.Text = "frmInterfazAdmin";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenulateral.ResumeLayout(false);
            this.pnlCitas.ResumeLayout(false);
            this.pnlCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenulateral;
        private System.Windows.Forms.Panel pnlCitas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.Panel pnlBotonesInterfaz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelForms;
        private System.Windows.Forms.Panel pnlFormularios;
    }
}