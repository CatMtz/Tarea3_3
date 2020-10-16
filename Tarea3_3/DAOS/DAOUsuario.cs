using Tarea3_3.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Tarea3_3.DAOS
{
    public class DAOUsuario
    {
        public List<Usuario> getAll()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();
                ConexionMySQL con = new ConexionMySQL();

                DataSet dat = con.LLenaComboGrid("SELECT * FROM Usuario" + ";");
                DataTable dt = dat.Tables[0];
                Usuario datos;
                foreach (DataRow r in dt.Rows)
                {
                    datos = new Usuario();
                    datos.IDUsuario = (int)r.ItemArray[0];
                    datos.Nombre = (String)r.ItemArray[1];
                    datos.Contraseña = (String)r.ItemArray[2];


                    lista.Add(datos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos del usuario");
            }
           
        }
        //Registrar Nuevo Usuario
        public bool registrar(Usuario obj)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "INSERT INTO Usuario(Nombre, Apellido, Username, Email, Password,Descripcion) "
                    + "VALUES (default,@Nombre, @Apellido, @Username, @Email, @Contraseña, @Descripcion)";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
                comando.CommandType = System.Data.CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                comando.Parameters.AddWithValue("@Apellido", obj.Apellido);
                comando.Parameters.AddWithValue("@Username", obj.Username);
                comando.Parameters.AddWithValue("@Email", obj.Email);
                comando.Parameters.AddWithValue("@Password", obj.Contraseña);
                comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                int regafectados = (int)comando.ExecuteNonQuery();
                conexion.Close();
                return (regafectados > 0);

            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo hacer el registro del usuario");
            }
           
        }

        //Verificar usuario registrado (LOGIN)
        public Usuario Verificarusuario(string email, string contraseña)
        {
            MySqlConnection conexion = null;
            try
            {
                conexion = new MySqlConnection(new ConexionMySQL().GetConnectionString());
                conexion.Open();
                String consulta = "SELECT *  FROM Usuario WHERE Username = @Username AND password = @Contraseña"+";";
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexion;
                comando.CommandText = consulta;
              
                comando.Parameters.AddWithValue("@Username", email);
                comando.Parameters.AddWithValue("@Password", contraseña);
                MySqlDataReader lector = comando.ExecuteReader();
                Usuario obtenerdatosusuario;
                if (lector.Read())
                {
                    obtenerdatosusuario = new Usuario();
                    obtenerdatosusuario.IDUsuario = lector.GetInt32("idusuario");
                    obtenerdatosusuario.Nombre = lector.GetString("Nombre");
                    obtenerdatosusuario.Apellido = lector.GetString("Apellidos");
                    obtenerdatosusuario.Email = lector.GetString("email");
                    obtenerdatosusuario.Descripcion = lector.GetString("tipousuario");
                    
                    return obtenerdatosusuario;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al autenticar");
            }
            finally
            {
                if (conexion != null)
                    conexion.Close();
            }
        }
    }
}