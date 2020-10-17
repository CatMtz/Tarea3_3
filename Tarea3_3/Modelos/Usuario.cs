using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3_3.Modelos
{
   public class Usuario
    {

        public int IDUsuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
        public String Contraseña { get; set; }
        public String Descripcion { get; set; }


        public Usuario() { }
        public Usuario(String nom, String ape, String user, String ema, String cont, String desc)
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.Username = user;
            this.Email = ema;
            this.Contraseña = cont;
            this.Descripcion = desc;
        }

    }
}
