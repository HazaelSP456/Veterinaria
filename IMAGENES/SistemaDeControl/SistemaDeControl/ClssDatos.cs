using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaDeControl
{
    class ClssDatos
    {
       public SqlConnection conectar = new SqlConnection("Data Source=DESKTOP-IDJCKBS\\MSSQLSERVER01;Initial Catalog=Pboleta;Integrated Security=True");
        private SqlCommand comando = new SqlCommand();

        CONEXION con = new CONEXION();
        public void GuardarAlumno(Form from)
        {
            if (((TextBox)from.Controls["curp_txt"]).Text == "" || ((TextBox) from.Controls["appalum"]).Text =="" || ((TextBox)from.Controls["apmalum"]).Text == "" || ((TextBox)from.Controls["nomalum"]).Text == "" || ((ComboBox)from.Controls["sexo"]).Text == "" || ((TextBox)from.Controls["nacimientoalum"]).Text == "" || ((TextBox)from.Controls["edadalum"]).Text == "" || ((TextBox)from.Controls["alergias"]).Text == "" || ((ComboBox)from.Controls["tiposangre"]).Text == "" || ((TextBox)from.Controls["grado"]).Text == "")
            {
                MessageBox.Show("Favor de llenar todas las casillas", "AVISO | The Team 6", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!Existe(((TextBox)from.Controls["curp_txt"]).Text))
                {
                    if (Insertar(((TextBox)from.Controls["curp_txt"]).Text, ((TextBox)from.Controls["appalum"]).Text, ((TextBox)from.Controls["apmalum"]).Text, ((TextBox)from.Controls["nomalum"]).Text, ((ComboBox)from.Controls["sexo"]).Text, ((TextBox)from.Controls["nacimientoalum"]).Text, ((TextBox)from.Controls["edadalum"]).Text, ((TextBox)from.Controls["alergias"]).Text, ((ComboBox)from.Controls["tiposangre"]).Text, ((TextBox)from.Controls["grado"]).Text))
                    {
                        MessageBox.Show("Alumno Registrado(a)", "AVISO | The Team 6");
                        //((DataGridView)from.Comtrols["dataGridAlumnos"]).DataSource = MostrarDatos();
                        
                        ((TextBox)from.Controls["appalum"]).Text = "";
                        ((TextBox)from.Controls["apmalum"]).Text = "";
                        ((TextBox)from.Controls["nomalum"]).Text = "";
                        ((ComboBox)from.Controls["sexo"]).Text = "";
                        ((TextBox)from.Controls["nacimientoalum"]).Text = "";
                        ((TextBox)from.Controls["edadalum"]).Text = "";
                        ((TextBox)from.Controls["alergias"]).Text = "";
                        ((ComboBox)from.Controls["tiposangre"]).Text = "";
                        ((TextBox)from.Controls["grado"]).Text = "";
                    }
                    else
                        MessageBox.Show("No se ha podido registrar alumno", "Equipo Franky", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El alumno ya existe", "Equipo Franky", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GuardarPadreTutor(Form from)
        {
            if (((TextBox)from.Controls["apppt"]).Text == "" || ((TextBox)from.Controls["apmpt"]).Text == "" || ((TextBox)from.Controls["nompt"]).Text == "" || ((TextBox)from.Controls["celpt"]).Text == "" || ((TextBox)from.Controls["telefonopt"]).Text == "" || ((TextBox)from.Controls["callept"]).Text == "" || ((TextBox)from.Controls["coloniapt"]).Text == "" || ((TextBox)from.Controls["cppt"]).Text == "" || ((TextBox)from.Controls["numcasapt"]).Text == "" || ((TextBox)from.Controls["correopt"]).Text == "")
            {
                MessageBox.Show("Favor de llenar todas las casillas", "Equipo Franky", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                    if (Insertar_tutor(((TextBox)from.Controls["curp_txt"]).Text, ((TextBox)from.Controls["apppt"]).Text, ((TextBox)from.Controls["apmpt"]).Text, ((TextBox)from.Controls["nompt"]).Text, ((TextBox)from.Controls["celpt"]).Text, ((TextBox)from.Controls["telefonopt"]).Text, ((TextBox)from.Controls["callept"]).Text, ((TextBox)from.Controls["coloniapt"]).Text, ((TextBox)from.Controls["cppt"]).Text, ((TextBox)from.Controls["numcasapt"]).Text, ((TextBox)from.Controls["correopt"]).Text))
                    {
                        MessageBox.Show("Padre/Tutor Registrado(a)",  "Equipo Franky");
                    //((DataGridView)from.Comtrols["dataGridAlumnos"]).DataSource = MostrarDatos();
                   // ((TextBox)from.Controls["curp_txt"]).Text = "";
                    ((TextBox)from.Controls["apppt"]).Text = "";
                        ((TextBox)from.Controls["apmpt"]).Text = "";
                        ((TextBox)from.Controls["nompt"]).Text = "";
                        ((TextBox)from.Controls["celpt"]).Text = "";
                        ((TextBox)from.Controls["telefonopt"]).Text = "";
                        ((TextBox)from.Controls["callept"]).Text = "";
                        ((TextBox)from.Controls["coloniapt"]).Text = "";
                        ((TextBox)from.Controls["cppt"]).Text = "";
                        ((TextBox)from.Controls["numcasapt"]).Text = "";
                        ((TextBox)from.Controls["correopt"]).Text = "";
                    }
                    else
                        MessageBox.Show("No se ha podido registrar padre o tutor", "Equipo Franky", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }
        public static bool Existe (string CURPALUMNO)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IDJCKBS\\MSSQLSERVER01;Initial Catalog=Pboleta;Integrated Security=True"))
            {
                string query = "Select Count(*) From Alumno Where CURP=@CURP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("CURP", CURPALUMNO);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }
        public bool Insertar (string Curp_txt, string appalum, string apmalum, string nomalum, string sexo, string nacimientoalumno, string edad, string alergias, string tiposangre, string grado)
        {
            conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Alumno values ('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}',{9})", new string[] { Curp_txt, appalum, apmalum, nomalum, sexo, nacimientoalumno, edad, alergias, tiposangre, grado }), conectar);
            int filasafectadas = cmd.ExecuteNonQuery();
            conectar.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public bool Insertar_tutor(string Curp_txt, string apppt, string apmpt, string nompt, string celupt, string telefonopt, string callept, string coloniapt, string cppt, string numcasapu, string correopt)
        {
            conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Padre_Tutor values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}')", new string[] {Curp_txt,apppt, apmpt, nompt, celupt,telefonopt, callept, coloniapt,cppt,numcasapu,correopt }), conectar);
            int filasafectadas = cmd.ExecuteNonQuery();
            conectar.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public DataSet ds;
        //login color1 = new login();
        //Almacen

        public DataTable MostrarDatos()
        {
            conectar.Open();
            SqlCommand cmd = new SqlCommand("select * from Alumno", conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Alumno");
            conectar.Close();
            return ds.Tables["Alumno"];
        }

        public void Mostrar (Form form, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = ((DataGridView)form.Controls["dataGridAlumno"]).Rows[e.RowIndex];
            ((TextBox)form.Controls["curp_txt"]).Text = Convert.ToString(fila.Cells[0].Value);
            ((TextBox)form.Controls["appalum"]).Text = Convert.ToString(fila.Cells[1].Value);
            ((TextBox)form.Controls["apmalum"]).Text = Convert.ToString(fila.Cells[2].Value);
            ((TextBox)form.Controls["nomalum"]).Text = Convert.ToString(fila.Cells[3].Value);
            ((ComboBox)form.Controls["sexo"]).Text = Convert.ToString(fila.Cells[4].Value);
            ((TextBox)form.Controls["nacimientoalum"]).Text = Convert.ToString(fila.Cells[5].Value);
            ((TextBox)form.Controls["edadalum"]).Text = Convert.ToString(fila.Cells[6].Value);
            ((TextBox)form.Controls["alergias"]).Text = Convert.ToString(fila.Cells[7].Value);
            ((ComboBox)form.Controls["tiposangre"]).Text = Convert.ToString(fila.Cells[8].Value);
            ((TextBox)form.Controls["grado"]).Text = Convert.ToString(fila.Cells[9].Value);
            ((TextBox)form.Controls["curp_txt"]).Enabled = false;
        }
        public void Load (Form form)
        {
            ((DataGridView)form.Controls["dataGridAlumno"]).AllowUserToAddRows=false;
            ((DataGridView)form.Controls["dataGridAlumno"]).DataSource = MostrarDatos();
        }
        public DataTable Buscar(string Curp)
        {
            conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from Alumno Where curp like '%{0}%'", Curp), conectar);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Alumno");
            conectar.Close();
            return ds.Tables["Alumno"];
        }
        public void BuscarAlumno( Form form)
        {
            if (((TextBox)form.Controls["buscar_txt"]).Text != "") ((DataGridView)form.Controls["dataGridAlumno"]).DataSource = Buscar(((TextBox)form.Controls["buscar_txt"]).Text);
            else ((DataGridView)form.Controls["dataGridAlumno"]).DataSource = MostrarDatos();
        }
        public bool Modificar(string Curp_txt, string appalum, string apmalum, string nomalum, string sexo, string nacimientoalum, string edadalum, string alergias, string tiposangre, string grado)
        {
            conectar.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Alumno set appalum='{0}',apmalum='{1}', nomalum='{2}',sexo='{3}',naciminetoalum='{4}',edadalum={5},alergias='{6}',tiposangre='{7}',grado={8} where Curp_txt ='{9}' ", new string[] {appalum,apmalum,nomalum,sexo,nacimientoalum,edadalum,alergias,tiposangre,grado }), conectar);
            int filasafectadas = cmd.ExecuteNonQuery();
            conectar.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
        public void ModificarAlumno(Form form)
        {
            if (((TextBox)form.Controls["appalum"]).Text == "" || ((TextBox)form.Controls["apmalum"]).Text == "" || ((TextBox)form.Controls["nomalum"]).Text == "" || ((TextBox)form.Controls["sexo"]).Text == "" || ((TextBox)form.Controls["nacimentoalum"]).Text == "" || ((TextBox)form.Controls["edadalum"]).Text == "" || ((TextBox)form.Controls["alergias"]).Text == "" || ((TextBox)form.Controls["tiposangre"]).Text == "" || ((TextBox)form.Controls["grado"]).Text == "")
            {
                MessageBox.Show("No puede dejar casillas vacias", "Equipo Franky",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Modificar(((TextBox)form.Controls["curp_txt"]).Text, ((TextBox)form.Controls["appalum"]).Text, ((TextBox)form.Controls["apmalum"]).Text, ((TextBox)form.Controls["nomalum"]).Text, ((ComboBox)form.Controls["sexo"]).Text, ((TextBox)form.Controls["nacimientoalum"]).Text, ((TextBox)form.Controls["edadalum"]).Text, ((TextBox)form.Controls["alergias"]).Text, ((ComboBox)form.Controls["tiposangre"]).Text, ((TextBox)form.Controls["grado"]).Text))
                {
                    MessageBox.Show("Datos Modificados");
                    ((DataGridView)form.Controls["dataGridAlumno"]).DataSource = MostrarDatos();
                }
                else MessageBox.Show("No se ha modificado el/los datos.", "Equipo Franky", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        public string  appalum { get; set; }
        public string  apmalum { get; set; }
        public string  nomalum { get; set; }
        public string  sexo { get; set; }
        public string  nacimientoalum{ get; set; }
        public string  edadalum { get; set; }
        public string  alergias{ get; set; }
        public string  tiposangre{ get; set; }
        public string  grado{ get; set; }
        public string  curp { get; set; }


        public string apppt { get; set; }
        public string apmpt { get; set; }
        public string nompt { get; set; }
        public string celpt { get; set; }
        public string telefonopt{ get; set; }
        public string callept { get; set; }
        public string coloniapt { get; set; }
        public string cppt { get; set; }
        public string numcasapt { get; set; }
        public string correopt { get; set; }
        public void EditarAlumnos()
        {
            comando.Connection = con.AbrirConexion();
            comando.CommandText= "update Alumno set appalum='"+ appalum+"', apmalum='"+apmalum+"', noumalum='"+nomalum+"',sexo='"+sexo+"',nacimientpalum='"+nacimientoalum+"',edadalum="+edadalum+",alergias='"+alergias+"',tiposangre='"+tiposangre+"',grado="+grado+" where curp='"+curp+"'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            con.CerrarConexion();
        }
        public void EditarPadreTutor()
        {
            comando.Connection = con.AbrirConexion();
            comando.CommandText = "update Padre_Tutor set apppt='" + apppt + "', apmpt='" + apmpt + "', nompt='" + nompt + "',celpt='" + celpt + "',telefonopt='" + telefonopt + "',callept=" + callept + ",coloniapt='" + coloniapt + "',cppt='" + cppt+ "',numcasapt=" + numcasapt +"',correopt='"+correopt+"',  where curp='" + curp + "'";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            con.CerrarConexion();
        }
    }
}
