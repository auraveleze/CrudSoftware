using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareWeb.Modelo;
using ProyectoSoftwareWeb.Vista;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoSoftwareWeb.Controlador
{
    class ctrUsuarios
    {
        // Se crea un objeto a base de la clase con la conexion
        static bdConexion cadena = new bdConexion();

        public static void CrearRegistroU(String Documento, String Nombre, String Usuario, String Contraseña)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            conn.Open();
            String sentencia = "INSERT INTO public.Usuarios (NumDocumento, Nombre, Usuario, Contraseña) VALUES ('" + Documento + "', '" + Nombre + "', '" + Usuario + "', '" + Contraseña + "');";

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

        public static void ActualizarRegistroU(String Documento, String Nombre, String Usuario, String Contraseña)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            conn.Open();
            String sentencia = "INSERT INTO Usuarios SET Nombre = '" +Nombre+ "', Usuario = '" +Usuario + "', Contraseña = '" + Contraseña+ "' WHERE NumDocumento = '" + Documento + "';";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sentencia, conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Informacion actualizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro, " + ex.Message);
            }
            cadena.Desconectar();
        }

        public static void EliminarRegistroU(string Documento)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server= localhost; Port= 5432; Database= Secretaria; User Id= postgres; Password= 13524;");
            conn.Open();
            String sentencia = "DELETE FROM Usuarios WHERE NumDocumento = '" + Documento + "';";

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
            cadena.Desconectar();
        }
    }
}
