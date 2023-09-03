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
    public partial class FormCargos : Form
    {
        Repositorio repositorio_ = new Repositorio();
        public FormCargos()
        {
            InitializeComponent();
        }

        #region Métodos do formulário
       
        #endregion

        #region Eventos 

        //Método click do botão Guardar, para salvar os dados
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            CargoModel cargo_ = new CargoModel(textBoxCargo.Text);
            new CargoDAO().CadastrarCargos(cargo_);
            dataGridViewCargo.DataSource = new CargoDAO().ListarCargos();
        }

        //Evento load para carregar automaticamente os DataGridView
        private void FormCargos_Load(object sender, EventArgs e)
        {
            dataGridViewCargo.DataSource = new CargoDAO().ListarCargos();
            repositorio_.TamanhoColunas(dataGridViewCargo, "Código", 200);
            repositorio_.TamanhoColunas(dataGridViewCargo, "Tipo", 407);
        }
        //Evento para capturar os dados selecionados no DataGridView 
        private void dataGridViewCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Repositorio repositorio_ = new Repositorio();
            repositorio_.Capturar(labelCodigoCargo, dataGridViewCargo, 0);
            repositorio_.Capturar(textBoxCargo, dataGridViewCargo, 1);
            tabControlCargo.SelectedTab = tabPage2;
            buttonGuardar.Enabled = false;
        }
        //Evento click do botão Editar os dados
        private void buttonEditarCargo_Click(object sender, EventArgs e)
        {
            CargoModel cargoModel_ = new CargoModel(textBoxCargo.Text);
            cargoModel_.id_cargo = int.Parse(labelCodigoCargo.Text);

            new CargoDAO().EditarCargo(cargoModel_);
            dataGridViewCargo.DataSource = new CargoDAO().ListarCargos();

        }
        //Evento click do botão Remover os dados
        private void buttonRemoverCargo_Click(object sender, EventArgs e)
        {
            CargoModel cargo_Model = new CargoModel();
            cargo_Model.id_cargo = int.Parse(labelCodigoCargo.Text);

            if (MessageBox.Show("Deseja Remover O Cargo?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new CargoDAO().RemoverCargos(cargo_Model);
                dataGridViewCargo.DataSource = new CargoDAO().ListarCargos();
            }
            else
            {
                MessageBox.Show("Cancelada");
            }
        }

        //Limpar os campos
        private void pictureBoxLimpar_Click(object sender, EventArgs e)
        {
            textBoxCargo.Text = string.Empty;
            labelCodigoCargo.Text = string.Empty;
            buttonGuardar.Enabled = true;
        }

        private void textBoxPesquisarCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string n = "%" + textBoxPesquisarCargo.Text + "%";
            dataGridViewCargo.DataSource = new CargoDAO().PesquisarPorAprx(n);
        }

        #endregion


    }
}
