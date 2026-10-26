namespace BitLogic_App_Escritorio
{
    partial class fmClienteNuevo
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
            lbtitulo = new Label();
            btnRegistro = new Button();
            btnAtras = new Button();
            lbNombre = new Label();
            lbApellido = new Label();
            lbTelefono = new Label();
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            tbTelefono = new TextBox();
            lbDNI = new Label();
            tbCorreo = new TextBox();
            SuspendLayout();
            // 
            // lbtitulo
            // 
            lbtitulo.AutoSize = true;
            lbtitulo.Location = new Point(364, 78);
            lbtitulo.Name = "lbtitulo";
            lbtitulo.Size = new Size(140, 15);
            lbtitulo.TabIndex = 0;
            lbtitulo.Text = "Registro de nuevo cliente";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(379, 293);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 1;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(97, 309);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 23);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(231, 144);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Location = new Point(231, 195);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(54, 15);
            lbApellido.TabIndex = 4;
            lbApellido.Text = "Apellido:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(242, 252);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(56, 15);
            lbTelefono.TabIndex = 5;
            lbTelefono.Text = "Telefono:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(379, 136);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 6;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(379, 176);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(100, 23);
            tbApellido.TabIndex = 7;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(379, 235);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(100, 23);
            tbTelefono.TabIndex = 8;
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Location = new Point(248, 230);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(46, 15);
            lbDNI.TabIndex = 9;
            lbDNI.Text = "Correo:";
            // 
            // tbCorreo
            // 
            tbCorreo.Location = new Point(379, 222);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(100, 23);
            tbCorreo.TabIndex = 10;
            // 
            // fmClienteNuevo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbCorreo);
            Controls.Add(lbDNI);
            Controls.Add(tbTelefono);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Controls.Add(lbTelefono);
            Controls.Add(lbApellido);
            Controls.Add(lbNombre);
            Controls.Add(btnAtras);
            Controls.Add(btnRegistro);
            Controls.Add(lbtitulo);
            Name = "fmClienteNuevo";
            Text = "fmClienteNuevo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtitulo;
        private Button btnRegistro;
        private Button btnAtras;
        private Label lbNombre;
        private Label lbApellido;
        private Label lbTelefono;
        private TextBox tbNombre;
        private TextBox tbApellido;
        private TextBox tbTelefono;
        private Label lbDNI;
        private TextBox tbCorreo;
    }
}