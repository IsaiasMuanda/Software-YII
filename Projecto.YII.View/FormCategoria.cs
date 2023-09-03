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
    public partial class FormCategoria : Form
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        #region Métodos do fomrulário
        public void TamanhoColunas(string n, int tamanho)
        {
            if (dataGridViewCat.Columns.Contains(n))
            {
                dataGridViewCat.Columns[n].Width = tamanho;
            }
        }

        #endregion

        #region Eventos Gerais
        //Evento Click
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            CategoriaModel categoriaModel_ = new CategoriaModel(textBoxCategoria.Text, textBoxDescricao.Text);
            new CategoriaDAO().CadastraCategoria(categoriaModel_);
            dataGridViewCat.DataSource = new CategoriaDAO().ListarCategorias();
        }
        //EVento Load para carregar dados no DataGridViewCat
        private void FormCategoria_Load(object sender, EventArgs e)
        {
            dataGridViewCat.DataSource = new CategoriaDAO().ListarCategorias();
            TamanhoColunas("Tipo", 150);
            TamanhoColunas("Descrição", 350);

        }
        //Evento CellClick para capturar os dados selecionados no DataGridView
        private void dataGridViewCat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Repositorio repositorio_ = new Repositorio();
            repositorio_.Capturar(labelCodigoCat, dataGridViewCat, 0);
            repositorio_.Capturar(textBoxCategoria, dataGridViewCat, 1);
            repositorio_.Capturar(textBoxDescricao, dataGridViewCat, 2);

            tabControlCategoria.SelectedTab = tabPage2;
        }

        //Evento Click
        private void buttonEditarCat_Click_1(object sender, EventArgs e)
        {
            CategoriaModel categoriaModel_ = new CategoriaModel(textBoxCategoria.Text, textBoxDescricao.Text);
            categoriaModel_.id_categoria = int.Parse(labelCodigoCat.Text);
            new CategoriaDAO().EditarCategoria(categoriaModel_);

            dataGridViewCat.DataSource = new CategoriaDAO().ListarCategorias();
        }
        //Evento Click
        private void buttonRemoverCat_Click_1(object sender, EventArgs e)
        {
            CategoriaModel categoriaModel_ = new CategoriaModel();
            categoriaModel_.id_categoria = int.Parse(labelCodigoCat.Text);

            if (MessageBox.Show("Deseja Remover A categoria?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new CategoriaDAO().RemoverCategoria(categoriaModel_);
                dataGridViewCat.DataSource = new CategoriaDAO().ListarCategorias();
            }
            else
            {
                MessageBox.Show("Cancelada");
            }
        }
        //Evento para pesquisar categorias
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CategoriaDAO categoriaDAO = new CategoriaDAO();

            string n = "%" + textBoxPesquisarCateg.Text + "%";
            dataGridViewCat.DataSource = categoriaDAO.PesquisarPorAprx(n);
        }

        //Limpar os campos
        private void pictureBoxLimpar_Click(object sender, EventArgs e)
        {
            textBoxCategoria.Text = string.Empty;
            labelCodigoCat.Text = string.Empty;
            textBoxDescricao.Text = string.Empty;
        }
        #endregion


    }
}
