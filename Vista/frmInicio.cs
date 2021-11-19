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

namespace ProyectoSoftwareWeb.Vista
{
    public partial class frmInicio : Form
    {
        // Se crea un objeto a base de la clase con la conexion
        bdConexion conectandose = new bdConexion();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btn_SalirI_Click_1(object sender, EventArgs e)
        {
            conectandose.Desconectar();
            System.Windows.Forms.MessageBox.Show("Conexion finalizada con exito");
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Se crea un objeto para poder mostrarlo
            frmInformacion v2 = new frmInformacion();
            v2.Show();

            // Se refiere a este form, para esconderlo
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Se crea un objeto para poder mostrarlo
            frmDocumentos v4 = new frmDocumentos();
            v4.Show();

            // Se refiere a este form, para esconderlo
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Se crea un objeto para poder mostrarlo
            frmUsuarios v5 = new frmUsuarios();
            v5.Show();

            // Se refiere a este form, para esconderlo
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Se crea un objeto para poder mostrarlo
            frmChequeo v6 = new frmChequeo();
            v6.Show();

            // Se refiere a este form, para esconderlo
            this.Hide();
        }

        private void frmInicio_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            conectandose.Conectar();
        }
    }
}
