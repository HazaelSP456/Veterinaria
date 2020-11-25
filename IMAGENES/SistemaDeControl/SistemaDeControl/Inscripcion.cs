using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeControl
{
    public partial class Inscripcion : Form
    {
        ClssDatos sql = new ClssDatos();
        public Inscripcion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql.GuardarAlumno(this);
            sql.GuardarPadreTutor(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            sql.curp = curp_txt.Text;            
            sql.appalum = appalum.Text;
            sql.apmalum = apmalum.Text;
            sql.nomalum = nomalum.Text;
            sql.sexo = sexo.Text;
            sql.nacimientoalum = nacimientoalum.Text;
            sql.edadalum = edadalum.Text;
            sql.alergias = alergias.Text;
            sql.tiposangre = tiposangre.Text;
            sql.grado = grado.Text;
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {

        }
    }
}
