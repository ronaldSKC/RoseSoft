﻿namespace RoseSoft
{
    partial class busquedaCliente
    {

        /*BLOQUE PARA VALIDAR QUE NO SE ABRA VARIAS VECES LA VENTA*/
        public static busquedaCliente buscarClienteInstance = null;

        public static busquedaCliente Instance()
        {
            if (((buscarClienteInstance == null) || (buscarClienteInstance.IsDisposed == true)))
            {
                buscarClienteInstance = new busquedaCliente();
            }
            buscarClienteInstance.BringToFront();
            return buscarClienteInstance;
        }


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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1_Buscar = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_Buscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1_Cliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1_Buscar);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1_Buscar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(368, 81);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda";
            // 
            // comboBox1_Buscar
            // 
            this.comboBox1_Buscar.FormattingEnabled = true;
            this.comboBox1_Buscar.Items.AddRange(new object[] {
            "NOMBRE",
            "NÚMERO DE CÉDULA",
            "PROVINCIA",
            "CUIDAD"});
            this.comboBox1_Buscar.Location = new System.Drawing.Point(15, 45);
            this.comboBox1_Buscar.Name = "comboBox1_Buscar";
            this.comboBox1_Buscar.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_Buscar.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1_Buscar
            // 
            this.textBox1_Buscar.Location = new System.Drawing.Point(142, 45);
            this.textBox1_Buscar.Name = "textBox1_Buscar";
            this.textBox1_Buscar.Size = new System.Drawing.Size(135, 20);
            this.textBox1_Buscar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Buscar por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(11, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 208);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados de busqueda";
            // 
            // dataGridView1_Cliente
            // 
            this.dataGridView1_Cliente.AllowUserToAddRows = false;
            this.dataGridView1_Cliente.AllowUserToDeleteRows = false;
            this.dataGridView1_Cliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Cliente.Location = new System.Drawing.Point(15, 26);
            this.dataGridView1_Cliente.Name = "dataGridView1_Cliente";
            this.dataGridView1_Cliente.ReadOnly = true;
            this.dataGridView1_Cliente.RowHeadersVisible = false;
            this.dataGridView1_Cliente.Size = new System.Drawing.Size(508, 167);
            this.dataGridView1_Cliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // busquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 386);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "busquedaCliente";
            this.Text = "Busqueda Cliente";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1_Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_Buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1_Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}