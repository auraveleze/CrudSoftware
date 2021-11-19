using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ProyectoSoftwareWeb.Modelo;

namespace ProyectoSoftwareWeb.Controlador
{
    class ctrDocumentos
    {
        // Se crea un objeto a base de la clase con la conexion
        static bdConexion cadena = new bdConexion();

        public static void CrearRegistroD(String Documento, String Ced, String Sis, String Eps, String CEps, String CPre, String CCon, String Vac)
        {
            //cadena.Conectar();
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            conn.Open();
            string sentencia = "INSERT INTO public.Documentos VALUES ('" + Documento + "', '" + Ced + "', '" + Sis + "', '" + Eps + "', '" + CEps + "', '"+CPre+"', '" +CCon+ "', '" +Vac+ "');";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sentencia, conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Informacion agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro, " + ex.Message);
            }
            cadena.Desconectar();
        }

        public static void ActualizarRegistroD(String Documento, String Ced, String Sis, String Eps, String CEps, String CPre, String CCon, String Vac)
        {
            //cadena.Conectar();
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            conn.Open();
            string sentencia = "INSERT INTO public.Documentos VALUES ('" + Documento + "', '" + Ced + "', '" + Sis + "', '" + Eps + "', '" + CEps + "', '" + CPre + "', '" + CCon + "', '" + Vac + "');";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sentencia, conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Informacion agregada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro, " + ex.Message);
            }
            cadena.Desconectar();
        }

        public static void EliminarRegistroD(string Documento)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            String sentencia = "DELETE FROM public.Documentos WHERE NumDocumento = '" + Documento + "';";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sentencia, conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Informacion eliminada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro, " + ex.Message);
            }
        }
    }
}
