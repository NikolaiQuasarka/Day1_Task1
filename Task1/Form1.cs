namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(x_textBox.Text, out double x) & Double.TryParse(y_textBox.Text, out double y) &Double.TryParse(z_textBox.Text, out double z)) 
            {
                double f = Math.Abs(Math.Pow(x, y / x) - Math.Pow(y / x, 1 / 3)) + (y - x) * ((Math.Cos(y) - z / (y - x)) / (1 + Math.Pow(y - x, 2)));

                f_textBox.Text = f.ToString();
            }
        }
    }
}
