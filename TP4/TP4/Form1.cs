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
        }
    }
}
