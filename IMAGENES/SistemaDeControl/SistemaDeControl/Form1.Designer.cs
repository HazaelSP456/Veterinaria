namespace SistemaDeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BARRA = new System.Windows.Forms.Panel();
            this.BTRes = new System.Windows.Forms.PictureBox();
            this.BTMin = new System.Windows.Forms.PictureBox();
            this.BTMax = new System.Windows.Forms.PictureBox();
            this.BTCerrar = new System.Windows.Forms.PictureBox();
            this.CONTENIDO = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextUsuario = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTIngresar = new System.Windows.Forms.Button();
            this.TextContraseña = new System.Windows.Forms.TextBox();
            this.BARRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BARRA
            // 
            this.BARRA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BARRA.Controls.Add(this.BTRes);
            this.BARRA.Controls.Add(this.BTMin);
            this.BARRA.Controls.Add(this.BTMax);
            this.BARRA.Controls.Add(this.BTCerrar);
            this.BARRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.BARRA.Location = new System.Drawing.Point(0, 0);
            this.BARRA.Name = "BARRA";
            this.BARRA.Size = new System.Drawing.Size(1284, 35);
            this.BARRA.TabIndex = 0;
            // 
            // BTRes
            // 
            this.BTRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTRes.Image = ((System.Drawing.Image)(resources.GetObject("BTRes.Image")));
            this.BTRes.Location = new System.Drawing.Point(1216, 4);
            this.BTRes.Name = "BTRes";
            this.BTRes.Size = new System.Drawing.Size(25, 25);
            this.BTRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTRes.TabIndex = 1;
            this.BTRes.TabStop = false;
            this.BTRes.Visible = false;
            this.BTRes.Click += new System.EventHandler(this.BTRes_Click);
            // 
            // BTMin
            // 
            this.BTMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMin.Image = ((System.Drawing.Image)(resources.GetObject("BTMin.Image")));
            this.BTMin.Location = new System.Drawing.Point(1185, 3);
            this.BTMin.Name = "BTMin";
            this.BTMin.Size = new System.Drawing.Size(25, 25);
            this.BTMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTMin.TabIndex = 0;
            this.BTMin.TabStop = false;
            this.BTMin.Click += new System.EventHandler(this.BTMin_Click);
            // 
            // BTMax
            // 
            this.BTMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMax.Image = ((System.Drawing.Image)(resources.GetObject("BTMax.Image")));
            this.BTMax.Location = new System.Drawing.Point(1216, 4);
            this.BTMax.Name = "BTMax";
            this.BTMax.Size = new System.Drawing.Size(25, 25);
            this.BTMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTMax.TabIndex = 0;
            this.BTMax.TabStop = false;
            this.BTMax.Click += new System.EventHandler(this.BTMax_Click);
            // 
            // BTCerrar
            // 
            this.BTCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTCerrar.Image")));
            this.BTCerrar.Location = new System.Drawing.Point(1247, 4);
            this.BTCerrar.Name = "BTCerrar";
            this.BTCerrar.Size = new System.Drawing.Size(25, 25);
            this.BTCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTCerrar.TabIndex = 0;
            this.BTCerrar.TabStop = false;
            this.BTCerrar.Click += new System.EventHandler(this.BTCerrar_Click);
            // 
            // CONTENIDO
            // 
            this.CONTENIDO.BackColor = System.Drawing.Color.Brown;
            this.CONTENIDO.Location = new System.Drawing.Point(0, 35);
            this.CONTENIDO.Name = "CONTENIDO";
            this.CONTENIDO.Size = new System.Drawing.Size(237, 577);
            this.CONTENIDO.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 576);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(289, 246);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(201, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1054, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "NUEVA ESCUELA PRIMARIA NIÑOS HÉROES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.TextUsuario);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BTIngresar);
            this.panel2.Controls.Add(this.TextContraseña);
            this.panel2.Location = new System.Drawing.Point(370, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 239);
            this.panel2.TabIndex = 0;
            // 
            // TextUsuario
            // 
            this.TextUsuario.FormattingEnabled = true;
            this.TextUsuario.Items.AddRange(new object[] {
            "Director",
            "Secretario"});
            this.TextUsuario.Location = new System.Drawing.Point(366, 42);
            this.TextUsuario.Name = "TextUsuario";
            this.TextUsuario.Size = new System.Drawing.Size(180, 21);
            this.TextUsuario.TabIndex = 65;
            this.TextUsuario.Text = "Seleccione...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nombre del usuario:";
            // 
            // BTIngresar
            // 
            this.BTIngresar.Location = new System.Drawing.Point(415, 154);
            this.BTIngresar.Name = "BTIngresar";
            this.BTIngresar.Size = new System.Drawing.Size(98, 23);
            this.BTIngresar.TabIndex = 2;
            this.BTIngresar.Text = "Iniciar Sesión";
            this.BTIngresar.UseVisualStyleBackColor = true;
            this.BTIngresar.Click += new System.EventHandler(this.BTIngresar_Click);
            // 
            // TextContraseña
            // 
            this.TextContraseña.Location = new System.Drawing.Point(366, 104);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(180, 20);
            this.TextContraseña.TabIndex = 1;
            this.TextContraseña.Text = "1126";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CONTENIDO);
            this.Controls.Add(this.BARRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BARRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BARRA;
        private System.Windows.Forms.Panel CONTENIDO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BTCerrar;
        private System.Windows.Forms.PictureBox BTRes;
        private System.Windows.Forms.PictureBox BTMin;
        private System.Windows.Forms.PictureBox BTMax;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextContraseña;
        private System.Windows.Forms.Button BTIngresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox TextUsuario;
    }
}

