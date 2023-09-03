using Projecto_YII.Projecto.YII.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projecto_YII.Projecto.YII.View
{
    public partial class FrmLogin : Form
    {
        #region Comandos

        /*Comandos para mover e arrastar o programa PanelTop
         *Adicionar o evento MouseDown
         */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int lParam);

        #endregion

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEntrarLogin_Click(object sender, EventArgs e)
        {
            string user = textBoxNomeLogin.Text;
            string pass = textBoxPasswordLogin.Text;

            UsuarioDAO usuarioDAO_ = new UsuarioDAO();

            if ((usuarioDAO_.Login(user, pass) == true))
            {
                this.Hide();
            }
        }
    }
}
