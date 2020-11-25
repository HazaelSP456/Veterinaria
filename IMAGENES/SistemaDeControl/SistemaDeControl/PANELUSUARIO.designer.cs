namespace SistemaDeControl
{
    partial class PANELUSUARIO
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PANELUSUARIO));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTRes = new System.Windows.Forms.PictureBox();
            this.BTMin = new System.Windows.Forms.PictureBox();
            this.BTMax = new System.Windows.Forms.PictureBox();
            this.BTCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTEliminarAl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTModificarAl = new System.Windows.Forms.Button();
            this.BTBoletas = new System.Windows.Forms.Button();
            this.BTRegistrarAl = new System.Windows.Forms.Button();
            this.BTDirectorio = new System.Windows.Forms.Button();
            this.BTBoletinInfo = new System.Windows.Forms.Button();
            this.BTMaterias = new System.Windows.Forms.Button();
            this.BTGrupos = new System.Windows.Forms.Button();
            this.BTAlumno = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.BTRes);
            this.panel1.Controls.Add(this.BTMin);
            this.panel1.Controls.Add(this.BTMax);
            this.panel1.Controls.Add(this.BTCerrar);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 35);
            this.panel1.TabIndex = 1;
            // 
            // BTRes
            // 
            this.BTRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTRes.Image = ((System.Drawing.Image)(resources.GetObject("BTRes.Image")));
            this.BTRes.Location = new System.Drawing.Point(1233, 7);
            this.BTRes.Name = "BTRes";
            this.BTRes.Size = new System.Drawing.Size(25, 25);
            this.BTRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTRes.TabIndex = 2;
            this.BTRes.TabStop = false;
            this.BTRes.Visible = false;
            this.BTRes.Click += new System.EventHandler(this.BTRes_Click);
            // 
            // BTMin
            // 
            this.BTMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMin.Image = ((System.Drawing.Image)(resources.GetObject("BTMin.Image")));
            this.BTMin.Location = new System.Drawing.Point(1202, 7);
            this.BTMin.Name = "BTMin";
            this.BTMin.Size = new System.Drawing.Size(25, 25);
            this.BTMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTMin.TabIndex = 2;
            this.BTMin.TabStop = false;
            this.BTMin.Click += new System.EventHandler(this.BTMin_Click);
            // 
            // BTMax
            // 
            this.BTMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMax.Image = ((System.Drawing.Image)(resources.GetObject("BTMax.Image")));
            this.BTMax.Location = new System.Drawing.Point(1233, 7);
            this.BTMax.Name = "BTMax";
            this.BTMax.Size = new System.Drawing.Size(25, 25);
            this.BTMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTMax.TabIndex = 2;
            this.BTMax.TabStop = false;
            this.BTMax.Click += new System.EventHandler(this.BTMax_Click);
            // 
            // BTCerrar
            // 
            this.BTCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTCerrar.Image")));
            this.BTCerrar.Location = new System.Drawing.Point(1264, 7);
            this.BTCerrar.Name = "BTCerrar";
            this.BTCerrar.Size = new System.Drawing.Size(25, 25);
            this.BTCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTCerrar.TabIndex = 1;
            this.BTCerrar.TabStop = false;
            this.BTCerrar.Click += new System.EventHandler(this.BTCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.BTEliminarAl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BTModificarAl);
            this.panel2.Controls.Add(this.BTBoletas);
            this.panel2.Controls.Add(this.BTRegistrarAl);
            this.panel2.Controls.Add(this.BTDirectorio);
            this.panel2.Controls.Add(this.BTBoletinInfo);
            this.panel2.Controls.Add(this.BTMaterias);
            this.panel2.Controls.Add(this.BTGrupos);
            this.panel2.Controls.Add(this.BTAlumno);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 650);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BTEliminarAl
            // 
            this.BTEliminarAl.FlatAppearance.BorderSize = 0;
            this.BTEliminarAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BTEliminarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEliminarAl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTEliminarAl.ForeColor = System.Drawing.Color.White;
            this.BTEliminarAl.Location = new System.Drawing.Point(28, 318);
            this.BTEliminarAl.Name = "BTEliminarAl";
            this.BTEliminarAl.Size = new System.Drawing.Size(194, 26);
            this.BTEliminarAl.TabIndex = 6;
            this.BTEliminarAl.Text = "Eliminar";
            this.BTEliminarAl.UseVisualStyleBackColor = true;
            this.BTEliminarAl.Click += new System.EventHandler(this.BTEliminarAl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BTModificarAl
            // 
            this.BTModificarAl.FlatAppearance.BorderSize = 0;
            this.BTModificarAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BTModificarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTModificarAl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTModificarAl.ForeColor = System.Drawing.Color.White;
            this.BTModificarAl.Location = new System.Drawing.Point(28, 283);
            this.BTModificarAl.Name = "BTModificarAl";
            this.BTModificarAl.Size = new System.Drawing.Size(194, 29);
            this.BTModificarAl.TabIndex = 5;
            this.BTModificarAl.Text = "Modificar";
            this.BTModificarAl.UseVisualStyleBackColor = true;
            this.BTModificarAl.Click += new System.EventHandler(this.BTModificarAl_Click);
            // 
            // BTBoletas
            // 
            this.BTBoletas.FlatAppearance.BorderSize = 0;
            this.BTBoletas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTBoletas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBoletas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBoletas.ForeColor = System.Drawing.Color.White;
            this.BTBoletas.Image = ((System.Drawing.Image)(resources.GetObject("BTBoletas.Image")));
            this.BTBoletas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTBoletas.Location = new System.Drawing.Point(-3, 562);
            this.BTBoletas.Name = "BTBoletas";
            this.BTBoletas.Size = new System.Drawing.Size(251, 36);
            this.BTBoletas.TabIndex = 9;
            this.BTBoletas.Text = "Boletas";
            this.BTBoletas.UseVisualStyleBackColor = true;
            // 
            // BTRegistrarAl
            // 
            this.BTRegistrarAl.FlatAppearance.BorderSize = 0;
            this.BTRegistrarAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BTRegistrarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTRegistrarAl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTRegistrarAl.ForeColor = System.Drawing.Color.White;
            this.BTRegistrarAl.Location = new System.Drawing.Point(28, 243);
            this.BTRegistrarAl.Name = "BTRegistrarAl";
            this.BTRegistrarAl.Size = new System.Drawing.Size(194, 34);
            this.BTRegistrarAl.TabIndex = 4;
            this.BTRegistrarAl.Text = "Registrar";
            this.BTRegistrarAl.UseVisualStyleBackColor = true;
            this.BTRegistrarAl.Click += new System.EventHandler(this.BTRegistrarAl_Click);
            // 
            // BTDirectorio
            // 
            this.BTDirectorio.FlatAppearance.BorderSize = 0;
            this.BTDirectorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTDirectorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTDirectorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTDirectorio.ForeColor = System.Drawing.Color.White;
            this.BTDirectorio.Image = ((System.Drawing.Image)(resources.GetObject("BTDirectorio.Image")));
            this.BTDirectorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTDirectorio.Location = new System.Drawing.Point(-3, 520);
            this.BTDirectorio.Name = "BTDirectorio";
            this.BTDirectorio.Size = new System.Drawing.Size(251, 36);
            this.BTDirectorio.TabIndex = 8;
            this.BTDirectorio.Text = "Directorio";
            this.BTDirectorio.UseVisualStyleBackColor = true;
            // 
            // BTBoletinInfo
            // 
            this.BTBoletinInfo.FlatAppearance.BorderSize = 0;
            this.BTBoletinInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTBoletinInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTBoletinInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTBoletinInfo.ForeColor = System.Drawing.Color.White;
            this.BTBoletinInfo.Image = ((System.Drawing.Image)(resources.GetObject("BTBoletinInfo.Image")));
            this.BTBoletinInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTBoletinInfo.Location = new System.Drawing.Point(-2, 604);
            this.BTBoletinInfo.Name = "BTBoletinInfo";
            this.BTBoletinInfo.Size = new System.Drawing.Size(251, 36);
            this.BTBoletinInfo.TabIndex = 7;
            this.BTBoletinInfo.Text = "     Boletín de Información";
            this.BTBoletinInfo.UseVisualStyleBackColor = true;
            // 
            // BTMaterias
            // 
            this.BTMaterias.FlatAppearance.BorderSize = 0;
            this.BTMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTMaterias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTMaterias.ForeColor = System.Drawing.Color.White;
            this.BTMaterias.Image = ((System.Drawing.Image)(resources.GetObject("BTMaterias.Image")));
            this.BTMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTMaterias.Location = new System.Drawing.Point(0, 469);
            this.BTMaterias.Name = "BTMaterias";
            this.BTMaterias.Size = new System.Drawing.Size(248, 36);
            this.BTMaterias.TabIndex = 5;
            this.BTMaterias.Text = "Materias";
            this.BTMaterias.UseVisualStyleBackColor = true;
            // 
            // BTGrupos
            // 
            this.BTGrupos.FlatAppearance.BorderSize = 0;
            this.BTGrupos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTGrupos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTGrupos.ForeColor = System.Drawing.Color.White;
            this.BTGrupos.Image = ((System.Drawing.Image)(resources.GetObject("BTGrupos.Image")));
            this.BTGrupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTGrupos.Location = new System.Drawing.Point(0, 415);
            this.BTGrupos.Name = "BTGrupos";
            this.BTGrupos.Size = new System.Drawing.Size(251, 36);
            this.BTGrupos.TabIndex = 4;
            this.BTGrupos.Text = "Grupos";
            this.BTGrupos.UseVisualStyleBackColor = true;
            // 
            // BTAlumno
            // 
            this.BTAlumno.FlatAppearance.BorderSize = 0;
            this.BTAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTAlumno.ForeColor = System.Drawing.Color.White;
            this.BTAlumno.Image = ((System.Drawing.Image)(resources.GetObject("BTAlumno.Image")));
            this.BTAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTAlumno.Location = new System.Drawing.Point(3, 201);
            this.BTAlumno.Name = "BTAlumno";
            this.BTAlumno.Size = new System.Drawing.Size(248, 47);
            this.BTAlumno.TabIndex = 3;
            this.BTAlumno.Text = "Alumno";
            this.BTAlumno.UseVisualStyleBackColor = true;
            this.BTAlumno.Click += new System.EventHandler(this.BTAlumno_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PContenedor
            // 
            this.PContenedor.Location = new System.Drawing.Point(253, 39);
            this.PContenedor.Name = "PContenedor";
            this.PContenedor.Size = new System.Drawing.Size(1046, 612);
            this.PContenedor.TabIndex = 4;
            // 
            // PANELUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PANELUSUARIO";
            this.Text = "s";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BTRes;
        private System.Windows.Forms.PictureBox BTMin;
        private System.Windows.Forms.PictureBox BTMax;
        private System.Windows.Forms.PictureBox BTCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTBoletas;
        private System.Windows.Forms.Button BTDirectorio;
        private System.Windows.Forms.Button BTBoletinInfo;
        private System.Windows.Forms.Button BTMaterias;
        private System.Windows.Forms.Button BTGrupos;
        private System.Windows.Forms.Button BTAlumno;
        private System.Windows.Forms.Button BTEliminarAl;
        private System.Windows.Forms.Button BTModificarAl;
        private System.Windows.Forms.Button BTRegistrarAl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel PContenedor;
    }
}