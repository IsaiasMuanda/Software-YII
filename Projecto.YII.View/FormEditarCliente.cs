using Projecto_YII.Projecto.YII.DAO;
using Projecto_YII.Projecto.YII.Model;
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

namespace Projecto_YII.Projecto.YII.View
{
    public partial class FormEditarCliente : Form
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
        public FormEditarCliente()
        {
            InitializeComponent();
        }
        #region Eventos Gerais

        /*Evento do MouseDown do panelTop
        * Evento para arrastar o programa com o mouse
        */
        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*Eventos
         * MouseEnter
         * MouseLeave
         * PictureBoxFecharCL
         */
        private void pictureBoxFecharCL_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFecharCL.Size = new Size(22, 22);

        }
        private void pictureBoxFecharCL_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFecharCL.Size = new Size(25, 25);
        }

        private void pictureBoxFecharCL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //EVento click
        private void buttonGuardarEdicaoCl_Click(object sender, EventArgs e)
        {
            FormClientes formClientes_ = new FormClientes();
            ClienteDAO clienteDAO_ = new ClienteDAO();
            ClienteModel clienteModel_ = new ClienteModel(textBoxEditarNomeCliente.Text, maskedTextBoxEditarTelefoneCliente.Text, textBoxEditarEnderecoCliente.Text);


            clienteModel_.id_cliente = int.Parse(textBoxID_EditarCl.Text);
            clienteDAO_.EditarClientes(clienteModel_);

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

    }
}
