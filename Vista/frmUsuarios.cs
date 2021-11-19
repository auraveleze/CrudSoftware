using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSoftwareWeb.Modelo;
using ProyectoSoftwareWeb.Controlador;
using Npgsql;
using System.Data.SqlClient;

namespace ProyectoSoftwareWeb.Vista
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SalirU_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AnteriorU_Click(object sender, EventArgs e)
        {
            // Se crea un objeto para poder mostrarlo
            frmInicio v1 = new frmInicio();
            v1.Show();

            // Se refiere a este form, para esconderlo
            this.Hide();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void tx_NDocumentoU_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CrearU_Click(object sender, EventArgs e)
        {
            // Buscar para enviar una lista al metodo Agregar cuando sea del frmInformacion
            String var1 = tx_NDocumentoU.Text;
            String var2 = tx_NombreU.Text;
            String var3 = tx_UsuarioU.Text;
            String var4 = tx_ContraseñaU.Text;

            ctrUsuarios.CrearRegistroU(var1, var2, var3, var4);
            LimpiarCajasU();
        }

        private void btn_EliminarU_Click(object sender, EventArgs e)
        {
            string Doc = tx_NDocumentoU.Text;
            ctrUsuarios.EliminarRegistroU(Doc);
            LimpiarCajasU();
        }

        private void btn_BuscarU_Click(object sender, EventArgs e)
        {
            //NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            //String sql = "SELECT * FROM tabla WHERE NumDocumento = '@Doc';";

            //SqlCommand comando = new SqlCommand(sql, conn);
            //comando.Parameters.AddWithValue("@Doc", tx_NDocumentoU.Text);
            //conn.Open();
            //SqlDataReader reader = comando.ExcecuteReader();
        }

        public static DataSet Mostrar()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            conn.Open();
            DataSet datos = new DataSet();

            try
            {
                String sql = "SELECT * FROM tabla";

                // Permite crear un objeto en memoria cache para almacenar los datos pedidos
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(sql, conn); // Almacena los datos

                add.Fill(datos); // Pone los datos en el dataset
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al interactuar con la base de datos");
            }
            return datos;
        }

        public  static void MostarDatosTabla()
        {

            try
            {
                // crear antes la clase MetodosBase
                //data_gv1.DataSource = Mostrar().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos, " + ex.Message);
            }

        }


        public void LimpiarCajasU()
        {
            tx_NDocumentoU.Text = "";
            tx_NombreU.Text = "";
            tx_UsuarioU.Text = "";
            tx_ContraseñaU.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
