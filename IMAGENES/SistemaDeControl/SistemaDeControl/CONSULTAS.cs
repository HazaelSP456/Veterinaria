using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeControl;

namespace SistemaDeControl
{
    public partial class CONSULTAS : Form
    {
        ClssDatos sql = new ClssDatos();
        private Inscripcion modify = null;
        public CONSULTAS()
        {
            InitializeComponent();
        }
        private Inscripcion FormInstances
        {
            get
            {
                if (modify == null)
                {
                    modify = new Inscripcion();
                    modify.Disposed += new EventHandler(form_Disposede);
                        }
                return modify;
            }
        }
        void form_Disposede(object sender, EventArgs e)
        {
            modify = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CONSULTAS_Load(object sender, EventArgs e)
        {
            sql.Load(this);
        }

        private void buscar_txt_TextChanged(object sender, EventArgs e)
        {
            sql.BuscarAlumno(this);
        }

        private void BOTONMODI_Click(object sender, EventArgs e)
        {
            Inscripcion frm = this.FormInstances;
            if (dataGridAlumno.SelectedRows.Count >0)
            {
                frm.curp_txt.Text = dataGridAlumno.CurrentRow.Cells[0].Value.ToString();
                frm.appalum.Text = dataGridAlumno.CurrentRow.Cells[1].Value.ToString();
                frm.apmalum.Text = dataGridAlumno.CurrentRow.Cells[2].Value.ToString();
                frm.nomalum.Text = dataGridAlumno.CurrentRow.Cells[3].Value.ToString();
                frm.sexo.Text = dataGridAlumno.CurrentRow.Cells[4].Value.ToString();
                frm.nacimientoalum.Text = dataGridAlumno.CurrentRow.Cells[5].Value.ToString();
                frm.edadalum.Text = dataGridAlumno.CurrentRow.Cells[6].Value.ToString();
                frm.alergias.Text = dataGridAlumno.CurrentRow.Cells[7].Value.ToString();
                
                frm.tiposangre1.Text = dataGridAlumno.CurrentRow.Cells[8].Value.ToString();
                frm.grado.Text = dataGridAlumno.CurrentRow.Cells[9].Value.ToString();
                if (frm.WindowState == FormWindowState.Minimized)
                    frm.WindowState = FormWindowState.Normal;
                AddOwnedForm(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.CenterScreen;
                this.Tag = frm;
                frm.BringToFront();
                frm.Enabled = true;
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No de ha seleccionada Alumno","Equipo Franky", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PANELMENU obj = new PANELMENU();
        }
    }
}
