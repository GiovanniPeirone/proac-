namespace winforms_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(input_n1.Text);
            int n2 = int.Parse(input_n2.Text);

            int resultado = n1 + n2;

            resultado_output.Text = resultado.ToString();

        }

        private void resta_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(input_n1.Text);
            int n2 = int.Parse(input_n2.Text);

            int resultado = n1 - n2;

            resultado_output.Text = resultado.ToString();
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(input_n1.Text);
            int n2 = int.Parse(input_n2.Text);

            int resultado = n1 * n2;

            resultado_output.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float n1 = int.Parse(input_n1.Text);
            float n2 = int.Parse(input_n2.Text);

            float resultado = n1 / n2;

            resultado_output.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado_output.Text = string.Empty;
            input_n1.Text = string.Empty;
            input_n2.Text = string.Empty;
        }
    }
}
