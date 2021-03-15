using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IAupt.uptRNA;

namespace RedesNeuronales
{
    public partial class Form1 : Form
    {
        List<String> colores = new List<string>{"error", "Verde", "Amarillo", "Naranja", "Rojo", "Rosa", "Azul Fuerte", "Azul Claro" };

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            Bitmap color = new Bitmap(pictureBox1.Image);

            textBox1.Text = color.GetPixel(e.X, e.Y).R.ToString();
            textBox2.Text = color.GetPixel(e.X, e.Y).G.ToString();
            textBox3.Text = color.GetPixel(e.X, e.Y).B.ToString();

            textBox3.Text = color.GetPixel(e.X, e.Y).B.ToString();

            PerceptronMultiCapa rna = new PerceptronMultiCapa(@"ejemplo.ppm");

            double[] x = { color.GetPixel(e.X, e.Y).R, color.GetPixel(e.X, e.Y).G, color.GetPixel(e.X, e.Y).B };
            rna.reconocer(x);

            double[,] y = rna.y;

            label4.BackColor = Color.FromArgb(color.GetPixel(e.X, e.Y).R, color.GetPixel(e.X, e.Y).G, color.GetPixel(e.X, e.Y).B);
            label4.Text = colores[(int)Math.Round(y[0, 0], 0)];
}
    }
}
