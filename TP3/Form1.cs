﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;
using System.IO;
using System.Windows.Forms.VisualStyles;
using TP2_NetFramework.Distribuciones;
using TP3.Distribuciones;

namespace TP2_NetFramework
{
    public partial class Form1 : Form
    {
        Gestor gestor;

        public Form1()
        {
            InitializeComponent();
            //inicio el gestor
            this.gestor = new Gestor();
        }

        //Calcular frecuencias e intervalos
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIntervalos.Text))
            {
                double pasos = Math.Round((Convert.ToDouble(txtMax.Text) - Convert.ToDouble(txtMin.Text)) / Convert.ToInt32(txtIntervalos.Text), 4);
                
                this.txtPasos.Text = pasos.ToString();

                gestor.cantIntervalos = Convert.ToInt32(txtIntervalos.Text);

                gestor.obtenerFrecuencias(Convert.ToDouble(txtPasos.Text));
                
                llenarGrillaFrecuencias();

                graficarHistograma();

                actualizarFrecuenciasEsperadas();

                graficarHistogramaEsperado();
                
            }
            else
            {
                MessageBox.Show("No ingresó un intervalo.");
            }
        }

        public IEstrategia elegirEstrategia(string opc)
        {
            IEstrategia est;

            switch (opc)
            {

                case "Uniforme":
                    return new EstrategiaContinuaUniforme();

                case "Normal":
                    return new EstrategiaContinuaNormal();

                case "Exponencial":
                    return new EstrategiaContinuaExponencial();

                case "Poisson":
                    return new EstrategiaPoisson();
                
                default:
                    return null;
            }
        }

        public void actualizarFrecuenciasEsperadas()
        {
            //se actualiza la tabla de frecuencias esperadas según la distribucion
            gestor.estrategiaDistribucion.obtenerEsperados(gestor);

            //calculo estadísticos
            gestor.calcularEstadisticoChi();
            gestor.calcularEstadisticoKS();

            //actualizo la grilla
            for (int i = 0; i < gestor.cantIntervalos; i++)
            {
                dataGridFrecuencias.Rows[i].Cells["Esperados"].Value = Math.Round(gestor.frecuenciasEsperadas[i], 4);
                dataGridFrecuencias.Rows[i].Cells["ProbEsp"].Value = Math.Round(gestor.probEsperadas[i], 4);
                dataGridFrecuencias.Rows[i].Cells["AcumEsperado"].Value = Math.Round(gestor.acumProbEsperada[i], 4);
            }

        }
        private void cmbDistribuciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIntervalos.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtSigma.Text = "";
            txtMu.Text = "";
            txtLambda.Text = "";
            limpiarTest();
            habilitarParametros(cmbDistribuciones.Text);
        }

        private void limpiarTest()
        {
            cmbPrueba.SelectedIndex = -1;
            txtEstadistico.Text = "";
            txtGradosLibertad.Text = "";
            cmbSignificancia.SelectedIndex = -1;
            chart1.Series.Clear();
            dataGridView1.DataSource = null;
            dataGridFrecuencias.Rows.Clear();
            txtPasos.Text = "";
            txtVarianza.Text = "";
            txtMedia.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
        }

        //Boton generar
        private void button2_Click(object sender, EventArgs e)
        {
            txtIntervalos.Text = "";

            if (!String.IsNullOrEmpty(cmbDistribuciones.Text))
            {

                if (validarParametrosVacios() && !String.IsNullOrEmpty(txtCantidad.Text))
                {
                    string estrategia = cmbDistribuciones.SelectedItem.ToString();
                    //elijo la estrategia
                    gestor.estrategiaDistribucion = elegirEstrategia(estrategia);

                    //genero los datos
                    gestor.generarDatos(Convert.ToInt32(txtCantidad.Text));

                    //Cargo pantalla con datos
                    txtMax.Text = gestor.max.ToString();
                    txtMin.Text = gestor.min.ToString("F99").TrimEnd('0');
                    txtMedia.Text = Math.Round(gestor.media, 4).ToString();
                    txtVarianza.Text = Math.Round(gestor.varianza, 4).ToString();
                    txtIntervalos.Enabled = true;

                    //los cargo en la grilla
                    dataGridView1.DataSource = gestor.muestras.Select((x, index) => new { Num = index + 1, Resultado = Math.Round(x, 4) }).ToList();

                    cmbPrueba.Enabled = true;
                    cmbPrueba.SelectedIndex = -1;
                    txtGradosLibertad.Text = "";
                }
                else
                {
                    MessageBox.Show("No cargó alguno de los parámetros");
                }
            }
            else
            {
                MessageBox.Show("No seleccionó una distribucion.");
            }
        }


        //*********************************************************  Graficar  *********************************************************//

        private void graficarHistograma()
        {
            chart1.Series.Clear();
            chart1.Series.Add("Observado");
            for (int i = 0; i < gestor.cantIntervalos; i++)
            {
                string x = gestor.intervMedio[i];
                chart1.Series["Observado"].Points.AddXY(x, gestor.frecuenciasObservadas[i]);
            }

        }

        private void graficarHistogramaEsperado()
        {
            chart1.Series.Add("Esperado");
            for (int i = 0; i < gestor.cantIntervalos; i++)
            {
                chart1.Series["Esperado"].Points.Add(gestor.frecuenciasEsperadas[i]);
            }
        }

        //Muy lento
        public void llenarGrillaMuestras()
        {
            for (int i = 0; i < gestor.n; i++)
            {
                dataGridView1.Rows.Add(i + 1, gestor.muestras[i]);
            }
        }

        public void llenarGrillaFrecuencias()
        {
            dataGridFrecuencias.Rows.Clear();

            for (int i = 0; i < gestor.cantIntervalos; i++)
            {
                dataGridFrecuencias.Rows.Add(i + 1, gestor.intervalos[i][0], gestor.intervalos[i][1], gestor.frecuenciasObservadas[i], Math.Round(gestor.probObservadas[i],4),Math.Round(gestor.acumProbObservada[i], 4), Math.Round(gestor.frecuenciasEsperadas[i],4), Math.Round(gestor.probEsperadas[i],4), Math.Round(gestor.acumProbEsperada[i],4));
            }
        }

        //*********************************************************  Pruebas de chi y ks  *********************************************************//
        //cargo valores a los combobox dependiendo la prueba
        private void cmbPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            gestor.cargarKS();
            cmbSignificancia.SelectedIndex = -1;
            cmbSignificancia.Enabled = true;
            
            if (cmbPrueba.SelectedItem == null)
            {
                cmbSignificancia.SelectedIndex = -1;
                txtEstadistico.Text = "";
            }
            else if (cmbPrueba.SelectedItem != null && cmbPrueba.SelectedItem.ToString() == "Chi cuadrado")
            {
                cmbSignificancia.Items.Clear();
                cmbSignificancia.Items.Insert(0, "0,005");
                cmbSignificancia.Items.Insert(1, "0,01");
                cmbSignificancia.Items.Insert(2, "0,025");
                cmbSignificancia.Items.Insert(3, "0,05");
                cmbSignificancia.Items.Insert(4, "0,10");
                cmbSignificancia.Items.Insert(5, "0,90");
                cmbSignificancia.Items.Insert(6, "0,95");
                cmbSignificancia.Items.Insert(7, "0,975");
                cmbSignificancia.Items.Insert(8, "0,99");
                cmbSignificancia.Items.Insert(9, "0,995");

                txtEstadistico.Text = Math.Round(gestor.estadisticoCHI, 4).ToString();
                validarGradosLibertadTestChi();
            }
            else if (cmbPrueba.SelectedItem != null && cmbPrueba.SelectedItem.ToString() == "K-S")
            {
                cmbSignificancia.Items.Clear();
                cmbSignificancia.Items.Insert(0, "0,20");
                cmbSignificancia.Items.Insert(1, "0,10");
                cmbSignificancia.Items.Insert(2, "0,05");
                cmbSignificancia.Items.Insert(3, "0,02");
                cmbSignificancia.Items.Insert(4, "0,01");
                cmbSignificancia.Items.Insert(5, "0,005");
                cmbSignificancia.Items.Insert(6, "0,002");
                cmbSignificancia.Items.Insert(7, "0,001");

                txtEstadistico.Text = Math.Round(gestor.estadisticoKS, 4).ToString();
                validarGradosLibertadTestKS();
            }
            
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(cmbPrueba.Text) && cmbSignificancia.SelectedIndex != -1)
            {

                if(cmbPrueba.Text == "Chi cuadrado")
                {
                    double chi_test_tabulado = ChiSquared.InvCDF(gestor.gradosLibertad, (1 - double.Parse(cmbSignificancia.Text)));
                    if (gestor.estadisticoCHI > chi_test_tabulado)
                    {
                        string mensaje = "El estadístico de prueba (" + txtEstadistico.Text + ")" + " es mayor al valor en tabla (" + Math.Round(chi_test_tabulado, 4).ToString() + "). La hipótesis nula se rechaza.";
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        string mensaje = "El estadístico de prueba (" + txtEstadistico.Text + ")" + " es menor al valor en tabla (" + Math.Round(chi_test_tabulado, 4).ToString() + "). La hipótesis nula no se puede rechazar.";
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    if (gestor.estadisticoKS > gestor.ks[gestor.i, gestor.j])
                    {
                        string mensaje = "El estadístico de prueba (" + txtEstadistico.Text + ")" + " es mayor al valor en tabla (" + Convert.ToString(gestor.ks[gestor.i, gestor.j]) + "). La hipótesis nula se rechaza.";
                        MessageBox.Show(mensaje);
                    }
                    else
                    {
                        string mensaje = "El estadístico de prueba (" + txtEstadistico.Text + ")" + " es menor al valor en tabla (" + Convert.ToString(gestor.ks[gestor.i, gestor.j]) + "). La hipótesis nula no se puede rechazar.";
                        MessageBox.Show(mensaje);
                    }
                }
            }
            else
            {
                MessageBox.Show("No ingresó alguno de los valores requeridos.");
            }

        }

        private void cmbSignificancia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnPrueba.Enabled = true;
            gestor.i = Convert.ToInt32(gestor.gradosLibertad);
            gestor.j = cmbSignificancia.SelectedIndex;
        }

        //*********************************************************  Validaciones  *********************************************************//

        //devuelve false cuando no se cargó algún parametro
        private void validarGradosLibertadTestChi()
        {
            switch (cmbDistribuciones.SelectedItem)
            {
                case "Normal":
                    gestor.gradosLibertad = gestor.cantIntervalos - 3;
                    txtGradosLibertad.Text = gestor.gradosLibertad.ToString();
                    break;
                case "Exponencial":
                    gestor.gradosLibertad = gestor.cantIntervalos - 2;
                    txtGradosLibertad.Text = gestor.gradosLibertad.ToString();
                    break;
                case "Poisson":
                    gestor.gradosLibertad = gestor.cantIntervalos - 2;
                    txtGradosLibertad.Text = gestor.gradosLibertad.ToString();
                    break;
                case "Uniforme":
                    gestor.gradosLibertad = gestor.cantIntervalos - 1;
                    txtGradosLibertad.Text = gestor.gradosLibertad.ToString();
                    break;
                default:
                    break;
            }
        }

        private void validarGradosLibertadTestKS()
        {
            gestor.gradosLibertad = gestor.cantIntervalos;
            txtGradosLibertad.Text = gestor.gradosLibertad.ToString();
            gestor.gradosLibertad = gestor.cantIntervalos - 1;
        }

        public bool validarParametrosVacios()
        {
            switch (cmbDistribuciones.SelectedItem)
            {
                case "Normal":
                    if (String.IsNullOrEmpty(txtSigma.Text) || String.IsNullOrEmpty(txtMu.Text))
                    {
                        return false;
                    }
                    else
                    {
                        gestor.sigma = Convert.ToDouble(txtSigma.Text);
                        gestor.u = Convert.ToDouble(txtMu.Text);
                        return true;
                    }

                case "Exponencial":
                    if (String.IsNullOrEmpty(txtLambda.Text))
                    {
                        return false;
                    }
                    else
                    {
                        gestor.lambda = Convert.ToDouble(txtLambda.Text);
                        return true;
                    }

                case "Uniforme":
                    if (String.IsNullOrEmpty(txtA.Text) || String.IsNullOrEmpty(txtB.Text))
                    {
                        return false;
                    }
                    else
                    {
                        gestor.a = Convert.ToDouble(txtA.Text);
                        gestor.b = Convert.ToDouble(txtB.Text);
                        return true;
                    }

                case "Poisson":
                    if (String.IsNullOrEmpty(txtLambda.Text))
                    {
                        return false;
                    }
                    else
                    {
                        gestor.lambda = Convert.ToDouble(txtLambda.Text);
                        return true;
                    }

                default:
                    return false;

            }
        }

        public void habilitarParametros(string opc)
        {
            txtSigma.Enabled = false;
            txtLambda.Enabled = false;
            txtMu.Enabled = false;
            txtA.Enabled = false;
            txtB.Enabled = false;

            switch (opc)
            {

                case "Normal":
                    txtSigma.Enabled = true;
                    txtMu.Enabled = true;
                    break;


                case "Exponencial":
                    txtLambda.Enabled = true;
                    break;


                case "Uniforme":
                    txtA.Enabled = true;
                    txtB.Enabled = true;
                    break;


                case "Poisson":
                    txtLambda.Enabled = true;
                    break;

            }

        }

        private void txtIntervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtSigma_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtLambda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtMu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txtLambda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189)
            {
                MessageBox.Show("No se permite lambda negativo");
                txtLambda.Text = "";
            }
        }

        private void txtSigma_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189)
            {
                MessageBox.Show("No se permite sigma negativo");
                txtSigma.Text = "";
            }
        }
    }
}
