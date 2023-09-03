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
    public partial class FormFornecedores : Form
    {
        #region Comandos
        FormTelaInicial formTelaInicial_obj = new FormTelaInicial();
        Repositorio repositorio_ = new Repositorio();

        #endregion
        public FormFornecedores()
        {
            InitializeComponent();
        }

        #region Metodos Gerais

        public void TamanhoColunas(string n, int tamanho)
        {
            if (dataGridViewFornecedores.Columns.Contains(n))
            {
                dataGridViewFornecedores.Columns[n].Width = tamanho;
            }
        }
        #endregion

        #region Eventos Gerais
        private void buttonEditarForn_Click(object sender, EventArgs e)
        {
            FormEditarFornecedor formEditarFornecedor_ = new FormEditarFornecedor();
            formTelaInicial_obj.AbrirFormulárioExtra(formEditarFornecedor_, "formEditarFornecedor_obj");

            repositorio_.Capturar(formEditarFornecedor_.labelEditarFornecedorID, dataGridViewFornecedores, 0);
            repositorio_.Capturar(formEditarFornecedor_.textBoxEditarNomeForn, dataGridViewFornecedores, 1);
            repositorio_.Capturar(formEditarFornecedor_.textBoxEditarEnderecoForn, dataGridViewFornecedores, 2);
            repositorio_.Capturar(formEditarFornecedor_.maskedTextBoxEditarTelefoneForn, dataGridViewFornecedores, 3);
            repositorio_.Capturar(formEditarFornecedor_.textBoxEditarEmailFOrn, dataGridViewFornecedores, 4);
        }

        //Evento click para cadastrar fornecedores
        private void buttonGuardarForn_Click(object sender, EventArgs e)
        {
            FornecedorModel fornecedorModel_ = new FornecedorModel(textBoxNomeForn.Text, textBoxEnderecoForn.Text, maskedTextBoxTelefoneFOrn.Text, textBoxEmailFornec.Text);
            FornecedorDAO fornecedorDAO_ = new FornecedorDAO();
            fornecedorDAO_.CadastrarFornecedores(fornecedorModel_);
        }

        //Evento load para carregar os dados no DataGridViewFornecedores
        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDAO_ = new FornecedorDAO();
            dataGridViewFornecedores.DataSource = fornecedorDAO_.ListarFornecedores();
            //Ajustando o tamanho das Colunas do DataGridView
            TamanhoColunas("Fornecedor", 250);
            TamanhoColunas("Telefone", 200);
            TamanhoColunas("Endereço", 300);
            TamanhoColunas("Email", 240);
        }
        //Evento click para remover fornecedores
        private void buttonRemoverForn_Click(object sender, EventArgs e)
        {
            repositorio_.Capturar(labelFornecedorID, dataGridViewFornecedores, 0);

            FornecedorModel fornecedorModel_ = new FornecedorModel();
            fornecedorModel_.id_fornecedor = int.Parse(labelFornecedorID.Text);

            FornecedorDAO fornecedorDAO_ = new FornecedorDAO();
            if (MessageBox.Show("Excluir o Fornecedor?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                fornecedorDAO_.ExcluirFornecedor(fornecedorModel_);
                labelFornecedorID.Text = "";
                dataGridViewFornecedores.DataSource = fornecedorDAO_.ListarFornecedores();
            }
            else
            {
                MessageBox.Show("Operação Cancelada!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Evento keypress para pesquisar fornecedores
        private void textBoxPesqForn_KeyPress(object sender, KeyPressEventArgs e)
        {
            FornecedorDAO fornecedorDAO_ = new FornecedorDAO();
            string n = "%" + textBoxPesqForn.Text + "%";
            dataGridViewFornecedores.DataSource = fornecedorDAO_.PesquisarPorNomeAprox(n);
        }

        private void pictureBoxActualizarDataGr_Click(object sender, EventArgs e)
        {
            dataGridViewFornecedores.DataSource = new FornecedorDAO().ListarFornecedores();

            textBoxEmailFornec.Text = string.Empty;
            textBoxEnderecoForn.Text = string.Empty;
            textBoxNomeForn.Text = string.Empty;
            maskedTextBoxTelefoneFOrn.Text = string.Empty;
            labelFornecedorID.Text = "----------";
        }
        #endregion
    }
}
