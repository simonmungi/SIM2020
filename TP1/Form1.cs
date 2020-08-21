using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Generador generador;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (cmbOpciones.SelectedItem == null)
            {
                MessageBox.Show("No se eligió un metodo");
                return;
            }

            string opc = cmbOpciones.SelectedItem.ToString();

            if (validar(opc))
            {
                //se crea la estrategia con los parámetros pasados por pantalla
                Estrategia est = elegir(opc);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                this.generador = new Generador(cantidad, est);

                List<double> numeros = generador.numeros;

                //lleno la grilla de numeros
                dataGridNumeros.DataSource = numeros.Where(x => x > 0).Select((x, index) => new { Num = index + 1, Resultado = x }).ToList();

                //Calculo max y min
                double[] maxMin = generador.calcularExtremos(numeros);

                txtMax.Text = maxMin[1].ToString();
                txtMin.Text = maxMin[0].ToString();
                txtMedia.Text = generador.calcularMedia().ToString();
                txtVarianza.Text = generador.calcularVarianza().ToString();
                txtIntervalos.Enabled = true;
                button2.Enabled = true;
            }
            else return;

        }


        //////////////////////////validaciones//////////////////////////// despues se pueden mover a otro lado
        //TODO: cambiar validaciones para que acepten decimales y negativos segun txt

        public bool checkSemilla()
        {
            if (String.IsNullOrEmpty(this.txtSemilla.Text))
            {

                MessageBox.Show("No se ingresó una semilla");
                return false;
            }
            else return true;
        }

        public bool checkCantidad()
        {
            if (String.IsNullOrEmpty(this.txtCantidad.Text))
            {

                MessageBox.Show("No se ingresó una cantidad");
                return false;
            }
            else return true;
        }

        public bool checkA()
        {
            if (String.IsNullOrEmpty(this.txtA.Text))
            {

                MessageBox.Show("No se ingresó valor para A");
                return false;
            }
            else return true;
        }

        public bool checkM()
        {
            if (String.IsNullOrEmpty(this.txtM.Text))
            {

                MessageBox.Show("No se ingresó valor para M");
                return false;
            }
            else return true;
        }

        public bool checkC()
        {
            if (String.IsNullOrEmpty(this.txtC.Text))
            {

                MessageBox.Show("No se ingresó valor para C");
                return false;
            }
            else return true;
        }

        public bool validar(string opc)
        {

            switch (opc)
            {
                case "Mixto":
                    return (checkCantidad() && checkSemilla() && checkA() && checkM() && checkC());

                case "Multiplicativo":
                    return (checkCantidad() && checkSemilla() && checkA() && checkM());

                case "Random":
                    return (checkCantidad());

                default:
                    return false;

            }

        }

        public Estrategia elegir(string opc)
        {
            Estrategia est;

            switch (opc)//estrategia
            {
                case "Mixto":


                    est = new EstrategiaCongruencialMixto
                    {
                        x0 = Convert.ToDouble(this.txtSemilla.Text),
                        a = Convert.ToInt64(this.txtA.Text),
                        c = Convert.ToInt64(this.txtC.Text),
                        m = Convert.ToInt64(this.txtM.Text)
                    };

                    return est;

                case "Multiplicativo":
                    est = new EstrategiaCongruencialMultiplicativo
                    {
                        x0 = Convert.ToDouble(this.txtSemilla.Text),
                        a = Convert.ToInt64(this.txtA.Text),
                        m = Convert.ToInt64(this.txtM.Text)
                    };
                    return est;

                case "Random":
                    est = new EstrategiaRandom();
                    return est;

                default:
                    return null;

            }

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtIntervalos_TextChanged(object sender, EventArgs e)
        {
            //actualizar pasos
            if(!String.IsNullOrWhiteSpace(txtIntervalos.Text)){
                double pasos = Math.Round((Convert.ToDouble(txtMax.Text) - Convert.ToDouble(txtMin.Text)) / Convert.ToInt32(txtIntervalos.Text),4);

                this.txtPasos.Text = pasos.ToString();
            }

        }

        private void btnObtenerFrecuencias_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIntervalos.Text) && !String.IsNullOrWhiteSpace(txtPasos.Text))
            {
                btnGraficar.Enabled = true;

                int n = Convert.ToInt32(txtIntervalos.Text);
                List<double[]> interv = new List<double[]>();
                generador.intervalos = interv;

                
                //Primer intervalo
                double[] primero = { Math.Round(Convert.ToDouble(txtMin.Text), 4), Math.Round(Convert.ToDouble(txtMin.Text) + Convert.ToDouble(txtPasos.Text), 4) };
                interv.Add(primero);

                //calculo rangos
                for (int i = 1; i < n; i++)
                {
                    double min = Math.Round(interv.ElementAt(i - 1)[1], 4);
                    double max = Math.Round(min + Convert.ToDouble(txtPasos.Text), 4);
                    double[] fila = { min, max };
                    interv.Add(fila);
                }

                generador.frecuencias = new int[n];
                generador.intervMedio = new double[n];

                //calculo frecuencias
                for (int i = 0; i < Convert.ToInt32(txtCantidad.Text); i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (generador.numeros[i] >= interv[j][0] && generador.numeros[i] <= interv[j][1])
                        {
                            generador.frecuencias[j]++;
                        }
                        //else continue;
                    }
                }

                //calculo intervalos para el grafico
                for (int i = 0; i < n; i++)
                {
                    generador.intervMedio[i] = (interv[i][0] + interv[i][1]) / 2;
                }

                //calculo estadistico de prueba para Chi

                txtEstadistico.Text = Convert.ToString(Math.Round(calcularEstadistico(),4));

                //calculo grados de libertad
                txtGradosLibertad.Text = Convert.ToString(n - 1);

                //lleno las grillas de intervalos y frecuencias
                dataGridIntervalos.DataSource = interv.Where(x => x.Length > 0).Select((x, index) => new { Intervalo = index + 1, Min = x[0], Max = x[1] }).ToList();
                dataGridFrecuencias.DataSource = generador.frecuencias.Where(x => x >= 0).Select((x) => new { Observado = x, Esperado = Convert.ToInt32(txtCantidad.Text) / Convert.ToInt32(txtIntervalos.Text) }).ToList();

            }
            else
            {
                MessageBox.Show("No ingresó un intervalo.");
            }

        }

        private void txtPasos_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIntervalos.Text) && !String.IsNullOrEmpty(txtEstadistico.Text))
            {
                int cant = Convert.ToInt32(txtCantidad.Text);
                int inter = Convert.ToInt32(txtIntervalos.Text);

                Form2 form = new Form2(this.generador, cant, inter);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No calculó frecuencias para el gráfico");
            }

        }

        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private double calcularEstadistico()
        {
            int esperado = Convert.ToInt32(txtCantidad.Text) / Convert.ToInt32(txtIntervalos.Text);
            double acum = 0;
            for (int i = 0; i < Convert.ToInt32(txtIntervalos.Text); i++)
            {
                double num = Math.Pow((esperado - generador.frecuencias[i]), 2);
                acum += (double)num / (double)esperado;
            }
            return acum;
        }
     
       
        private void cmbOpciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbOpciones.SelectedItem.ToString())
            {
                case "Mixto":
                    txtSemilla.Enabled = true;
                    txtA.Enabled = true;
                    txtM.Enabled = true;
                    txtC.Enabled = true;
                    break;

                case "Multiplicativo":
                    txtSemilla.Enabled = true;
                    txtA.Enabled = true;
                    txtM.Enabled = true;
                    txtC.Enabled = false;
                    break;

                case "Random":
                    txtSemilla.Enabled = false;
                    txtA.Enabled = false;
                    txtM.Enabled = false;
                    txtC.Enabled = false;
                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbSignificancia.Text))
            {
                generador.cargarChi();

                int i = Convert.ToInt32(txtGradosLibertad.Text)-1;
                int j = cmbSignificancia.SelectedIndex;

                if(Convert.ToDouble(txtEstadistico.Text) > generador.chi[i, j])
                {
                    string mensaje = "El estadístico de prueba ("+ txtEstadistico.Text + ")" + " es mayor al valor en tabla (" + Convert.ToString(generador.chi[i, j]) + "). La hipótesis nula se rechaza.";
                    MessageBox.Show(mensaje);
                }
                else
                {
                    string mensaje = "El estadístico de prueba (" + txtEstadistico.Text + ")" + " es menor al valor en tabla (" + Convert.ToString(generador.chi[i, j]) + "). La hipótesis nula no se rechaza.";
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                MessageBox.Show("No se eligió un grado de significancía");
            }
        }

        private void cmbSignificancia_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void txtEstadistico_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int64 ultimaSemilla = generador.estrategia.ultimaSemilla;
            double siguiente = generador.estrategia.generarSiguienteSecuencial(ultimaSemilla);

            generador.numeros.Add(Math.Round(siguiente,4));

            dataGridNumeros.DataSource = generador.numeros.Where(x => x > 0).Select((x, index) => new { Num = index + 1, Resultado = x }).ToList();
            dataGridNumeros.CurrentCell = dataGridNumeros.Rows[dataGridNumeros.Rows.Count - 1].Cells[0];

        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
