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
    public partial class FormEditarProductos : Form
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

        public FormEditarProductos()
        {
            InitializeComponent();
        }

        #region Eventos 
        //Evento click para fechar o formulário
        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*Eventos 
         * MouseEnter
         * MouseLeave
         * Do PictureBoxFechar
         */
        private void pictureBoxFechar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(22, 22);
        }
        private void pictureBoxFechar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(25, 25);
        }
        private void buttonGuardarEdicaoProducto_Click(object sender, EventArgs e)
        {
            ProductoModel productoModel_ = new ProductoModel(int.Parse(comboBoxEditarFornecedor.SelectedValue.ToString()), int.Parse(comboBoxEditarCategoria.SelectedValue.ToString()), decimal.Parse(textBoxEditarPrecoProducto.Text), textBoxEditarNomeProducto.Text, int.Parse(textBoxEditarQuantidade.Text), textBoxEditarDescricao.Text, textBoxEditarMarcaProducto.Text);

            productoModel_.id_fornecedor = Convert.ToInt32(comboBoxEditarFornecedor.SelectedValue.ToString());
            productoModel_.id_categoria = int.Parse(comboBoxEditarCategoria.SelectedValue.ToString());
            productoModel_.id_producto = int.Parse(labelEditar_ID.Text);
            new ProductoDAO().EditarProducto(productoModel_);
            this.Close();
        }

        private void FormEditarProductos_Load(object sender, EventArgs e)
        {
            //ComboBox categoria
            CategoriaDAO categoriaDAO_ = new CategoriaDAO();
            comboBoxEditarCategoria.DataSource = categoriaDAO_.ListarCategorias();
            comboBoxEditarCategoria.DisplayMember = "Tipo";
            comboBoxEditarCategoria.ValueMember = "Código";

            //ComboBox Fornecedor
            FornecedorDAO fornecedorDAO_ = new FornecedorDAO();
            comboBoxEditarFornecedor.DataSource = fornecedorDAO_.ListarFornecedores();
            comboBoxEditarFornecedor.DisplayMember = "Fornecedor";
            comboBoxEditarFornecedor.ValueMember = "Código";
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
