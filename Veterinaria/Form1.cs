using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text.Equals("") || TextContraseña.Text.Equals(""))
                MessageBox.Show("Ingrese los datos correspondientes", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                //ESTO LUEGO SE MODIFICARA, CON LA CNEXION A LA BASE DE DATOS
                PANELMENU PUs = new PANELMENU();
                PUs.ShowDialog();


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
