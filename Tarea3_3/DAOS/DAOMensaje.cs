using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea3_3.Modelos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Tarea3_3.DAOS
{
    public class DAOMensaje
    {

        public List<Mensaje> getOne(String idusuario)
        {
            try
            {
                List<Mensaje> lista = new List<Mensaje>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT CAST( aes_decrypt(UNHEX(Mensaje), '#$%&1234kkomg') AS CHAR) AS Mensaje,IDUsuario"+
                    " FROM Mensajes" + " where IDUsuario="+idusuario+ ";");
                DataTable dt = dat.Tables[0];
                Mensaje datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Mensaje();
                    datos.Mensajee = (String)r.ItemArray[0];
                    datos.IdUsuario = (int)r.ItemArray[1];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del usuario");
            }

        }
        public List<Mensaje> getOneEnc(String idusuario)
        {
            try
            {
                List<Mensaje> lista = new List<Mensaje>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT Mensaje,IDUsuario FROM Mensajes" + " where IDUsuario=" + idusuario + ";");
                DataTable dt = dat.Tables[0];
                Mensaje datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Mensaje();
                    datos.Mensajee = (String)r.ItemArray[0];
                    datos.IdUsuario = (int)r.ItemArray[1];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del usuario");
            }

        }


        public bool insertarM(Mensaje obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO mensajes "+
                    "VALUES(default,HEX(aes_encrypt(@Mensaje,'#$%&1234kkomg')),@IDUsuario)" + ";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Mensaje", obj.Mensajee);
                comando.Parameters.AddWithValue("@IDUsuario", obj.IdUsuario);
               
                int regafectados = comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del usuario");
            }

        }

    }
}
