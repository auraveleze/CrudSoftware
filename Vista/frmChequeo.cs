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

namespace ProyectoSoftwareWeb.Vista
{
    public partial class frmChequeo : Form
    {
        public frmChequeo()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        private void tx_NombreC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
