namespace WindowsFormsApp1
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
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.dataGridNumeros = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dataGridIntervalos = new System.Windows.Forms.DataGridView();
            this.dataGridFrecuencias = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.txtIntervalos = new System.Windows.Forms.TextBox();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.btnObtenerFrecuencias = new System.Windows.Forms.Button();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtVarianza = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbSignificancia = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGradosLibertad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEstadistico = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIntervalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "Mixto",
            "Multiplicativo",
            "Random"});
            this.cmbOpciones.Location = new System.Drawing.Point(78, 12);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(253, 21);
            this.cmbOpciones.TabIndex = 1;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            this.cmbOpciones.SelectionChangeCommitted += new System.EventHandler(this.cmbOpciones_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Método";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semilla";
            // 
            // txtSemilla
            // 
            this.txtSemilla.Enabled = false;
            this.txtSemilla.Location = new System.Drawing.Point(244, 45);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(87, 20);
            this.txtSemilla.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "c";
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(18, 21);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(78, 20);
            this.txtA.TabIndex = 10;
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(134, 99);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(85, 20);
            this.txtM.TabIndex = 11;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(244, 99);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(87, 20);
            this.txtC.TabIndex = 12;
            // 
            // dataGridNumeros
            // 
            this.dataGridNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNumeros.Location = new System.Drawing.Point(15, 240);
            this.dataGridNumeros.Name = "dataGridNumeros";
            this.dataGridNumeros.RowHeadersVisible = false;
            this.dataGridNumeros.Size = new System.Drawing.Size(316, 401);
            this.dataGridNumeros.TabIndex = 13;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(15, 167);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(204, 45);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Location = new System.Drawing.Point(11, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 66);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(78, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(114, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // dataGridIntervalos
            // 
            this.dataGridIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIntervalos.Location = new System.Drawing.Point(362, 240);
            this.dataGridIntervalos.Name = "dataGridIntervalos";
            this.dataGridIntervalos.RowHeadersVisible = false;
            this.dataGridIntervalos.Size = new System.Drawing.Size(321, 401);
            this.dataGridIntervalos.TabIndex = 17;
            // 
            // dataGridFrecuencias
            // 
            this.dataGridFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFrecuencias.Location = new System.Drawing.Point(690, 240);
            this.dataGridFrecuencias.Name = "dataGridFrecuencias";
            this.dataGridFrecuencias.RowHeadersVisible = false;
            this.dataGridFrecuencias.Size = new System.Drawing.Size(210, 401);
            this.dataGridFrecuencias.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Máximo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mínimo";
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Location = new System.Drawing.Point(566, 15);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(53, 13);
            this.lblIntervalos.TabIndex = 22;
            this.lblIntervalos.Text = "Intervalos";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(456, 38);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(69, 20);
            this.txtMax.TabIndex = 23;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(457, 12);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(68, 20);
            this.txtMin.TabIndex = 24;
            // 
            // lblPasos
            // 
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(566, 40);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(36, 13);
            this.lblPasos.TabIndex = 26;
            this.lblPasos.Text = "Pasos";
            // 
            // txtIntervalos
            // 
            this.txtIntervalos.Enabled = false;
            this.txtIntervalos.Location = new System.Drawing.Point(625, 12);
            this.txtIntervalos.Name = "txtIntervalos";
            this.txtIntervalos.Size = new System.Drawing.Size(57, 20);
            this.txtIntervalos.TabIndex = 27;
            this.txtIntervalos.TextChanged += new System.EventHandler(this.txtIntervalos_TextChanged);
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(626, 41);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.ReadOnly = true;
            this.txtPasos.Size = new System.Drawing.Size(56, 20);
            this.txtPasos.TabIndex = 28;
            this.txtPasos.TextChanged += new System.EventHandler(this.txtPasos_TextChanged);
            // 
            // btnObtenerFrecuencias
            // 
            this.btnObtenerFrecuencias.Location = new System.Drawing.Point(568, 73);
            this.btnObtenerFrecuencias.Name = "btnObtenerFrecuencias";
            this.btnObtenerFrecuencias.Size = new System.Drawing.Size(113, 26);
            this.btnObtenerFrecuencias.TabIndex = 29;
            this.btnObtenerFrecuencias.Text = "Obtener frecuencias";
            this.btnObtenerFrecuencias.UseVisualStyleBackColor = true;
            this.btnObtenerFrecuencias.Click += new System.EventHandler(this.btnObtenerFrecuencias_Click);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Enabled = false;
            this.btnGraficar.Location = new System.Drawing.Point(568, 109);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(114, 23);
            this.btnGraficar.TabIndex = 31;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Media";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Varianza";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(457, 77);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(68, 20);
            this.txtMedia.TabIndex = 34;
            // 
            // txtVarianza
            // 
            this.txtVarianza.Location = new System.Drawing.Point(457, 109);
            this.txtVarianza.Name = "txtVarianza";
            this.txtVarianza.ReadOnly = true;
            this.txtVarianza.Size = new System.Drawing.Size(68, 20);
            this.txtVarianza.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Simón Mungi 72146";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(723, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 100);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupo N";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Gabriel Arch 78210";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Pablo Sebastián Demasi 76726";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Franco Arroyo 67252";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(389, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 147);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(626, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 76);
            this.button1.TabIndex = 39;
            this.button1.Text = "Realizar prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(402, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Nivel de Significancia";
            // 
            // cmbSignificancia
            // 
            this.cmbSignificancia.FormattingEnabled = true;
            this.cmbSignificancia.Items.AddRange(new object[] {
            "0.005",
            "0.01",
            "0.025",
            "0.05",
            "0.10",
            "0.90",
            "0.95",
            "0.975",
            "0.99",
            "0.995",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.cmbSignificancia.Location = new System.Drawing.Point(534, 207);
            this.cmbSignificancia.Name = "cmbSignificancia";
            this.cmbSignificancia.Size = new System.Drawing.Size(81, 21);
            this.cmbSignificancia.TabIndex = 41;
            this.cmbSignificancia.SelectionChangeCommitted += new System.EventHandler(this.cmbSignificancia_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(402, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Grados de libertad";
            // 
            // txtGradosLibertad
            // 
            this.txtGradosLibertad.Location = new System.Drawing.Point(534, 181);
            this.txtGradosLibertad.Name = "txtGradosLibertad";
            this.txtGradosLibertad.ReadOnly = true;
            this.txtGradosLibertad.Size = new System.Drawing.Size(81, 20);
            this.txtGradosLibertad.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(402, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Estadístico de prueba (c)";
            // 
            // txtEstadistico
            // 
            this.txtEstadistico.Location = new System.Drawing.Point(534, 155);
            this.txtEstadistico.Name = "txtEstadistico";
            this.txtEstadistico.ReadOnly = true;
            this.txtEstadistico.Size = new System.Drawing.Size(81, 20);
            this.txtEstadistico.TabIndex = 45;
            this.txtEstadistico.TextChanged += new System.EventHandler(this.txtEstadistico_TextChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(244, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 43);
            this.button2.TabIndex = 46;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEstadistico);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtGradosLibertad);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbSignificancia);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtVarianza);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.btnObtenerFrecuencias);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.txtIntervalos);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridFrecuencias);
            this.Controls.Add(this.dataGridIntervalos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.dataGridNumeros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSemilla);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNumeros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIntervalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.DataGridView dataGridNumeros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dataGridIntervalos;
        private System.Windows.Forms.DataGridView dataGridFrecuencias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.TextBox txtIntervalos;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Button btnObtenerFrecuencias;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtVarianza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbSignificancia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGradosLibertad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEstadistico;
        private System.Windows.Forms.Button button2;
    }
}

