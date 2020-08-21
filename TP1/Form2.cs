using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Generador generador;
        int cantidad;
        int intervalos;
        public Form2(Generador g, int c, int i)
        {
            InitializeComponent();
            this.generador = g;
            this.cantidad = c;
            this.intervalos = i;
            //this.WindowState = FormWindowState.Maximized;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < intervalos; i++)
            {
                double x = Math.Round(generador.intervMedio[i], 2);
                chart1.Series["Observado"].Points.AddXY(x, generador.frecuencias[i]);
                chart1.Series["Esperado"].Points.AddXY(x, cantidad/ intervalos);
            }

        }
    }
}
