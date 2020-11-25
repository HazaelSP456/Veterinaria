using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaDeControl
{
    public partial class Form1 : Form
    {     CONEXION conn = new CONEXION();
        public SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-IDJCKBS\\MSSQLSERVER01;Initial Catalog=Pboleta;Integrated Security=True");
        public Form1()
        {
            //CONEXION con = new CONEXION();
            //con = CONEXION.conectar;
            
           
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

        private void BTRegistrarUS_Click(object sender, EventArgs e)
        {
            //REGISTRARUS RUs = new REGISTRARUS(con); //instancia del forumlario registrar usuario
            //RUs.Visible = true; //llamamos al formulario dos y lo ponemos visible.
            //Visible = false; // se oculta el formulario 1 (donde se inicia sesion).
            ////RUs.ShowDialog();
        }

        public void BTIngresar_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text.Equals("") || TextContraseña.Text.Equals(""))
                MessageBox.Show("Ingrese los datos correspondientes", "IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                SqlCommand Consulta = new SqlCommand();
                
                Consulta.Connection = conectar;
                conectar.Open();
                Consulta.CommandText = "select count(*) from usuario where nom_usuario= '" + TextUsuario.Text + "' and contraseña= '" + TextContraseña.Text + "'";
                SqlDataReader read = Consulta.ExecuteReader(); read.Read();
                if (int.Parse(read[0].ToString()) == 1)
                {
                    PANELMENU PUs = new PANELMENU();
                    PUs.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos o el usuario no existe", "CONFIRME", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
