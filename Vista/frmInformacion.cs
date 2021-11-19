using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSoftwareWeb.Controlador;

namespace ProyectoSoftwareWeb.Vista
{
    public partial class frmInformacion : Form
    {
        // Se crea un objeto a base de la clase con la conexion
        ctrInformacion conectar = new ctrInformacion();

        public frmInformacion()
        {
            InitializeComponent();
        }

        private void frmInformacion_Load(object sender, EventArgs e)
        {

        }

        private void buttonCerrar1_Click(object sender, EventArgs e)
        {
            // Se crea un objeto para poder mostrarlo
            frmInicio v1 = new frmInicio();
            v1.Show();

            // Se refiere a este form, para esconderlo
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conectar.Cerrar();
            Application.Exit();
        }

        private void btn_BuscarI_Click(object sender, EventArgs e)
        {

        }
    }
}
