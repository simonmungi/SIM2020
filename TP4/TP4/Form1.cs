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
        int desde = 0;
        int cant_dias = 50;
        int cada = 10000;
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
            if (!validarDatos())
            {
                MessageBox.Show("Por favor rellene todos los parametros");
                return;
            }
            tabControl1.SelectedTab = tabPage2;
            //inicializo el generador de aleatorios dependiendo el checkbox
            Aleatorio aleatorio = new Aleatorio(ckb_nroAleatorioCongruencial.Checked, txt_semilla.Text, txt_a.Text, txt_c.Text, txt_m.Text);

            //inicializo el gestor con los datos de la pantalla
            gestor = new Gestor(txt_dias.Text, txt_cantidadFrascosPorCompra.Text, txt_cantidadGramosPorFrasco.Text, txt_costoPorFrasco.Text, txt_precioVentaPorCienGramos.Text, txt_stockMaximo.Text, txt_frecuenciaCompra.Text, txt_turnoMañana.Text, txt_turnoTarde.Text);
            gestor.aleatorio = aleatorio;

            //Condiciones iniciales
            gestor.vector_estados1[1] = 0; //ya viene con una compra hecha
            gestor.vector_estados1[16] = gestor._STOCK_INICIAL;
            gestor.vector_estados1[17] = 2;
            //dataGridView1.Rows.Add(gestor._DIAS);

            limpiar_grilla();

            //Loop principal
            int f = 0;
            for (int i = 0; i < gestor._DIAS + 1; i++)
            {
                if ((i >= desde) && ((i < desde + cant_dias + 1) || ((i % cada) == 0)))
                {
                    dataGridView1.Rows.Add();
                    dataGridView1["Dia", f].Value = gestor.vector_estados1[0];
                    dataGridView1["Compra", f].Value = gestor.vector_estados1[1];
                    dataGridView1["Rand_demora", f].Value = gestor.vector_estados1[2];
                    dataGridView1["Demora", f].Value = gestor.vector_estados1[3];
                    dataGridView1["Disponible_frascos", f].Value = gestor.vector_estados1[4];
                    dataGridView1["Disponible_gramos", f].Value = gestor.vector_estados1[5];
                    dataGridView1["Rnd_M", f].Value = gestor.vector_estados1[6];
                    dataGridView1["Rnd_Normal1", f].Value = gestor.vector_estados1[7];
                    dataGridView1["Rnd_Normal2", f].Value = gestor.vector_estados1[8];
                    dataGridView1["Demanda_M", f].Value = gestor.vector_estados1[9];
                    dataGridView1["Demanda_T", f].Value = gestor.vector_estados1[10];
                    dataGridView1["Total_dia", f].Value = gestor.vector_estados1[11];
                    dataGridView1["Ventas_g", f].Value = gestor.vector_estados1[12];
                    dataGridView1["Ganancia", f].Value = gestor.vector_estados1[13];
                    dataGridView1["Ganancia_acum", f].Value = gestor.vector_estados1[14];
                    dataGridView1["Ganancia_media", f].Value = gestor.vector_estados1[15];
                    dataGridView1["Stock_remanente_g", f].Value = gestor.vector_estados1[16];
                    dataGridView1["Stock_remanente_f", f].Value = gestor.vector_estados1[17];
                    dataGridView1["Porcentaje_almacenado", f].Value = gestor.vector_estados1[18];
                    dataGridView1["Porcentaje_Dias_faltante", f].Value = gestor.vector_estados1[19];
                    dataGridView1["0_2", f].Value = gestor.vector_estados1[20];
                    dataGridView1["2_5", f].Value = gestor.vector_estados1[21];
                    dataGridView1["5_8", f].Value = gestor.vector_estados1[22];
                    dataGridView1["8_mas", f].Value = gestor.vector_estados1[23];
                    dataGridView1["costos_Faltante", f].Value = gestor.vector_estados1[24];
                    dataGridView1["costos_Compra", f].Value = gestor.vector_estados1[25];
                    dataGridView1["costos_Acumulado", f].Value = gestor.vector_estados1[26];

                    dataGridView1["Stock_remante_promedio", f].Value = gestor.vector_estados1[27];
                    dataGridView1["Cant_faltante_g", f].Value = gestor.vector_estados1[28];
                    dataGridView1["promedio_faltante", f].Value = gestor.vector_estados1[29];
                    dataGridView1["promedio_horas_perdidas", f].Value = gestor.vector_estados1[36];

                    dataGridView1["costo_de_cafe_vendido", f].Value = gestor.vector_estados1[39];
                    dataGridView1["beneficio_diario", f].Value = gestor.vector_estados1[37];
                    dataGridView1["beneficio_promedio_diario", f].Value = gestor.vector_estados1[38];

                    f++;
                }
                gestor.simular(i);
            }
        }

        private bool validarDatos()
        {
            bool validar = true;
            if (String.IsNullOrEmpty(txt_dias.Text) || String.IsNullOrEmpty(txt_cantidadFrascosPorCompra.Text) || 
                String.IsNullOrEmpty(txt_cantidadGramosPorFrasco.Text) || String.IsNullOrEmpty(txt_costoPorFrasco.Text) ||
                String.IsNullOrEmpty(txt_precioVentaPorCienGramos.Text) || String.IsNullOrEmpty(txt_stockMaximo.Text) ||
                String.IsNullOrEmpty(txt_frecuenciaCompra.Text))
            {
                validar = false;
            }
            if (ckb_nroAleatorioCongruencial.Checked)
            {
                if(String.IsNullOrEmpty(txt_a.Text) || String.IsNullOrEmpty(txt_c.Text) || String.IsNullOrEmpty(txt_m.Text) || String.IsNullOrEmpty(txt_semilla.Text))
                {
                    validar = false;
                }
            }
            if (ckb_detalle.Checked)
            {
                if (String.IsNullOrEmpty(txt_detalle.Text))
                {
                    validar = false;
                }
            }
            return validar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // agregando columnas a la grilla
            //orden 0-5
            dataGridView1.Columns.Add("Dia", "Dia");
            dataGridView1.Columns.Add("Compra", "Compra");
            dataGridView1.Columns.Add("Rand_demora", "Random Demora");
            dataGridView1.Columns.Add("Demora", "Demora (dias)");
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
            dataGridView1.Columns.Add("Ganancia", "Ganancia (pesos)");
            dataGridView1.Columns.Add("Ganancia_acum", "Ganancia Acum. (pesos)");
            dataGridView1.Columns.Add("Ganancia_media", "Ganancia Media (pesos)");

            dataGridView1.Columns[12].HeaderCell.Style.BackColor = Color.FromArgb(146, 208, 80);
            dataGridView1.Columns[13].HeaderCell.Style.BackColor = Color.FromArgb(146, 208, 80);
            dataGridView1.Columns[14].HeaderCell.Style.BackColor = Color.FromArgb(146, 208, 80);
            dataGridView1.Columns[15].HeaderCell.Style.BackColor = Color.FromArgb(44, 208, 0);

            dataGridView1.Columns[12].Width = 70;
            dataGridView1.Columns[13].Width = 70;
            dataGridView1.Columns[14].Width = 70;
            dataGridView1.Columns[15].Width = 70;

            //Stock 16-17
            dataGridView1.Columns.Add("Stock_remanente_g", "Stock Remante (gramos)");
            dataGridView1.Columns.Add("Stock_remanente_f", "Stock Remanente (frascos)");
            //18-19
            dataGridView1.Columns.Add("Porcentaje_almacenado", "Porcentaje almacenado");
            dataGridView1.Columns.Add("Porcentaje_Dias_faltante", "Porcentaje Dias con Faltante");

            dataGridView1.Columns.Add("0_2", "0 a 2");
            dataGridView1.Columns.Add("2_5", "2 a 5");
            dataGridView1.Columns.Add("5_8", "5 a 8");
            dataGridView1.Columns.Add("8_mas", "8 o más");


            dataGridView1.Columns[16].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[17].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[18].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[19].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[20].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[21].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[22].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[23].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);

            dataGridView1.Columns[16].Width = 70;
            dataGridView1.Columns[17].Width = 70;
            dataGridView1.Columns[18].Width = 70;
            dataGridView1.Columns[19].Width = 70;
            dataGridView1.Columns[20].Width = 60;
            dataGridView1.Columns[21].Width = 60;
            dataGridView1.Columns[22].Width = 60;
            dataGridView1.Columns[23].Width = 60;

            dataGridView1.Columns[18].DefaultCellStyle.Format = "#0.0%";
            dataGridView1.Columns[19].DefaultCellStyle.Format = "#0.0%";
            dataGridView1.Columns[20].DefaultCellStyle.Format = "#0.0%";
            dataGridView1.Columns[21].DefaultCellStyle.Format = "#0.0%";
            dataGridView1.Columns[22].DefaultCellStyle.Format = "#0.0%";
            dataGridView1.Columns[23].DefaultCellStyle.Format = "#0.0%";

            // Costos 24-26
            dataGridView1.Columns.Add("costos_Faltante", "Costos Faltante");
            dataGridView1.Columns.Add("costos_Compra", "Costos Compra");
            dataGridView1.Columns.Add("costos_Acumulado", "Costos Acumulado");

            dataGridView1.Columns[24].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);
            dataGridView1.Columns[25].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);
            dataGridView1.Columns[26].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);

            dataGridView1.Columns[24].Width = 70;
            dataGridView1.Columns[25].Width = 70;
            dataGridView1.Columns[26].Width = 70;

            //27-30
            dataGridView1.Columns.Add("Stock_remante_promedio", "Cant Prom de café almacenada al final del día");
            dataGridView1.Columns.Add("Cant_faltante_g", "Cantidad de Café Faltante");
            dataGridView1.Columns.Add("promedio_faltante", "Cant Prom de Café faltante");
            dataGridView1.Columns.Add("promedio_horas_perdidas", "Promedio de horas perdidas");

            dataGridView1.Columns[27].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[28].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);
            dataGridView1.Columns[29].HeaderCell.Style.BackColor = Color.FromArgb(248, 203, 173);

            dataGridView1.Columns[27].Width = 70;
            dataGridView1.Columns[28].Width = 70;
            dataGridView1.Columns[29].Width = 70;
            dataGridView1.Columns[30].Width = 70;

            //31-33
            dataGridView1.Columns.Add("costo_de_cafe_vendido", "Costo de Café Vendido");
            dataGridView1.Columns.Add("beneficio_diario", "Beneficio Diario");
            dataGridView1.Columns.Add("beneficio_promedio_diario", "Promedio Beneficio Diario");


            dataGridView1.Columns[30].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);
            dataGridView1.Columns[31].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);
            dataGridView1.Columns[32].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);
            dataGridView1.Columns[33].HeaderCell.Style.BackColor = Color.FromArgb(255, 192, 0);


            dataGridView1.Columns[31].Width = 70;
            dataGridView1.Columns[32].Width = 70;
            dataGridView1.Columns[33].Width = 70;


            // ajustar orden            
            establecer_orden_col();
        }

        private void establecer_orden_col()
        {
            //orden           
            dataGridView1.Columns["Dia"].DisplayIndex = 0;
            dataGridView1.Columns["Compra"].DisplayIndex = 1;
            dataGridView1.Columns["Rand_demora"].DisplayIndex = 2;
            dataGridView1.Columns["Demora"].DisplayIndex = 3;
            dataGridView1.Columns["Disponible_frascos"].DisplayIndex = 4;
            dataGridView1.Columns["Disponible_gramos"].DisplayIndex = 5;


            // demanda 6-11            
            dataGridView1.Columns["Rnd_M"].DisplayIndex = 6;
            dataGridView1.Columns["Rnd_Normal1"].DisplayIndex = 7;
            dataGridView1.Columns["Rnd_Normal2"].DisplayIndex = 8;
            dataGridView1.Columns["Demanda_M"].DisplayIndex = 9;
            dataGridView1.Columns["Demanda_T"].DisplayIndex = 10;
            dataGridView1.Columns["Total_dia"].DisplayIndex = 11;

            // Ventas 12-15
            dataGridView1.Columns["Ventas_g"].DisplayIndex = 12;
            dataGridView1.Columns["Ganancia"].DisplayIndex = 13;
            dataGridView1.Columns["Ganancia_acum"].DisplayIndex = 14;
            dataGridView1.Columns["Ganancia_media"].DisplayIndex = 15;

            //Stock remante
            dataGridView1.Columns["Stock_remanente_g"].DisplayIndex = 16;
            dataGridView1.Columns["Stock_remanente_f"].DisplayIndex = 17;
            dataGridView1.Columns["Porcentaje_almacenado"].DisplayIndex = 18;
            dataGridView1.Columns["Stock_remante_promedio"].DisplayIndex = 19;

            // Stock faltante
            dataGridView1.Columns["Cant_faltante_g"].DisplayIndex = 20;
            dataGridView1.Columns["promedio_faltante"].DisplayIndex = 21;
            dataGridView1.Columns["Porcentaje_Dias_faltante"].DisplayIndex = 22;

            dataGridView1.Columns["0_2"].DisplayIndex = 23;
            dataGridView1.Columns["2_5"].DisplayIndex = 24;
            dataGridView1.Columns["5_8"].DisplayIndex = 25;
            dataGridView1.Columns["8_mas"].DisplayIndex = 26;

            dataGridView1.Columns["promedio_horas_perdidas"].DisplayIndex = 27;

            // Costos  y beneficio
            dataGridView1.Columns["costos_Faltante"].DisplayIndex = 28;
            dataGridView1.Columns["costos_Compra"].DisplayIndex = 29;
            dataGridView1.Columns["costos_Acumulado"].DisplayIndex = 30;
            dataGridView1.Columns["costo_de_cafe_vendido"].DisplayIndex = 31;
            dataGridView1.Columns["beneficio_diario"].DisplayIndex = 32;
            dataGridView1.Columns["beneficio_promedio_diario"].DisplayIndex = 33;

        }


        private void limpiar_grilla()
        {
            dataGridView1.Rows.Clear();
        }

        private void txt_dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_dias_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189){ txt_dias.Text = "";  }
        }

        private void txt_detalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_detalle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_detalle.Text = ""; }
        }

        private void txt_cantidadFrascosPorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_cantidadFrascosPorCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_cantidadFrascosPorCompra.Text = ""; }
        }

        private void txt_cantidadGramosPorFrasco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_cantidadGramosPorFrasco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_cantidadFrascosPorCompra.Text = ""; }
        }

        private void txt_costoPorFrasco_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_precioVentaPorCienGramos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_precioVentaPorCienGramos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_precioVentaPorCienGramos.Text = ""; }
        }

        private void txt_stockMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_stockMaximo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_stockMaximo.Text = ""; }
        }

        private void txt_frecuenciaCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_frecuenciaCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_frecuenciaCompra.Text = ""; }
        }

        private void txt_turnoMañana_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_turnoMañana_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_turnoMañana.Text = ""; }
        }

        private void txt_turnoTarde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_turnoTarde_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_turnoTarde.Text = ""; }
        }

        private void txt_semilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_semilla_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_semilla.Text = ""; }
        }

        private void txt_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_a_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_a.Text = ""; }
        }

        private void txt_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_c_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_c.Text = ""; }
        }

        private void txt_m_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);
        }

        private void txt_m_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 189) { txt_m.Text = ""; }
        }
    }
}
