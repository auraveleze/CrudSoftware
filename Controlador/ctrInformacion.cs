using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareWeb.Controlador;
using ProyectoSoftwareWeb.Modelo;

namespace ProyectoSoftwareWeb.Controlador
{
    public class ctrInformacion
    {
        // Se crea un objeto a base de la clase con la conexion
        bdConexion conectandose = new bdConexion();

        public void CrearRegistroI()
        {
            conectandose.Conectar();
        }

        public void ActualizarRegistroI()
        {
            conectandose.Conectar();
        }

        public void BuscarRegistroI()
        {
            conectandose.Conectar();
        }

        public void EliminarRegistroI()
        {
            conectandose.Conectar();
        }

        public void MostrarRegistroI()
        {
            conectandose.Conectar();
        }

        public void LimpiarCajasI()
        {
            conectandose.Conectar();
        }

        public void Cerrar()
        {
            conectandose.Desconectar();
            System.Windows.Forms.MessageBox.Show("Conexion finalizada con exito");
        }
    }
}
