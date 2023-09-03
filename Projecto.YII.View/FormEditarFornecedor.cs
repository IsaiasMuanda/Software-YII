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
    public partial class FormEditarFornecedor : Form
    {
        #region Comandos
        /*Comandos para mover e arrastar o programa PanelTop
         *Adicionar o evento MouseDown
         */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int lParam);

        FormTelaInicial formTelaInicial_obj = new FormTelaInicial();
        #endregion

        public FormEditarFornecedor()
        {
            InitializeComponent();
        }

        #region Eventos Gerais

        /*Evento do MouseDown do panelTop
        * Evento para arrastar o programa com o mouse
        */
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBoxFecharCL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxFecharFrn_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFecharFrn.Size = new Size(22, 22);
        }

        private void pictureBoxFecharFrn_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFecharFrn.Size = new Size(25, 25);
        }
        //Evento Click
        private void buttonGuardarEdicaoForn_Click(object sender, EventArgs e)
        {
            FormFornecedores formFornecedores_ = new FormFornecedores();
            FornecedorDAO fornecedorDAO_ = new FornecedorDAO();
            FornecedorModel fornecedorModel_ = new FornecedorModel(textBoxEditarNomeForn.Text, textBoxEditarEnderecoForn.Text, maskedTextBoxEditarTelefoneForn.Text, textBoxEditarEmailFOrn.Text);


            fornecedorModel_.id_fornecedor = int.Parse(labelEditarFornecedorID.Text);
            fornecedorDAO_.EditarFornecedores(fornecedorModel_);

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
