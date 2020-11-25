using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeControl
{
    public partial class PANELUSUARIO : Form
    {
        bool MenuAlumnoAbierto = false;

        SqlConnection con;
        public PANELUSUARIO()
        {
            
            InitializeComponent();
        }

        private void BTCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTMax.Visible = false;
            BTRes.Visible = true;
        }

        private void BTRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTRes.Visible = false;
            BTMax.Visible = true; 
        }

        private void BTMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTAlumno_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (MenuAlumnoAbierto)
            //{
            //    PMenuAlumno.Width -= 20;
            //    if (PMenuAlumno.Width == 0)
            //    {
            //        timer1.Stop();
            //        MenuAlumnoAbierto = false;
            //    }
            //}
            //else if(MenuAlumnoAbierto==false)
            //{
            //    PMenuAlumno.Width += 20;
            //    if(PMenuAlumno.Width==200)
            //    {
            //        timer1.Stop();
            //        MenuAlumnoAbierto = true;
            //    }
            //}
        }

        private void AbrirInscripcion(object Incripcion)
        {
            if (this.PContenedor.Controls.Count > 0)
                this.PContenedor.Controls.RemoveAt(0);
            Form INS = Incripcion as Form;
            INS.TopLevel= false;
            INS.Dock = DockStyle.Fill;
            this.PContenedor.Controls.Add(INS);
            this.PContenedor.Tag = INS;
            INS.Show();
        }

        private void BTRegistrarAl_Click(object sender, EventArgs e)
        { 
        //    INSCRIPCION RUs = new INSCRIPCION(con); //instancia del forumlario registrar usuario
        //    AbrirInscripcion(new INSCRIPCION(con));

        //    INSCRIPCION obj = new INSCRIPCION(con);
        //    obj.Visible = false;//llamamos al formulario dos y lo ponemos visible.
        //    Visible = true;// se oculta el formulario 1 (donde se inicia sesion).
        }

        private void BTEliminarAl_Click(object sender, EventArgs e)
        {
            //ELIMINAR ELA = new ELIMINAR(con); //instancia del forumlario registrar usuario
            //AbrirEliminar(new ELIMINAR(con));

            //ELIMINAR obj = new ELIMINAR(con);
            //obj.Visible = false;//llamamos al formulario dos y lo ponemos visible.
            //Visible = true;// se oculta el formulario 1 (donde se inicia sesion).
        } //REGRESAR AL PANEL USUARO DESPUES DE USAR LA OPCCION ELIMINAR

        private void AbrirModificar(object Incripcion)
        {
            if (this.PContenedor.Controls.Count > 0)
                this.PContenedor.Controls.RemoveAt(0);
            Form INS = Incripcion as Form;
            INS.TopLevel = false;
            INS.Dock = DockStyle.Fill;
            this.PContenedor.Controls.Add(INS);
            this.PContenedor.Tag = INS;
            INS.Show();
        }//ABRIR PANEL MODIFICAR
        private void BTModificarAl_Click(object sender, EventArgs e)
        {
            //MODIFICAR ELA = new MODIFICAR(con); //instancia del forumlario registrar usuario
            //AbrirEliminar(new MODIFICAR(con));
            //MODIFICAR obj = new MODIFICAR(con);
            //obj.Visible = false;//llamamos al formulario dos y lo ponemos visible.
            //Visible = true;// se oculta el formulario 1 (donde se inicia sesion).
        } //REGRESAR AL PANEL USUARO DESPUES DE USAR LA OPCCION MODIFICAR

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

