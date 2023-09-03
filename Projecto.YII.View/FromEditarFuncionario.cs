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
    public partial class FromEditarFuncionario : Form
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

        public FromEditarFuncionario()
        {
            InitializeComponent();
        }
        #region Eventos Do Formulário
        //evento click para fechar o formulario
        private void pictureBoxFecharP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Evento do MouseDown do panelTop
        * Evento para arrastar o programa com o mouse
        */
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*Eventos
         * MouseEnter
         * MouseLeave
         * PictureBoxFecharP
         */
        private void pictureBoxFecharP_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFecharP.Size = new Size(22, 22);
        }

        private void pictureBoxFecharP_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFecharP.Size = new Size(25, 25);
        }
        private void buttonGuardarEdicaoFunc_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionarioModel_ = new FuncionarioModel(int.Parse(labeICod_EditarFunc.Text), textBoxEditarNomeFuncionario.Text, textBoxEditarEnderecoFuncionario.Text, maskedTextBoxEditarTelefoneFuncionario.Text, textBoxEditarEmailFuncionario.Text);
            funcionarioModel_.id_cargo = Convert.ToInt32(comboBoxEditarCargo.SelectedValue.ToString());
            funcionarioModel_.id_funcionário = int.Parse(labeICod_EditarFunc.Text);
            new FuncionarioDAO().EditarFuncionario(funcionarioModel_);
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
