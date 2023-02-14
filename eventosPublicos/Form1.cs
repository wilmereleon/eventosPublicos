namespace eventosPublicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pxNoIngresar.Visible = false;
            pxIngresar.Visible = false;
            pxGratis.Visible = false;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            // Variables

            int edad;
            double pago;

            // Datos de ingreso

            edad = Convert.ToInt16(txtEdad.Text);

            // Evaluar condición de edad

            if (edad <= 16)
            {
                pxNoIngresar.Visible = true;
                pxIngresar.Visible = false;
                pxGratis.Visible = false;
                pago = 0;
            }
            else if(edad > 16 && edad <= 21)
            {
                pxNoIngresar.Visible = false;
                pxIngresar.Visible = false;
                pxGratis.Visible = true;
                pago = 0;
            }
            else
            {
                pxNoIngresar.Visible = false;
                pxIngresar.Visible = true;
                pxGratis.Visible = false;
                pago = 50000;
            
            }

            // Salida
            txtPago.Text = Convert.ToString(pago);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEdad.Clear();
            txtPago.Clear();
            pxNoIngresar.Visible = false;
            pxIngresar.Visible = false;
            pxGratis.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}