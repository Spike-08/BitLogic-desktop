namespace BitLogic_App_Escritorio
{
    public partial class fmPrincipal : Form
    {
        public fmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            fmClienteNuevo fcn = new fmClienteNuevo();
            this.Hide();
            fcn.ShowDialog();
            this.Show();
        }

        private void btnClienteExistente_Click(object sender, EventArgs e)
        {
            fmClienteExistente fce = new fmClienteExistente();
            this.Hide();
            fce.ShowDialog();
            this.Show();
        }
    }
}
