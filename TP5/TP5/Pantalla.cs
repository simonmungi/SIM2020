using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5.Entidades.Pedidos;

namespace TP5
{
    public partial class Pantalla : Form
    {
        Gestor gestor;

        public Pantalla()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            //inicializo el Gestor
            gestor = new Gestor(this);
            //gestor.simular(int iteraciones, int mostrarDesde, int mostrarHasta)
            gestor.simular();

        }


        public void cargarLinea(int f, dynamic[] vectorAnterior)
        {
            dataGridView1.Rows.Add();
            dataGridView1["iteracion", f].Value = vectorAnterior[0];
            dataGridView1["evento", f].Value = vectorAnterior[1];
            dataGridView1["reloj", f].Value = vectorAnterior[2];
            dataGridView1["NumeroPedido", f].Value = vectorAnterior[3];
            dataGridView1["ProximoPedido", f].Value = vectorAnterior[4];
            dataGridView1["TiempoEntrePedidos", f].Value = vectorAnterior[5];
            dataGridView1["TiempoProximoPedido", f].Value = vectorAnterior[6];
            dataGridView1["TipoPedido", f].Value = vectorAnterior[7];
            dataGridView1["Cantidad", f].Value = vectorAnterior[8];
            dataGridView1["Costo", f].Value = vectorAnterior[9];

            dataGridView1["EstadoCocinero1", f].Value = vectorAnterior[10];
            dataGridView1["PedidoCocinero1", f].Value = vectorAnterior[11];
            dataGridView1["TiempoPreparacionCocinero1", f].Value = vectorAnterior[12];
            dataGridView1["ProximoFinCocinero1", f].Value = vectorAnterior[13];
            dataGridView1["ColaCocinero1", f].Value = vectorAnterior[14];

            dataGridView1["EstadoCocinero2", f].Value = vectorAnterior[15];
            dataGridView1["PedidoCocinero2", f].Value = vectorAnterior[16];
            dataGridView1["TiempoPreparacionCocinero2", f].Value =vectorAnterior[17];
            dataGridView1["ProximoFinCocinero2", f].Value = vectorAnterior[18];
            dataGridView1["ColaCocinero2", f].Value = vectorAnterior[19];

            dataGridView1["EstadoCocinero3", f].Value = vectorAnterior[20];
            dataGridView1["PedidoCocinero3", f].Value = vectorAnterior[21];
            dataGridView1["TiempoPreparacionCocinero3", f].Value = vectorAnterior[22];
            dataGridView1["ProximoFinCocinero3", f].Value = vectorAnterior[23];
            dataGridView1["ColaCocinero3", f].Value = vectorAnterior[24];

            dataGridView1["EstadoDelivery", f].Value = vectorAnterior[25];
            dataGridView1["PedidoDelivery", f].Value = vectorAnterior[26];
            dataGridView1["TiempoEntregaDelivery", f].Value = vectorAnterior[27];
            dataGridView1["FinProximaEntregaDelivery", f].Value = vectorAnterior[28];
            dataGridView1["ColaDelivery", f].Value = vectorAnterior[29];
        }



    }
}
