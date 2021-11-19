using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareWeb.Modelo;

namespace ProyectoSoftwareWeb.Controlador
{
    class ctrChequeo
    {
        // Se crea un objeto a base de la clase con la conexion
        bdConexion conectandose = new bdConexion();

        public void CrearRegistroC()
        {
            conectandose.Conectar();
        }

        public void ActualizarRegistroC()
        {
            conectandose.Conectar();
        }

        public void BuscarRegistroC()
        {
            conectandose.Conectar();
        }

        public void EliminarRegistroC()
        {
            conectandose.Conectar();
        }

        public void MostrarRegistroC()
        {
            conectandose.Conectar();
        }

        public void LimpiarCajasC()
        {
            conectandose.Conectar();
        }
    }
}
