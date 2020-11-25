namespace SistemaDeControl
{
    partial class CONSULTAS
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
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buscar_txt = new System.Windows.Forms.TextBox();
            this.BOTONMODI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Location = new System.Drawing.Point(75, 103);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.Size = new System.Drawing.Size(1046, 491);
            this.dataGridAlumno.TabIndex = 0;
            this.dataGridAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buscar_txt
            // 
            this.buscar_txt.Location = new System.Drawing.Point(40, 49);
            this.buscar_txt.Name = "buscar_txt";
            this.buscar_txt.Size = new System.Drawing.Size(185, 20);
            this.buscar_txt.TabIndex = 2;
            this.buscar_txt.TextChanged += new System.EventHandler(this.buscar_txt_TextChanged);
            // 
            // BOTONMODI
            // 
            this.BOTONMODI.Location = new System.Drawing.Point(369, 20);
            this.BOTONMODI.Name = "BOTONMODI";
            this.BOTONMODI.Size = new System.Drawing.Size(100, 23);
            this.BOTONMODI.TabIndex = 3;
            this.BOTONMODI.Text = "MODIFICAR";
            this.BOTONMODI.UseVisualStyleBackColor = true;
            this.BOTONMODI.Click += new System.EventHandler(this.BOTONMODI_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "BUSQUEDA (POR CURP):";
            // 
            // CONSULTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(893, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BOTONMODI);
            this.Controls.Add(this.buscar_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridAlumno);
            this.Name = "CONSULTAS";
            this.Text = "CONSULTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CONSULTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAlumno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox buscar_txt;
        private System.Windows.Forms.Button BOTONMODI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}