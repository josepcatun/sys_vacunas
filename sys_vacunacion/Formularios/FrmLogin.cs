using sys_vacunacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys_vacunacion
{
    public partial class FrmLogin : Form
    {

        readonly Formularios.FrmMain FrmMain = new Formularios.FrmMain();

        public FrmLogin()
        {
            InitializeComponent();
        }      

        private void BtnSalirLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnCancelarLogin_Click(object sender, EventArgs e)
        {
            TxtUsuario.Text = "";
            TxtPassword.Text= "";
            TxtUsuario.Focus();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {                      
            FrmMain.ShowDialog();
        }
    }
}
