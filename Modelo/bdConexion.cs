using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProyectoSoftwareWeb.Modelo
{
    class bdConexion
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");

        public void Conectar()
        {
            try
            {
                conn.Open();
                System.Windows.Forms.MessageBox.Show("Conexion realizada con exito");
            } 
            catch (Exception e)
            {
                MessageBox.Show("Conexion rechazada, " + e.Message);
            }
        }

        public void Desconectar()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    MessageBox.Show("Conexion finalizada con exito");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No es posible desconectar la base de datos, " + e.Message);
            }
        }
    }
}
