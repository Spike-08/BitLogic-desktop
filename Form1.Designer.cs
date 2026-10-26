namespace BitLogic_App_Escritorio
{
    partial class fmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitulo = new Label();
            btnClienteNuevo = new Button();
            btnClienteExistente = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Leelawadee", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(236, 70);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(309, 29);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "¿Qué tipo de cliente eres?";
            // 
            // btnClienteNuevo
            // 
            btnClienteNuevo.Location = new Point(166, 187);
            btnClienteNuevo.Name = "btnClienteNuevo";
            btnClienteNuevo.Size = new Size(172, 88);
            btnClienteNuevo.TabIndex = 1;
            btnClienteNuevo.Text = "Cliente Nuevo";
            btnClienteNuevo.UseVisualStyleBackColor = true;
            btnClienteNuevo.Click += btnClienteNuevo_Click;
            // 
            // btnClienteExistente
            // 
            btnClienteExistente.Location = new Point(443, 187);
            btnClienteExistente.Name = "btnClienteExistente";
            btnClienteExistente.Size = new Size(190, 88);
            btnClienteExistente.TabIndex = 2;
            btnClienteExistente.Text = "Cliente Existente";
            btnClienteExistente.UseVisualStyleBackColor = true;
            btnClienteExistente.Click += btnClienteExistente_Click;
            // 
            // fmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClienteExistente);
            Controls.Add(btnClienteNuevo);
            Controls.Add(lbTitulo);
            Name = "fmPrincipal";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Button btnClienteNuevo;
        private Button btnClienteExistente;
    }
}
