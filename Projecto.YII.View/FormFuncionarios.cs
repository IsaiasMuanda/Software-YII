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
    public partial class FormFuncionarios : Form
    {
        FormTelaInicial FormTelaInicial_ = new FormTelaInicial();
        Repositorio repositorio_ = new Repositorio();

        public FormFuncionarios()
        {
            InitializeComponent();
        }

        #region Método do formulário
        //Método para actualizar o DataGridView
        public void ActualizarDataGridView()
        {
            dataGridViewFunc.DataSource = new FuncionarioDAO().ListarFuncionarios();
        }

        #endregion

        #region Eventos Do Formulário
        //Evento click do botão Editar funcionario
        private void buttonEditarFuncionario_Click(object sender, EventArgs e)
        {
            FromEditarFuncionario fromEditarFuncionario_ = new FromEditarFuncionario();
            FormTelaInicial_.AbrirFormulárioExtra(fromEditarFuncionario_, "fromEditarFuncionario_");

            fromEditarFuncionario_.comboBoxEditarCargo.DataSource = new CargoDAO().ListarCargos();
            fromEditarFuncionario_.comboBoxEditarCargo.DisplayMember = "Tipo";
            fromEditarFuncionario_.comboBoxEditarCargo.ValueMember = "Código";

            repositorio_.Capturar(fromEditarFuncionario_.labeICod_EditarFunc, dataGridViewFunc, 0);
            repositorio_.Capturar(fromEditarFuncionario_.textBoxEditarNomeFuncionario, dataGridViewFunc, 1);
            repositorio_.Capturar(fromEditarFuncionario_.textBoxEditarEnderecoFuncionario, dataGridViewFunc, 2);
            repositorio_.Capturar(fromEditarFuncionario_.maskedTextBoxEditarTelefoneFuncionario, dataGridViewFunc, 3);
            repositorio_.Capturar(fromEditarFuncionario_.textBoxEditarEmailFuncionario, dataGridViewFunc, 4);

        }

        //Evento Loada para carregar o ComboBoxCargos e o DataGridViewcom os dados
        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            CargoDAO cargoDAO_ = new CargoDAO();
            comboBoxCargo.DataSource = cargoDAO_.ListarCargos();
            comboBoxCargo.DisplayMember = "Tipo";
            comboBoxCargo.ValueMember = "Código";

            FuncionarioDAO funcionarioDAO_ = new FuncionarioDAO();
            dataGridViewFunc.DataSource = funcionarioDAO_.ListarFuncionarios();

            repositorio_.TamanhoColunas(dataGridViewFunc, "Nome Completo", 250);
            repositorio_.TamanhoColunas(dataGridViewFunc, "Telefone", 150);
            repositorio_.TamanhoColunas(dataGridViewFunc, "Email", 250);
            repositorio_.TamanhoColunas(dataGridViewFunc, "Endereço", 300);
            repositorio_.TamanhoColunas(dataGridViewFunc, "Cargo", 100);

        }

        //Cadastrar
        private void buttonAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioModel funcionarioModel_ = new FuncionarioModel(int.Parse(comboBoxCargo.SelectedValue.ToString()), textBoxNomeFuncionario.Text, textBoxEnderecoFuncionario.Text, maskedTextBoxTelefoneFuncionario.Text, textBoxEmailFuncionario.Text);
            funcionarioModel_.id_cargo = int.Parse(comboBoxCargo.SelectedValue.ToString());

            FuncionarioDAO funcionarioDAO_ = new FuncionarioDAO();
            funcionarioDAO_.CadastrarFuncionario(funcionarioModel_);

            ActualizarDataGridView();
        }
        private void buttonRemoverFuncionario_Click(object sender, EventArgs e)
        {
            repositorio_.Capturar(labelFuncCodigo, dataGridViewFunc, 0);

            FuncionarioModel funcionarioModel_ = new FuncionarioModel();
            funcionarioModel_.id_funcionário = int.Parse(labelFuncCodigo.Text);

            FuncionarioDAO funcionarioDAO_ = new FuncionarioDAO();
            if (MessageBox.Show("Excluir Funcionário?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                funcionarioDAO_.ExcluirFuncionario(funcionarioModel_);
                labelFuncCodigo.Text = string.Empty;
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Operação Cancelada", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxPesquisarFuncionario_TextChanged(object sender, EventArgs e)
        {
            string n = "%" + textBoxPesquisarFuncionario.Text + "%";
            dataGridViewFunc.DataSource = new FuncionarioDAO().PesquisarPorNomeAprox(n);
        }

        private void pictureBoxActualizarDataGr_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView();
            textBoxEmailFuncionario.Text = string.Empty;    
            textBoxEnderecoFuncionario.Text = string.Empty;
            textBoxNomeFuncionario.Text = string.Empty; 
            maskedTextBoxTelefoneFuncionario.Text = string.Empty;
        }
        #endregion
    }
}
