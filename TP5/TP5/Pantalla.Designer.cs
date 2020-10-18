namespace TP5
{
    partial class Pantalla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cantSim = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.txt_iteraciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEntrePedidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoProximoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCocinero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoCocinero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoPreparacionCocinero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoFinCocinero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaCocinero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCocinero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoCocinero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoPreparacionCocinero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoFinCocinero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaCocinero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCocinero3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoCocinero3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoPreparacionCocinero3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProximoFinCocinero3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaCocinero3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEntregaDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinProximaEntregaDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColaDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cantSim.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.evento,
            this.reloj,
            this.NumeroPedido,
            this.ProximoPedido,
            this.TiempoEntrePedidos,
            this.TiempoProximoPedido,
            this.TipoPedido,
            this.Cantidad,
            this.Costo,
            this.EstadoCocinero1,
            this.PedidoCocinero1,
            this.TiempoPreparacionCocinero1,
            this.ProximoFinCocinero1,
            this.ColaCocinero1,
            this.EstadoCocinero2,
            this.PedidoCocinero2,
            this.TiempoPreparacionCocinero2,
            this.ProximoFinCocinero2,
            this.ColaCocinero2,
            this.EstadoCocinero3,
            this.PedidoCocinero3,
            this.TiempoPreparacionCocinero3,
            this.ProximoFinCocinero3,
            this.ColaCocinero3,
            this.EstadoDelivery,
            this.PedidoDelivery,
            this.TiempoEntregaDelivery,
            this.FinProximaEntregaDelivery,
            this.ColaDelivery});
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // cantSim
            // 
            this.cantSim.Controls.Add(this.checkBox1);
            this.cantSim.Controls.Add(this.clear);
            this.cantSim.Controls.Add(this.start);
            this.cantSim.Controls.Add(this.txt_iteraciones);
            this.cantSim.Controls.Add(this.label1);
            this.cantSim.Location = new System.Drawing.Point(982, 12);
            this.cantSim.Name = "cantSim";
            this.cantSim.Size = new System.Drawing.Size(259, 147);
            this.cantSim.TabIndex = 2;
            this.cantSim.TabStop = false;
            this.cantSim.Text = "Simulacion";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Usar valores por defecto";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.LightSalmon;
            this.clear.Location = new System.Drawing.Point(159, 57);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(82, 29);
            this.clear.TabIndex = 7;
            this.clear.Text = "Limpiar Todo";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.PaleGreen;
            this.start.Location = new System.Drawing.Point(11, 103);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(230, 25);
            this.start.TabIndex = 6;
            this.start.Text = "Simular";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // txt_iteraciones
            // 
            this.txt_iteraciones.Location = new System.Drawing.Point(124, 22);
            this.txt_iteraciones.Name = "txt_iteraciones";
            this.txt_iteraciones.Size = new System.Drawing.Size(117, 20);
            this.txt_iteraciones.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Iteraciones: ";
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteración";
            this.iteracion.Name = "iteracion";
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.HeaderText = "Numero de Pedido";
            this.NumeroPedido.Name = "NumeroPedido";
            // 
            // ProximoPedido
            // 
            this.ProximoPedido.HeaderText = "Proximo Pedido";
            this.ProximoPedido.Name = "ProximoPedido";
            // 
            // TiempoEntrePedidos
            // 
            this.TiempoEntrePedidos.HeaderText = "Tiempo entre pedidos";
            this.TiempoEntrePedidos.Name = "TiempoEntrePedidos";
            // 
            // TiempoProximoPedido
            // 
            this.TiempoProximoPedido.HeaderText = "Tiempo Proximo Pedido";
            this.TiempoProximoPedido.Name = "TiempoProximoPedido";
            // 
            // TipoPedido
            // 
            this.TipoPedido.HeaderText = "Tipo Pedido";
            this.TipoPedido.Name = "TipoPedido";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // EstadoCocinero1
            // 
            this.EstadoCocinero1.HeaderText = "Estado";
            this.EstadoCocinero1.Name = "EstadoCocinero1";
            // 
            // PedidoCocinero1
            // 
            this.PedidoCocinero1.HeaderText = "Pedido";
            this.PedidoCocinero1.Name = "PedidoCocinero1";
            // 
            // TiempoPreparacionCocinero1
            // 
            this.TiempoPreparacionCocinero1.HeaderText = "Tiempo Preparacion";
            this.TiempoPreparacionCocinero1.Name = "TiempoPreparacionCocinero1";
            // 
            // ProximoFinCocinero1
            // 
            this.ProximoFinCocinero1.HeaderText = "Proximo Fin de Preparacion";
            this.ProximoFinCocinero1.Name = "ProximoFinCocinero1";
            // 
            // ColaCocinero1
            // 
            this.ColaCocinero1.HeaderText = "Cola";
            this.ColaCocinero1.Name = "ColaCocinero1";
            // 
            // EstadoCocinero2
            // 
            this.EstadoCocinero2.HeaderText = "Estado";
            this.EstadoCocinero2.Name = "EstadoCocinero2";
            // 
            // PedidoCocinero2
            // 
            this.PedidoCocinero2.HeaderText = "Pedido";
            this.PedidoCocinero2.Name = "PedidoCocinero2";
            // 
            // TiempoPreparacionCocinero2
            // 
            this.TiempoPreparacionCocinero2.HeaderText = "Tiempo Preparacion";
            this.TiempoPreparacionCocinero2.Name = "TiempoPreparacionCocinero2";
            // 
            // ProximoFinCocinero2
            // 
            this.ProximoFinCocinero2.HeaderText = "Proximo Fin de Preparacion";
            this.ProximoFinCocinero2.Name = "ProximoFinCocinero2";
            // 
            // ColaCocinero2
            // 
            this.ColaCocinero2.HeaderText = "Cola";
            this.ColaCocinero2.Name = "ColaCocinero2";
            // 
            // EstadoCocinero3
            // 
            this.EstadoCocinero3.HeaderText = "Estado";
            this.EstadoCocinero3.Name = "EstadoCocinero3";
            // 
            // PedidoCocinero3
            // 
            this.PedidoCocinero3.HeaderText = "Pedido";
            this.PedidoCocinero3.Name = "PedidoCocinero3";
            // 
            // TiempoPreparacionCocinero3
            // 
            this.TiempoPreparacionCocinero3.HeaderText = "Tiempo Preparacion";
            this.TiempoPreparacionCocinero3.Name = "TiempoPreparacionCocinero3";
            // 
            // ProximoFinCocinero3
            // 
            this.ProximoFinCocinero3.HeaderText = "Proximo Fin de Preparacion";
            this.ProximoFinCocinero3.Name = "ProximoFinCocinero3";
            // 
            // ColaCocinero3
            // 
            this.ColaCocinero3.HeaderText = "Cola";
            this.ColaCocinero3.Name = "ColaCocinero3";
            // 
            // EstadoDelivery
            // 
            this.EstadoDelivery.HeaderText = "Estado";
            this.EstadoDelivery.Name = "EstadoDelivery";
            // 
            // PedidoDelivery
            // 
            this.PedidoDelivery.HeaderText = "Pedido";
            this.PedidoDelivery.Name = "PedidoDelivery";
            // 
            // TiempoEntregaDelivery
            // 
            this.TiempoEntregaDelivery.HeaderText = "Tiempo Entrega";
            this.TiempoEntregaDelivery.Name = "TiempoEntregaDelivery";
            // 
            // FinProximaEntregaDelivery
            // 
            this.FinProximaEntregaDelivery.HeaderText = "Fin Proxima Entrega";
            this.FinProximaEntregaDelivery.Name = "FinProximaEntregaDelivery";
            // 
            // ColaDelivery
            // 
            this.ColaDelivery.HeaderText = "Cola Delivery";
            this.ColaDelivery.Name = "ColaDelivery";
            // 
            // Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.cantSim);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pantalla";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cantSim.ResumeLayout(false);
            this.cantSim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox cantSim;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox txt_iteraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEntrePedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoProximoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCocinero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoCocinero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoPreparacionCocinero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoFinCocinero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaCocinero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCocinero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoCocinero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoPreparacionCocinero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoFinCocinero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaCocinero2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCocinero3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoCocinero3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoPreparacionCocinero3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProximoFinCocinero3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaCocinero3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEntregaDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinProximaEntregaDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColaDelivery;
    }
}

