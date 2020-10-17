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

namespace Tarea3_3
{
    public partial class Mis_Mensajes : Form
    {
        Menu menu = new Menu();
       public static int idusu = 0;
        public Mis_Mensajes()
        {
            InitializeComponent();
        }
        public Mis_Mensajes(int id)
        {
            idusu = id;
        }

        private void Mis_Mensajes_Load(object sender, EventArgs e)
        {
            grvMisMensajes.DataSource = null;
            grvMisMensajes.DataSource = new DAOMensaje().getOneEnc(""+idusu);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }

        private void btnDesenc_Click(object sender, EventArgs e)
        {
            grvMisMensajes.DataSource = null;
            grvMisMensajes.DataSource = new DAOMensaje().getOne("" + idusu);

        }
    }
}
