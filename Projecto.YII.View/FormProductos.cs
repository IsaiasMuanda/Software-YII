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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }
        //Objecto da classe FormTelaInicial
        FormTelaInicial FormTelaInicial_obj = new FormTelaInicial();
        Repositorio repositorio_ = new Repositorio();

        #region Eventos DO Formulário
        /*Eventos
         * MouseEnter
         * MouseLeave
         * Click
         */
        //Evento click do botão Adicionar Producto
        private void buttonAdicionarProducto_Click(object sender, EventArgs e)
        {
            FromAdicionarProducto fromAdicionarProducto_ = new FromAdicionarProducto();
            FormTelaInicial_obj.AbrirFormulárioExtra(fromAdicionarProducto_, "fromAdicionarProducto_");
            //FormTelaInicial_obj.AbrirFormulárioExtra(fromAdicionarProducto_, "FromAdicionarProducto");
        }

        //Evento click do botão Editar Producto
        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {
            FormEditarProductos formEditarProductos_ = new FormEditarProductos();
            FormTelaInicial_obj.AbrirFormulárioExtra(formEditarProductos_, "formEditarProductos_");
            repositorio_.Capturar(formEditarProductos_.labelEditar_ID, dataGridViewProductos, 0);
            repositorio_.Capturar(formEditarProductos_.comboBoxEditarCategoria, dataGridViewProductos, 1);
            repositorio_.Capturar(formEditarProductos_.textBoxEditarNomeProducto, dataGridViewProductos, 2);
            repositorio_.Capturar(formEditarProductos_.textBoxEditarMarcaProducto, dataGridViewProductos, 3);
            repositorio_.Capturar(formEditarProductos_.textBoxEditarPrecoProducto, dataGridViewProductos, 4);
            repositorio_.Capturar(formEditarProductos_.textBoxEditarQuantidade, dataGridViewProductos, 5);
            //repositorio_.Capturar(formEditarProductos_.labelDataEditar, dataGridViewProductos, 6);
            repositorio_.Capturar(formEditarProductos_.textBoxEditarDescricao, dataGridViewProductos, 7);
            repositorio_.Capturar(formEditarProductos_.comboBoxEditarFornecedor, dataGridViewProductos, 8);
            repositorio_.Capturar(formEditarProductos_.labelDataEditar, dataGridViewProductos, 6);

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            ProductoDAO productoDAO_ = new ProductoDAO();
            dataGridViewProductos.DataSource = productoDAO_.ListarProductos();
            repositorio_.TamanhoColunas(dataGridViewProductos, "Fornecedor", 200);
            repositorio_.TamanhoColunas(dataGridViewProductos, "Descrição", 290);
        }

        private void textBoxPesquisarProducto_TextChanged(object sender, EventArgs e)
        {
            string n = "%" + textBoxPesquisarProducto.Text + "%";
            dataGridViewProductos.DataSource = new ProductoDAO().PesquisarPorNomeAprox(n);
        }

        private void buttonRemoverProducto_Click(object sender, EventArgs e)
        {
            FromAdicionarProducto fromAdicionarProducto_ = new FromAdicionarProducto();
            repositorio_.Capturar(fromAdicionarProducto_.labelADD_CodProducto, dataGridViewProductos, 0);

            ProductoModel productoModel_ = new ProductoModel();
            productoModel_.id_producto = int.Parse(fromAdicionarProducto_.labelADD_CodProducto.Text);

            ProductoDAO productoDAO_ = new ProductoDAO();
            if (MessageBox.Show("Excluir Producto?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                productoDAO_.ExcluirProducto(productoModel_);
                fromAdicionarProducto_.labelADD_CodProducto.Text = "";
                dataGridViewProductos.DataSource = productoDAO_.ListarProductos();
            }
            else
            {
                MessageBox.Show("Operação Cancelada", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxActualizarDataGr_Click(object sender, EventArgs e)
        {
            dataGridViewProductos.DataSource = new ProductoDAO().ListarProductos();
        }
    }
    #endregion

}
