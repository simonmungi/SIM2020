using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Form1 : Form
    {
        Gestor gestor;
        public Form1()
        {
            InitializeComponent();
        }

        private void ckb_nroAleatorioCongruencial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_nroAleatorioCongruencial.Checked)
            {
                gb_congruencial.Enabled = true;
                ckb_primerosdiezdias.Enabled = true;
            }
            else
            {
                gb_congruencial.Enabled = false;
                ckb_primerosdiezdias.Enabled = false;
            }
        }

        private void ckb_detalle_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_detalle.Checked)
            {
                txt_detalle.Enabled = true;
            }
            else
            {
                txt_detalle.Enabled = false;
            }
        }

        private void btn_valoresPorDefectoCongruencial_Click(object sender, EventArgs e)
        {
            txt_semilla.Text = "37";
            txt_a.Text = "13";
            txt_c.Text = "43";
            txt_m.Text = "101";
        }

        private void btn_valoresPorDefecto_Click(object sender, EventArgs e)
        {
            // Frascos
            txt_dias.Text = "100000";
            txt_cantidadFrascosPorCompra.Text = "2";
            txt_cantidadGramosPorFrasco.Text = "170";
            txt_costoPorFrasco.Text = "250";
            txt_stockMaximo.Text = "10";
            txt_precioVentaPorCienGramos.Text = "150";
            txt_frecuenciaCompra.Text = "2";

            // Turnos
            txt_turnoMañana.Text = "8";
            txt_turnoTarde.Text = "8";
        }

        private void btn_resetear_Click(object sender, EventArgs e)
        {
            txt_dias.Text = "";

            // Frascos
            txt_cantidadFrascosPorCompra.Text = "";
            txt_cantidadGramosPorFrasco.Text = "";
            txt_costoPorFrasco.Text = "";
            txt_stockMaximo.Text = "";
            txt_precioVentaPorCienGramos.Text = "";
            txt_frecuenciaCompra.Text = "";

            // Turnos
            txt_turnoMañana.Text = "";
            txt_turnoTarde.Text = "";

            // Detallar 50 Dias
            ckb_detalle.Checked = false;
            txt_detalle.Enabled = false;
            txt_detalle.Text = "";

            // Parametros Congruencial
            ckb_nroAleatorioCongruencial.Checked = false;
            txt_semilla.Text = "";
            txt_a.Text = "";
            txt_c.Text = "";
            txt_m.Text = "";
            gb_congruencial.Enabled = false;
            ckb_primerosdiezdias.Enabled = false;


            limpiar_grilla();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            //inicializo el generador de aleatorios dependiendo el checkbox
            Aleatorio aleatorio = new Aleatorio(ckb_nroAleatorioCongruencial.Checked, txt_semilla.Text, txt_a.Text, txt_c.Text, txt_m.Text);
           
            //inicializo el gestor con los datos de la pantalla
            gestor = new Gestor(txt_dias.Text,txt_cantidadFrascosPorCompra.Text,txt_cantidadGramosPorFrasco.Text,txt_costoPorFrasco.Text,txt_precioVentaPorCienGramos.Text,txt_stockMaximo.Text,txt_frecuenciaCompra.Text,txt_turnoMañana.Text, txt_turnoTarde.Text);
            gestor.aleatorio = aleatorio;

            //Condiciones iniciales
            gestor.vector_estados1[1] = 0; //ya viene con una compra hecha
            gestor.vector_estados1[16] = gestor._STOCK_INICIAL;
            gestor.vector_estados1[17] = 2;
            dataGridView1.Rows.Add(gestor._DIAS);
            //Loop principal
            for (int i=0; i < gestor._DIAS; i++)
            {                int j = 0;
                foreach (double valor in gestor.vector_estados1)
                {
                    if (j < 23)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = valor;
                    }
                    j++;
                }
                gestor.simular(i);
            }


		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // agregando columnas a la grilla
            //orden 0-5
            
            dataGridView1.Columns.Add("Dia", "Dia"); 
            dataGridView1.Columns.Add("Compra", "Compra");
            dataGridView1.Columns.Add("Rand_demora", "Random Demora");
            dataGridView1.Columns.Add("Demora", "Demora");
            dataGridView1.Columns.Add("Disponible_frascos", "Disponible (frascos)");
            dataGridView1.Columns.Add("Disponible_gramos", "Disponible (gramos)");
           
            // demanda 6-11
            dataGridView1.Columns.Add("Rnd_M", "Random Mañana");
            dataGridView1.Columns.Add("Rnd_Normal1", "Random Normal 1");
            dataGridView1.Columns.Add("Rnd_Normal2", "Random Normal 2");
            dataGridView1.Columns.Add("Demanda_M", "Demanda Mañana");
            dataGridView1.Columns.Add("Demanda_T", "Demanda Tarde");
            dataGridView1.Columns.Add("Total_dia", "Total Dia");
            
            // Ventas 12-15
            dataGridView1.Columns.Add("Ventas_g", "Ventas (gramos)");
            dataGridView1.Columns.Add("Ganancia", "Ganancia");
            dataGridView1.Columns.Add("Ganancia_acum", "Ganancia Acum.");
            dataGridView1.Columns.Add("Ganancia_media", "Ganancia Media");
            
            //Stock 16-19
            dataGridView1.Columns.Add("Stock_remanente_g", "Stock Remante (gramos)");
            dataGridView1.Columns.Add("Stock_remanente_f", "Stock Remanente (frascos)");
            dataGridView1.Columns.Add("Porcentaje_almacenado", "Porcentaje almacenado");
            dataGridView1.Columns.Add("Porcentaje_Dias_faltante", "Porcentaje Dias con Faltante");
            
            // Costos 20-22
            dataGridView1.Columns.Add("costos_Faltante", "Costos Faltante");
            dataGridView1.Columns.Add("costos_Compra", "Costos Compra");
            dataGridView1.Columns.Add("costos_Acumulado", "Costos Acumulado");

            foreach(DataGridViewColumn column in dataGridView1.Columns)
			{
                column.DataPropertyName = column.Name;
			}
        }


        private void limpiar_grilla()
		{
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
		}

       
	}
}
