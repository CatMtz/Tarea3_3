using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea3_3.DAOS;
using Tarea3_3.Modelos;

namespace Tarea3_3
{
    public partial class Añadir_Mensaje : Form
    {
        Menu menu = new Menu();
        public static int idusu = 0;
        public Añadir_Mensaje()
        {
            InitializeComponent();
        }
        public Añadir_Mensaje(int id)
        {
            idusu = id;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if(txtMensaje.Text.Length>10 && txtMensaje.Text.Length <= 50)
            {
                DAOMensaje nuevo = new DAOMensaje();
                Mensaje men = new Mensaje();
                men.Mensajee = txtMensaje.Text;
                men.IdUsuario = idusu;
                nuevo.insertarM(men);
                txtMensaje.Text = "";
            }else
            {
                MessageBox.Show("La longitud del mensaje debe ser mayor a 10 y menor a 50 caracteres");
            }
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
