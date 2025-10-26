
namespace Practica1.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1_Click.Text = "Estado: Conectado a .NET 8";
            label1_Click.ForeColor = System.Drawing.Color.Green;

        }
    }
}