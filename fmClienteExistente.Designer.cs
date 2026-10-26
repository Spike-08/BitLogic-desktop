namespace BitLogic_App_Escritorio
{
    partial class fmClienteExistente
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
            tbBuscaDNI = new TextBox();
            lbTitulo = new Label();
            lbDNI = new Label();
            btnBuscar = new Button();
            btnImprimir = new Button();
            SuspendLayout();
            // 
            // tbBuscaDNI
            // 
            tbBuscaDNI.Location = new Point(275, 123);
            tbBuscaDNI.Name = "tbBuscaDNI";
            tbBuscaDNI.Size = new Size(100, 23);
            tbBuscaDNI.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(414, 70);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(95, 15);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Introduce tu DNI";
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Location = new Point(186, 126);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(30, 15);
            lbDNI.TabIndex = 2;
            lbDNI.Text = "DNI:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(446, 126);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(319, 293);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // fmClienteExistente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprimir);
            Controls.Add(btnBuscar);
            Controls.Add(lbDNI);
            Controls.Add(lbTitulo);
            Controls.Add(tbBuscaDNI);
            Name = "fmClienteExistente";
            Text = "fmClienteExistente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBuscaDNI;
        private Label lbTitulo;
        private Label lbDNI;
        private Button btnBuscar;
        private Button btnImprimir;
    }
}