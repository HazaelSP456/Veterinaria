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
using SistemaDeControl;

namespace SistemaDeControl
{
    public partial class PANELMENU : Form
    {
        public PANELMENU()
        {
            //SqlConnection con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inscripcion  PUs = new Inscripcion();
            PUs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CONSULTAS PUs = new CONSULTAS();
            PUs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
