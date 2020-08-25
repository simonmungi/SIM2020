namespace TP2_NetFramework
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.cmbDistribuciones = new System.Windows.Forms.ComboBox();
            this.dataGridFrecuencias = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcumObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esperados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcumEsperado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIntervalos = new System.Windows.Forms.TextBox();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSignificancia = new System.Windows.Forms.ComboBox();
            this.txtGradosLibertad = new System.Windows.Forms.TextBox();
            this.txtEstadistico = new System.Windows.Forms.TextBox();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLambda = new System.Windows.Forms.TextBox();
            this.lblDesviacion = new System.Windows.Forms.Label();
            this.txtSigma = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(240, 391);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.Location = new System.Drawing.Point(6, 22);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(48, 13);
            this.lblVarianza.TabIndex = 2;
            this.lblVarianza.Text = "Varianza";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(18, 50);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 3;
            this.lblMedia.Text = "Media";
            // 
            // txtVarianza
            // 
            this.txtVarianza.Location = new System.Drawing.Point(60, 19);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.ReadOnly = true;
            this.txtVarianza.Size = new System.Drawing.Size(45, 20);
            this.txtVarianza.TabIndex = 4;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(60, 47);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(45, 20);
            this.txtMedia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Máximo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimo";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(191, 47);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(45, 20);
            this.txtMin.TabIndex = 8;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(191, 19);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(45, 20);
            this.txtMax.TabIndex = 9;
            // 
            // cmbDistribuciones
            // 
            this.cmbDistribuciones.FormattingEnabled = true;
            this.cmbDistribuciones.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial",
            "Poisson"});
            this.cmbDistribuciones.Location = new System.Drawing.Point(299, 29);
            this.cmbDistribuciones.Name = "cmbDistribuciones";
            this.cmbDistribuciones.Size = new System.Drawing.Size(137, 21);
            this.cmbDistribuciones.TabIndex = 10;
            this.cmbDistribuciones.SelectedIndexChanged += new System.EventHandler(this.cmbDistribuciones_SelectedIndexChanged);
            // 
            // dataGridFrecuencias
            // 
            this.dataGridFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Min,
            this.Max,
            this.Observados,
            this.ProbObs,
            this.AcumObs,
            this.Esperados,
            this.ProbEsp,
            this.AcumEsperado});
            this.dataGridFrecuencias.Location = new System.Drawing.Point(612, 411);
            this.dataGridFrecuencias.Name = "dataGridFrecuencias";
            this.dataGridFrecuencias.RowHeadersVisible = false;
            this.dataGridFrecuencias.Size = new System.Drawing.Size(746, 326);
            this.dataGridFrecuencias.TabIndex = 15;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.Width = 50;
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.Name = "Min";
            this.Min.Width = 80;
            // 
            // Max
            // 
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
            this.Max.Width = 80;
            // 
            // Observados
            // 
            this.Observados.HeaderText = "Observados";
            this.Observados.Name = "Observados";
            this.Observados.Width = 85;
            // 
            // ProbObs
            // 
            this.ProbObs.HeaderText = "P(Oi)";
            this.ProbObs.Name = "ProbObs";
            this.ProbObs.Width = 50;
            // 
            // AcumObs
            // 
            this.AcumObs.HeaderText = "Acumulado (Oi)";
            this.AcumObs.Name = "AcumObs";
            this.AcumObs.Width = 110;
            // 
            // Esperados
            // 
            this.Esperados.HeaderText = "Esperados";
            this.Esperados.Name = "Esperados";
            this.Esperados.Width = 85;
            // 
            // ProbEsp
            // 
            this.ProbEsp.HeaderText = "P(Ei)";
            this.ProbEsp.Name = "ProbEsp";
            this.ProbEsp.Width = 50;
            // 
            // AcumEsperado
            // 
            this.AcumEsperado.HeaderText = "Acumulado (Ei)";
            this.AcumEsperado.Name = "AcumEsperado";
            this.AcumEsperado.Width = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Obtener Frecuencias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Enabled = false;
            this.txtIntervalos.Location = new System.Drawing.Point(314, 257);
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(50, 20);
            this.txtIntervalos.TabIndex = 19;
            this.txtIntervalos.TextChanged += new System.EventHandler(this.txtIntervalos_TextChanged);
            this.txtIntervalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntervalos_KeyPress);
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(375, 257);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.ReadOnly = true;
            this.txtPasos.Size = new System.Drawing.Size(50, 20);
            this.txtPasos.TabIndex = 20;
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(372, 241);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(36, 13);
            this.lblPasos.TabIndex = 21;
            this.lblPasos.Text = "Pasos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Intervalos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(299, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 78);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 78);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtVarianza);
            this.groupBox3.Controls.Add(this.lblVarianza);
            this.groupBox3.Controls.Add(this.lblMedia);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMedia);
            this.groupBox3.Controls.Add(this.txtMax);
            this.groupBox3.Controls.Add(this.txtMin);
            this.groupBox3.Location = new System.Drawing.Point(299, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 85);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Distribucion";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Generar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 749);
            this.splitter1.TabIndex = 32;
            this.splitter1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Estadistico de prueba (c)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Grados de libertad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Nivel de significancia";
            // 
            // cmbSignificancia
            // 
            this.cmbSignificancia.Enabled = false;
            this.cmbSignificancia.FormattingEnabled = true;
            this.cmbSignificancia.Location = new System.Drawing.Point(167, 550);
            this.cmbSignificancia.Name = "cmbSignificancia";
            this.cmbSignificancia.Size = new System.Drawing.Size(121, 21);
            this.cmbSignificancia.TabIndex = 36;
            this.cmbSignificancia.SelectionChangeCommitted += new System.EventHandler(this.cmbSignificancia_SelectionChangeCommitted);
            // 
            // txtGradosLibertad
            // 
            this.txtGradosLibertad.Location = new System.Drawing.Point(167, 518);
            this.txtGradosLibertad.Name = "txtGradosLibertad";
            this.txtGradosLibertad.ReadOnly = true;
            this.txtGradosLibertad.Size = new System.Drawing.Size(121, 20);
            this.txtGradosLibertad.TabIndex = 37;
            // 
            // txtEstadistico
            // 
            this.txtEstadistico.Location = new System.Drawing.Point(167, 488);
            this.txtEstadistico.Name = "txtEstadistico";
            this.txtEstadistico.ReadOnly = true;
            this.txtEstadistico.Size = new System.Drawing.Size(121, 20);
            this.txtEstadistico.TabIndex = 38;
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.Enabled = false;
            this.cmbPrueba.FormattingEnabled = true;
            this.cmbPrueba.Items.AddRange(new object[] {
            "Chi cuadrado",
            "K-S"});
            this.cmbPrueba.Location = new System.Drawing.Point(381, 28);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(118, 21);
            this.cmbPrueba.TabIndex = 39;
            this.cmbPrueba.SelectedIndexChanged += new System.EventHandler(this.cmbPrueba_SelectedIndexChanged);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Enabled = false;
            this.btnPrueba.Location = new System.Drawing.Point(332, 62);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(167, 50);
            this.btnPrueba.TabIndex = 40;
            this.btnPrueba.Text = "Realizar Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPrueba);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbPrueba);
            this.groupBox4.Location = new System.Drawing.Point(12, 459);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(545, 145);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Pruebas";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(12, 610);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(228, 127);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grupo G";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Franco Arroyo 67252";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Simón Mungi 72146";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(612, 12);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Observado";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Esperado";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(746, 393);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(450, 29);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(107, 20);
            this.txtCantidad.TabIndex = 45;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMu);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txtA);
            this.groupBox6.Controls.Add(this.txtB);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtLambda);
            this.groupBox6.Controls.Add(this.lblDesviacion);
            this.groupBox6.Controls.Add(this.txtSigma);
            this.groupBox6.Location = new System.Drawing.Point(299, 68);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(258, 107);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            // 
            // txtMu
            // 
            this.txtMu.Enabled = false;
            this.txtMu.Location = new System.Drawing.Point(191, 19);
            this.txtMu.Name = "txtMu";
            this.txtMu.Size = new System.Drawing.Size(45, 20);
            this.txtMu.TabIndex = 37;
            this.txtMu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMu_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(170, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 47;
            this.label15.Text = "μ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "a";
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(31, 68);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(45, 20);
            this.txtA.TabIndex = 35;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Location = new System.Drawing.Point(110, 68);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(45, 20);
            this.txtB.TabIndex = 37;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(87, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "λ";
            // 
            // txtLambda
            // 
            this.txtLambda.Enabled = false;
            this.txtLambda.Location = new System.Drawing.Point(109, 19);
            this.txtLambda.Name = "txtLambda";
            this.txtLambda.Size = new System.Drawing.Size(46, 20);
            this.txtLambda.TabIndex = 34;
            this.txtLambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLambda_KeyPress);
            // 
            // lblDesviacion
            // 
            this.lblDesviacion.AutoSize = true;
            this.lblDesviacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesviacion.Location = new System.Drawing.Point(7, 19);
            this.lblDesviacion.Name = "lblDesviacion";
            this.lblDesviacion.Size = new System.Drawing.Size(18, 20);
            this.lblDesviacion.TabIndex = 31;
            this.lblDesviacion.Text = "σ";
            // 
            // txtSigma
            // 
            this.txtSigma.Enabled = false;
            this.txtSigma.Location = new System.Drawing.Point(31, 19);
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.Size = new System.Drawing.Size(45, 20);
            this.txtSigma.TabIndex = 32;
            this.txtSigma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSigma_KeyPress);
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Rojas Orosco, Cristian Jesus 72723";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtEstadistico);
            this.Controls.Add(this.txtGradosLibertad);
            this.Controls.Add(this.cmbSignificancia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.txtIntervalos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridFrecuencias);
            this.Controls.Add(this.cmbDistribuciones);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.ComboBox cmbDistribuciones;
        private System.Windows.Forms.DataGridView dataGridFrecuencias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIntervalos;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esperados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumEsperado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSignificancia;
        private System.Windows.Forms.TextBox txtGradosLibertad;
        private System.Windows.Forms.TextBox txtEstadistico;
        private System.Windows.Forms.ComboBox cmbPrueba;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtMu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLambda;
        private System.Windows.Forms.Label lblDesviacion;
        private System.Windows.Forms.TextBox txtSigma;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

