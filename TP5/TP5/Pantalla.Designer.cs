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
            this.clear = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.txt_iteraciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.reloj});
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(933, 425);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.GroupBox cantSim;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox txt_iteraciones;
        private System.Windows.Forms.Label label1;
    }
}

