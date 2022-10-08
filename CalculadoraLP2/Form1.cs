namespace CalculadoraLP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultado;
        double Valor1, Valor2;
private void btnSoma_Click(object sender, EventArgs e)
        {
            Valor1 = Double.Parse(txtBxValor1.Text);
            Valor2 = Double.Parse(txtBxValor2.Text);

            resultado = Valor1 + Valor2;

            txtBxResultado.Text = resultado.ToString();


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Valor1 = Double.Parse(txtBxValor1.Text);
            Valor2 = Double.Parse(txtBxValor2.Text);

            resultado = Valor1 - Valor2;

            txtBxResultado.Text = resultado.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Valor1 = Double.Parse(txtBxValor1.Text);
            Valor2 = Double.Parse(txtBxValor2.Text);

            resultado = Valor1 * Valor2;

            txtBxResultado.Text = resultado.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Valor1 = Double.Parse(txtBxValor1.Text);
            Valor2 = Double.Parse(txtBxValor2.Text);

            resultado = Valor1 / Valor2;

            txtBxResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Valor1 = 0;
            Valor2 = 0;
            resultado = 0;


            txtBxValor1.Text = Valor1.ToString();
            txtBxValor2.Text = Valor2.ToString();
            txtBxResultado.Text = resultado.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBxResultado_TextChanged(object sender, EventArgs e)
        {

            Valor1 = Double.Parse(txtBxValor1.Text);
            Valor2 = Double.Parse(txtBxValor2.Text);

            if (resultado == Valor1 + Valor2)
            {
                txtBxResultado.Text = resultado.ToString();
            }
            if (resultado == Valor1 - Valor2)
            {
                txtBxResultado.Text = resultado.ToString();
            }
            if (resultado == Valor1 * Valor2)
            {
                txtBxResultado.Text = resultado.ToString();
            }
            if (resultado == Valor1 / Valor2)
            {
                if (Valor2 == 0)
                {
                    MessageBox.Show("Não divisivel por zero");
                }
                else
                txtBxResultado.Text = resultado.ToString();
            }
            if (resultado == 0)
            {
                txtBxResultado.Text = resultado.ToString();
            }
        }
    }
}