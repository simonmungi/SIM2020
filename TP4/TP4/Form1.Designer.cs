﻿namespace TP4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_resetear = new System.Windows.Forms.Button();
            this.ckb_primerosdiezdias = new System.Windows.Forms.CheckBox();
            this.gb_congruencial = new System.Windows.Forms.GroupBox();
            this.btn_valoresPorDefectoCongruencial = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_semilla = new System.Windows.Forms.TextBox();
            this.ckb_nroAleatorioCongruencial = new System.Windows.Forms.CheckBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_turnoTarde = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_turnoMañana = new System.Windows.Forms.TextBox();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_frecuenciaCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_stockMaximo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_precioVentaPorCienGramos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_costoPorFrasco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidadGramosPorFrasco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cantidadFrascosPorCompra = new System.Windows.Forms.TextBox();
            this.btn_valoresPorDefecto = new System.Windows.Forms.Button();
            this.ckb_detalle = new System.Windows.Forms.CheckBox();
            this.txt_dias = new System.Windows.Forms.TextBox();
            this.lbl_dias = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_congruencial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_resetear);
            this.tabPage1.Controls.Add(this.ckb_primerosdiezdias);
            this.tabPage1.Controls.Add(this.gb_congruencial);
            this.tabPage1.Controls.Add(this.ckb_nroAleatorioCongruencial);
            this.tabPage1.Controls.Add(this.btn_simular);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(752, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parámetros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_resetear
            // 
            this.btn_resetear.Location = new System.Drawing.Point(348, 267);
            this.btn_resetear.Name = "btn_resetear";
            this.btn_resetear.Size = new System.Drawing.Size(103, 48);
            this.btn_resetear.TabIndex = 16;
            this.btn_resetear.Text = "Resetear";
            this.btn_resetear.UseVisualStyleBackColor = true;
            this.btn_resetear.Click += new System.EventHandler(this.btn_resetear_Click);
            // 
            // ckb_primerosdiezdias
            // 
            this.ckb_primerosdiezdias.AutoSize = true;
            this.ckb_primerosdiezdias.Enabled = false;
            this.ckb_primerosdiezdias.Location = new System.Drawing.Point(326, 179);
            this.ckb_primerosdiezdias.Name = "ckb_primerosdiezdias";
            this.ckb_primerosdiezdias.Size = new System.Drawing.Size(143, 17);
            this.ckb_primerosdiezdias.TabIndex = 15;
            this.ckb_primerosdiezdias.Text = "Mostrar Primeros 10 Dias";
            this.ckb_primerosdiezdias.UseVisualStyleBackColor = true;
            // 
            // gb_congruencial
            // 
            this.gb_congruencial.Controls.Add(this.btn_valoresPorDefectoCongruencial);
            this.gb_congruencial.Controls.Add(this.label12);
            this.gb_congruencial.Controls.Add(this.txt_m);
            this.gb_congruencial.Controls.Add(this.label11);
            this.gb_congruencial.Controls.Add(this.txt_c);
            this.gb_congruencial.Controls.Add(this.label10);
            this.gb_congruencial.Controls.Add(this.txt_a);
            this.gb_congruencial.Controls.Add(this.label9);
            this.gb_congruencial.Controls.Add(this.txt_semilla);
            this.gb_congruencial.Enabled = false;
            this.gb_congruencial.Location = new System.Drawing.Point(307, 40);
            this.gb_congruencial.Name = "gb_congruencial";
            this.gb_congruencial.Size = new System.Drawing.Size(185, 204);
            this.gb_congruencial.TabIndex = 14;
            this.gb_congruencial.TabStop = false;
            this.gb_congruencial.Text = "Método Congruencial (Parámetros)";
            // 
            // btn_valoresPorDefectoCongruencial
            // 
            this.btn_valoresPorDefectoCongruencial.Location = new System.Drawing.Point(19, 165);
            this.btn_valoresPorDefectoCongruencial.Name = "btn_valoresPorDefectoCongruencial";
            this.btn_valoresPorDefectoCongruencial.Size = new System.Drawing.Size(155, 23);
            this.btn_valoresPorDefectoCongruencial.TabIndex = 16;
            this.btn_valoresPorDefectoCongruencial.Text = "Cargar Valores por Defecto";
            this.btn_valoresPorDefectoCongruencial.UseVisualStyleBackColor = true;
            this.btn_valoresPorDefectoCongruencial.Click += new System.EventHandler(this.btn_valoresPorDefectoCongruencial_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "M:";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(62, 106);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(73, 20);
            this.txt_m.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "C:";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(62, 80);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(73, 20);
            this.txt_c.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "A:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(62, 54);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(73, 20);
            this.txt_a.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Semilla:";
            // 
            // txt_semilla
            // 
            this.txt_semilla.Location = new System.Drawing.Point(62, 28);
            this.txt_semilla.Name = "txt_semilla";
            this.txt_semilla.Size = new System.Drawing.Size(73, 20);
            this.txt_semilla.TabIndex = 7;
            // 
            // ckb_nroAleatorioCongruencial
            // 
            this.ckb_nroAleatorioCongruencial.AutoSize = true;
            this.ckb_nroAleatorioCongruencial.Location = new System.Drawing.Point(307, 16);
            this.ckb_nroAleatorioCongruencial.Name = "ckb_nroAleatorioCongruencial";
            this.ckb_nroAleatorioCongruencial.Size = new System.Drawing.Size(266, 17);
            this.ckb_nroAleatorioCongruencial.TabIndex = 13;
            this.ckb_nroAleatorioCongruencial.Text = "Generar Nros. Aleatorios con Método Congruencial";
            this.ckb_nroAleatorioCongruencial.UseVisualStyleBackColor = true;
            this.ckb_nroAleatorioCongruencial.CheckedChanged += new System.EventHandler(this.ckb_nroAleatorioCongruencial_CheckedChanged);
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(348, 329);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(103, 48);
            this.btn_simular.TabIndex = 12;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_detalle);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_valoresPorDefecto);
            this.groupBox1.Controls.Add(this.ckb_detalle);
            this.groupBox1.Controls.Add(this.txt_dias);
            this.groupBox1.Controls.Add(this.lbl_dias);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros a simular";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_turnoTarde);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_turnoMañana);
            this.groupBox3.Location = new System.Drawing.Point(5, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 72);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Turnos";
            // 
            // txt_turnoTarde
            // 
            this.txt_turnoTarde.Location = new System.Drawing.Point(123, 42);
            this.txt_turnoTarde.Name = "txt_turnoTarde";
            this.txt_turnoTarde.Size = new System.Drawing.Size(73, 20);
            this.txt_turnoTarde.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Horas Turno Mañana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Horas Turno Tarde:";
            // 
            // txt_turnoMañana
            // 
            this.txt_turnoMañana.Location = new System.Drawing.Point(123, 16);
            this.txt_turnoMañana.Name = "txt_turnoMañana";
            this.txt_turnoMañana.Size = new System.Drawing.Size(73, 20);
            this.txt_turnoMañana.TabIndex = 3;
            // 
            // txt_detalle
            // 
            this.txt_detalle.Enabled = false;
            this.txt_detalle.Location = new System.Drawing.Point(170, 49);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(100, 20);
            this.txt_detalle.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_frecuenciaCompra);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_stockMaximo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_precioVentaPorCienGramos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_costoPorFrasco);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_cantidadGramosPorFrasco);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_cantidadFrascosPorCompra);
            this.groupBox2.Location = new System.Drawing.Point(5, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 180);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frascos";
            // 
            // txt_frecuenciaCompra
            // 
            this.txt_frecuenciaCompra.Location = new System.Drawing.Point(173, 147);
            this.txt_frecuenciaCompra.Name = "txt_frecuenciaCompra";
            this.txt_frecuenciaCompra.Size = new System.Drawing.Size(73, 20);
            this.txt_frecuenciaCompra.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Frecuencia de Compra:";
            // 
            // txt_stockMaximo
            // 
            this.txt_stockMaximo.Location = new System.Drawing.Point(173, 121);
            this.txt_stockMaximo.Name = "txt_stockMaximo";
            this.txt_stockMaximo.Size = new System.Drawing.Size(73, 20);
            this.txt_stockMaximo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stock Máximo de Frascos:";
            // 
            // txt_precioVentaPorCienGramos
            // 
            this.txt_precioVentaPorCienGramos.Location = new System.Drawing.Point(173, 95);
            this.txt_precioVentaPorCienGramos.Name = "txt_precioVentaPorCienGramos";
            this.txt_precioVentaPorCienGramos.Size = new System.Drawing.Size(73, 20);
            this.txt_precioVentaPorCienGramos.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio de Venta c/100g:";
            // 
            // txt_costoPorFrasco
            // 
            this.txt_costoPorFrasco.Location = new System.Drawing.Point(173, 68);
            this.txt_costoPorFrasco.Name = "txt_costoPorFrasco";
            this.txt_costoPorFrasco.Size = new System.Drawing.Size(73, 20);
            this.txt_costoPorFrasco.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Costo de Café por Frasco:";
            // 
            // txt_cantidadGramosPorFrasco
            // 
            this.txt_cantidadGramosPorFrasco.Location = new System.Drawing.Point(173, 42);
            this.txt_cantidadGramosPorFrasco.Name = "txt_cantidadGramosPorFrasco";
            this.txt_cantidadGramosPorFrasco.Size = new System.Drawing.Size(73, 20);
            this.txt_cantidadGramosPorFrasco.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de Frascos por Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de Gramos por Frasco:";
            // 
            // txt_cantidadFrascosPorCompra
            // 
            this.txt_cantidadFrascosPorCompra.Location = new System.Drawing.Point(173, 17);
            this.txt_cantidadFrascosPorCompra.Name = "txt_cantidadFrascosPorCompra";
            this.txt_cantidadFrascosPorCompra.Size = new System.Drawing.Size(73, 20);
            this.txt_cantidadFrascosPorCompra.TabIndex = 3;
            // 
            // btn_valoresPorDefecto
            // 
            this.btn_valoresPorDefecto.Location = new System.Drawing.Point(5, 339);
            this.btn_valoresPorDefecto.Name = "btn_valoresPorDefecto";
            this.btn_valoresPorDefecto.Size = new System.Drawing.Size(155, 23);
            this.btn_valoresPorDefecto.TabIndex = 5;
            this.btn_valoresPorDefecto.Text = "Cargar Valores por Defecto";
            this.btn_valoresPorDefecto.UseVisualStyleBackColor = true;
            this.btn_valoresPorDefecto.Click += new System.EventHandler(this.btn_valoresPorDefecto_Click);
            // 
            // ckb_detalle
            // 
            this.ckb_detalle.AutoSize = true;
            this.ckb_detalle.Location = new System.Drawing.Point(9, 52);
            this.ckb_detalle.Name = "ckb_detalle";
            this.ckb_detalle.Size = new System.Drawing.Size(155, 17);
            this.ckb_detalle.TabIndex = 4;
            this.ckb_detalle.Text = "Detallar 50 dias a partir de: ";
            this.ckb_detalle.UseVisualStyleBackColor = true;
            this.ckb_detalle.CheckedChanged += new System.EventHandler(this.ckb_detalle_CheckedChanged);
            // 
            // txt_dias
            // 
            this.txt_dias.Location = new System.Drawing.Point(87, 23);
            this.txt_dias.Name = "txt_dias";
            this.txt_dias.Size = new System.Drawing.Size(100, 20);
            this.txt_dias.TabIndex = 1;
            // 
            // lbl_dias
            // 
            this.lbl_dias.AutoSize = true;
            this.lbl_dias.Location = new System.Drawing.Point(6, 26);
            this.lbl_dias.Name = "lbl_dias";
            this.lbl_dias.Size = new System.Drawing.Size(75, 13);
            this.lbl_dias.TabIndex = 0;
            this.lbl_dias.Text = "Dias a simular:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(752, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(752, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Integrantes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 127);
            this.groupBox5.TabIndex = 43;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grupo G";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Rojas Orosco, Cristian Jesus 72723";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "María E. Bordón 71336";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Franco Arroyo 67252";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Simón Mungi 72146";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 532);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP 4 - Monte Carlo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gb_congruencial.ResumeLayout(false);
            this.gb_congruencial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_precioVentaPorCienGramos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_costoPorFrasco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidadGramosPorFrasco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cantidadFrascosPorCompra;
        private System.Windows.Forms.Button btn_valoresPorDefecto;
        private System.Windows.Forms.CheckBox ckb_detalle;
        private System.Windows.Forms.TextBox txt_dias;
        private System.Windows.Forms.Label lbl_dias;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox ckb_primerosdiezdias;
        private System.Windows.Forms.GroupBox gb_congruencial;
        private System.Windows.Forms.Button btn_valoresPorDefectoCongruencial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_m;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_semilla;
        private System.Windows.Forms.CheckBox ckb_nroAleatorioCongruencial;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_turnoTarde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_turnoMañana;
        private System.Windows.Forms.TextBox txt_frecuenciaCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_stockMaximo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_resetear;
		private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

