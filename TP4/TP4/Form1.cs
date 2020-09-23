using System;
using System.Collections;
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
            txt_costoPorFrasco.Text = "-250";
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
            tabControl1.SelectedTab = tabPage2;
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
            {
                dataGridView1["Dia", i].Value = gestor.vector_estados1[0];
                dataGridView1["Compra", i].Value = gestor.vector_estados1[1];
                dataGridView1["Rand_demora", i].Value = gestor.vector_estados1[2];
                dataGridView1["Demora", i].Value = gestor.vector_estados1[3];
                dataGridView1["Disponible_frascos", i].Value = gestor.vector_estados1[4];
                dataGridView1["Disponible_gramos", i].Value = gestor.vector_estados1[5];
                dataGridView1["Rnd_M", i].Value = gestor.vector_estados1[6];
                dataGridView1["Rnd_Normal1", i].Value = gestor.vector_estados1[7];
                dataGridView1["Rnd_Normal2", i].Value = gestor.vector_estados1[8];
                dataGridView1["Demanda_M", i].Value = gestor.vector_estados1[9];
                dataGridView1["Demanda_T", i].Value = gestor.vector_estados1[10];
                dataGridView1["Total_dia", i].Value = gestor.vector_estados1[11];
                dataGridView1["Ventas_g", i].Value = gestor.vector_estados1[12];
                dataGridView1["Ganancia", i].Value = gestor.vector_estados1[13];
                dataGridView1["Ganancia_acum", i].Value = gestor.vector_estados1[14];
                dataGridView1["Ganancia_media", i].Value = gestor.vector_estados1[15];
                dataGridView1["Stock_remanente_g", i].Value = gestor.vector_estados1[16];
                dataGridView1["Stock_remanente_f", i].Value = gestor.vector_estados1[17];
                dataGridView1["Porcentaje_almacenado", i].Value = gestor.vector_estados1[18];
                dataGridView1["Porcentaje_Dias_faltante", i].Value = gestor.vector_estados1[19];
                dataGridView1["costos_Faltante", i].Value = gestor.vector_estados1[20];
                dataGridView1["costos_Compra", i].Value = gestor.vector_estados1[21];
                dataGridView1["costos_Acumulado", i].Value = gestor.vector_estados1[22];
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

            dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.FromArgb(255, 217, 102);
            dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.FromArgb(255, 217, 102);
            dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.FromArgb(255, 217, 102);
            dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.FromArgb(255, 217, 102);
            dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.FromArgb(255, 217, 102);

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[5].Width = 70;

            // demanda 6-11
            dataGridView1.Columns.Add("Rnd_M", "Random Mañana");
            dataGridView1.Columns.Add("Rnd_Normal1", "Random Normal 1");
            dataGridView1.Columns.Add("Rnd_Normal2", "Random Normal 2");
            dataGridView1.Columns.Add("Demanda_M", "Demanda Mañana");
            dataGridView1.Columns.Add("Demanda_T", "Demanda Tarde");
            dataGridView1.Columns.Add("Total_dia", "Total Dia");

            dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.FromArgb(189, 215, 238);
            dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.FromArgb(189, 215, 238);
            dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.FromArgb(189, 215, 238);
            dataGridView1.Columns[9].HeaderCell.Style.BackColor = Color.FromArgb(189, 215, 238);
            dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.FromArgb(189, 215, 238);
            dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.FromArgb(189, 215, 238);

            dataGridView1.Columns[6].Width = 70;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 70;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns[10].Width = 70;
            dataGridView1.Columns[11].Width = 70;


            // Ventas 12-15
            dataGridView1.Columns.Add("Ventas_g", "Ventas (gramos)");
            dataGridView1.Columns.Add("Ganancia", "Ganancia");
            dataGridView1.Columns.Add("Ganancia_acum", "Ganancia Acum.");
            dataGridView1.Columns.Add("Ganancia_media", "Ganancia Media");

            dataGridView1.Columns[12].HeaderCell.Style.BackColor = Color.FromArgb(146, 208, 80);
            dataGridView1.Columns[13].HeaderCell.Style.BackColor = Color.FromArgb(146, 208, 80);
            dataGridView1.Columns[14].HeaderCell.Style.BackColor = Color.FromArgb(146, 208, 80);
            dataGridView1.Columns[15].HeaderCell.Style.BackColor = Color.FromArgb(44, 208, 0);

            dataGridView1.Columns[12].Width = 70;
            dataGridView1.Columns[13].Width = 70;
            dataGridView1.Columns[14].Width = 70;
            dataGridView1.Columns[15].Width = 70;

            //Stock 16-19
            dataGridView1.Columns.Add("Stock_remanente_g", "Stock Remante (gramos)");
            dataGridView1.Columns.Add("Stock_remanente_f", "Stock Remanente (frascos)");
            dataGridView1.Columns.Add("Porcentaje_almacenado", "Porcentaje almacenado");
            dataGridView1.Columns.Add("Porcentaje_Dias_faltante", "Porcentaje Dias con Faltante");

            dataGridView1.Columns[16].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[17].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[18].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[19].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);

            dataGridView1.Columns[16].Width = 70;
            dataGridView1.Columns[17].Width = 70;
            dataGridView1.Columns[18].Width = 70;
            dataGridView1.Columns[19].Width = 70;

            dataGridView1.Columns[18].DefaultCellStyle.Format = "#0%";

            // Costos 20-22
            dataGridView1.Columns.Add("costos_Faltante", "Costos Faltante");
            dataGridView1.Columns.Add("costos_Compra", "Costos Compra");
            dataGridView1.Columns.Add("costos_Acumulado", "Costos Acumulado");

            dataGridView1.Columns[20].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);
            dataGridView1.Columns[21].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);
            dataGridView1.Columns[22].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);

            dataGridView1.Columns[20].Width = 70;
            dataGridView1.Columns[21].Width = 70;
            dataGridView1.Columns[22].Width = 70;


            foreach (DataGridViewColumn column in dataGridView1.Columns)
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
