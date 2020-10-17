using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_3
{
    public partial class Menu : Form
    {
        iniciarSesion iniciar = new iniciarSesion();
        public static int idusuario;

        public Menu()
        {
            InitializeComponent();
          
        }
        public Menu(int id)
        {
            idusuario = id;
        }
        private void Menu_Load(object sender, EventArgs e)
        {
         
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Añadir_Mensaje nuevo = new Añadir_Mensaje();
            nuevo.Show();
            this.Hide();
        }

        private void btnMisM_Click(object sender, EventArgs e)
        {
            Mis_Mensajes mis = new Mis_Mensajes();
            new Mis_Mensajes(idusuario);
            mis.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal pri = new Principal();
            pri.Show();
            this.Dispose();
        }

       
    }
}
