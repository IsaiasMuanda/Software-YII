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
    public partial class FromAdicionarProducto : Form
    {
        /*Comandos para mover e arrastar o programa PanelTop
         *Adicionar o evento MouseDown
         */
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int lParam);

        public FromAdicionarProducto()
        {
            InitializeComponent();
        }

        #region Eventos Do Formulário
        //Evento para fechar o formulário GuardarProductos
        private void pictureBoxFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*Evento do MouseDown do Formulário
        * Evento para arrastar o programa com o mouse
        */
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*Os dois eventos abaixo
         * MouseEnter
         * MouseLeave
         * PictureBoxFechar
         */
        private void pictureBoxFechar_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(23, 23);
        }
        private void pictureBoxFechar_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFechar.Size = new Size(25, 25);
        }
        private void FromAdicionarProducto_Load(object sender, EventArgs e)
        {
            //ComboBox categoria
            CategoriaDAO categoriaDAO_ = new CategoriaDAO();
            comboBoxCategoria.DataSource = categoriaDAO_.ListarCategorias();
            comboBoxCategoria.DisplayMember = "Tipo";
            comboBoxCategoria.ValueMember = "Código";

            //ComboBox Fornecedor
            FornecedorDAO fornecedorDAO_ = new FornecedorDAO();
            comboBoxFornecedor.DataSource = fornecedorDAO_.ListarFornecedores();
            comboBoxFornecedor.DisplayMember = "Fornecedor";
            comboBoxFornecedor.ValueMember = "Código";
        }
        private void buttonGuardarProducto_Click(object sender, EventArgs e)
        {
            ProductoModel productoModel_ = new ProductoModel(int.Parse(comboBoxFornecedor.SelectedValue.ToString()), int.Parse(comboBoxCategoria.SelectedValue.ToString()), decimal.Parse(textBoxPrecoProducto.Text), textBoxNomeProducto.Text, int.Parse(textBoxQuantidade.Text), textBoxDescricaoProd.Text, textBoxMarcaProducto.Text);


            if (textBoxDataValidade.Text == string.Empty)
            {
                productoModel_.data_validade = new DateTime();
            }
            else
            {
                productoModel_.data_validade = Convert.ToDateTime(textBoxDataValidade.Text);
            }

            ProductoDAO productoDAO_ = new ProductoDAO();
            productoDAO_.CadastrarProductos(productoModel_);
            this.Close();
        }

        private void buttonCancelarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
