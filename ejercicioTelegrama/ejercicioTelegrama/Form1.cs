namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;

            if(radioOrdinario.Checked )
            {
                tipoTelegrama = 'o';
            }
            else if(radioUrgente.Checked )
            {
                tipoTelegrama = 'u';
            }
            // telegrama urgente?
         

            // Obtengo el n�mero de palabras que forma el telegrama
            string[] palabras = textoTelegrama.Split(' ');
            numPalabras = palabras.Length;

            // Si el telegrama es ordinario
            if(tipoTelegrama != ' ')
            {
                if (tipoTelegrama == 'o')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 3;
                    }
                    else
                    {
                        coste = 2.5 + 0.5 * (numPalabras - 10); // Calculamos el coste correcto para palabras adicionales
                    }
                }
                else // Si el telegrama es urgente
                {
                    if (numPalabras <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }

                txtPrecio.Text = coste.ToString() + " euros";
            }
            
        }
    }
}
