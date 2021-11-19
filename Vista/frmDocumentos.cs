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
    public partial class frmDocumentos : Form
    {
        public frmDocumentos()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCerrar1_Click(object sender, EventArgs e)
        {
            // Se crea un objeto para poder mostrarlo
            frmInicio v1 = new frmInicio();
            v1.Show();

            // Se refiere a este form, para esconderlo
            this.Hide();
        }

        private void frmDocumentos_Load(object sender, EventArgs e)
        {

        }

        private void btn_CrearD_Click(object sender, EventArgs e)
        {
            // Buscar para enviar una lista al metodo Agregar cuando sea del frmInformacion
            String var1 = tx_NDocumentoD.Text;
            String var2 = tx_CedulaD.Text;
            String var3 = tx_SisbenD.Text;
            String var4 = tx_EpsD.Text;
            String var5 = tx_CPrenatalD.Text;
            String var6 = tx_CCrecimientoD.Text;
            String var7 = tx_RegistroD.Text;
            String var8 = tx_VacunasD.Text;

            ctrDocumentos.CrearRegistroD(var1, var2, var3, var4, var5, var6, var7, var8);
        }

        private void btn_ActualizarD_Click(object sender, EventArgs e)
        {
            // Buscar para enviar una lista al metodo Agregar cuando sea del frmInformacion
            String var1 = tx_NDocumentoD.Text;
            String var2 = tx_CedulaD.Text;
            String var3 = tx_SisbenD.Text;
            String var4 = tx_EpsD.Text;
            String var5 = tx_CPrenatalD.Text;
            String var6 = tx_CCrecimientoD.Text;
            String var7 = tx_RegistroD.Text;
            String var8 = tx_VacunasD.Text;

            ctrDocumentos.ActualizarRegistroD(var1, var2, var3, var4, var5, var6, var7, var8);
        }

        private void btn_EliminarD_Click(object sender, EventArgs e)
        {
            String doc = tx_NDocumentoD.Text;
            ctrDocumentos.EliminarRegistroD(doc);
        }
    }
}
