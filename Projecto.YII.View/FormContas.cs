using Projecto_YII.Projecto.YII.DAO;
using Projecto_YII.Projecto.YII.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_YII.Projecto.YII.View
{
    public partial class FormContas : Form
    {
        UsuarioDAO usuarioDAO_ = new UsuarioDAO();
        Repositorio Repositorio_ = new Repositorio();


        public FormContas()
        {
            InitializeComponent();
        }

        #region Eventos Gerais

        //Evento Load
        private void FormContas_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO_ = new FuncionarioDAO();
            comboBoxFuncionario.DataSource = funcionarioDAO_.ListarFuncionarios();
            comboBoxFuncionario.DisplayMember = "Nome Completo";
            comboBoxFuncionario.ValueMember = "Código";

            dataGridViewUsuario.DataSource = usuarioDAO_.ListarUser();
            Repositorio_.TamanhoColunas(dataGridViewUsuario, "Tipo De Acesso", 240);
            Repositorio_.TamanhoColunas(dataGridViewUsuario, "Nome De Usuário", 180);

        }
        //Cadastrar User
        private void buttonCriarConta_Click_1(object sender, EventArgs e)
        {
            UsuarioModel usuarioModel_ = new UsuarioModel(int.Parse(comboBoxFuncionario.SelectedValue.ToString()), textBoxNomeUser.Text, textBoxPassword.Text, comboBoxAcesso.Text);
            usuarioDAO_.CadastrarUser(usuarioModel_);
        }
        //Captura Dados do DataGridView
        private void dataGridViewUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Repositorio_.Capturar(labelUserID, dataGridViewUsuario, 0);
            Repositorio_.Capturar(comboBoxFuncionario, dataGridViewUsuario, 1);
            Repositorio_.Capturar(textBoxNomeUser, dataGridViewUsuario, 2);
            Repositorio_.Capturar(comboBoxAcesso, dataGridViewUsuario, 3);

            buttonCriarConta.Enabled = false;

            tabControlContas.SelectedTab = tabPage1;
        }
        //Editar
        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioModel_ = new UsuarioModel(textBoxNomeUser.Text, comboBoxAcesso.Text);
            usuarioModel_.id_usuario = int.Parse(labelUserID.Text);
            usuarioDAO_.EditarUser(usuarioModel_);
        }
        //Remover
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            UsuarioModel usuarioModel_ = new UsuarioModel();
            usuarioModel_.id_usuario = int.Parse(labelUserID.Text);

            new UsuarioDAO().ExcluirUser(usuarioModel_);
        }
        //Limpar
        private void pictureBoxLimpar_Click(object sender, EventArgs e)
        {
            textBoxNomeUser.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            labelUserID.Text = string.Empty;
            comboBoxAcesso.Text = string.Empty;
            comboBoxFuncionario.Text = string.Empty;
        }
        #endregion

    }
}
