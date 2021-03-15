using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedesNeuronales
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            String rutaArchivo;

            ofdArchivo.Title = "Abrir Archivo de Red Neuronal";
            ofdArchivo.Filter = "Archivo de de Texto|*.ppm";
            ofdArchivo.FileName = "";

            respuesta = ofdArchivo.ShowDialog();

            if(respuesta == DialogResult.OK)
            {
                rutaArchivo = ofdArchivo.FileName;
                MessageBox.Show(rutaArchivo);
                
                Form1 next = new Form1(@rutaArchivo);
                next.Show();
            }
            else
            {
                MessageBox.Show("Cancelaste Arbrir Archivos");
            }
        }
    }
}
