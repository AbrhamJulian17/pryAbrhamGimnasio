namespace pryAbrhamGimnasio
{
    public partial class frmIn : Form
    {
        public frmIn()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {

        }

        private void estadoinicial()
        {
            txtEdad.Clear();
            txtMeses.Text = "1";
            chkCasillero.Checked = false;


        }


        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)

            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)

            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
