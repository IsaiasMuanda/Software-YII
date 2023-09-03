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
    public partial class Formvendas : Form
    {
        #region Variáveis Globais

        int qtd, codigo;
        string nome, categoria, descricao;
        decimal preco;
        decimal total, subtotal;

        DataTable dataTable_carrinho = new DataTable();
        Repositorio repositorio = new Repositorio();

        #endregion
        public Formvendas()
        {
            InitializeComponent();

            //Adcionando colunas do dataTable_carrinho
            dataGridViewCarrinhoTemp.Visible = false;

            dataGridViewCarrinhoTemp.Visible = false;
            dataTable_carrinho.Columns.Add("Código", typeof(int));
            dataTable_carrinho.Columns.Add("Categoria", typeof(string));
            dataTable_carrinho.Columns.Add("Descrição", typeof(string));
            dataTable_carrinho.Columns.Add("Nome Do Producto", typeof(string));
            dataTable_carrinho.Columns.Add("Quantidade", typeof(int));
            dataTable_carrinho.Columns.Add("Preço", typeof(decimal));
            dataTable_carrinho.Columns.Add("Subtotal", typeof(decimal));

            //dataGridViewVendas recebe as colunas do dataTable_carrinho
            dataGridViewVendas.DataSource = dataTable_carrinho;


            //Alterando o tamanho das colunas do dataGridViewVendas
            repositorio.TamanhoColunas(dataGridViewVendas, "Descrição", 280);
            repositorio.TamanhoColunas(dataGridViewVendas, "Nome Do Producto", 280);
            repositorio.TamanhoColunas(dataGridViewVendas, "Subtotal", 203);
        }

        #region Eventos do formulário

        //Evento Load para Carregar automaticamente os nomes dos clientes
        private void Formvendas_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO_ = new ClienteDAO();
            comboBoxClienteVendas.DataSource = clienteDAO_.ListarClientes();
            comboBoxClienteVendas.DisplayMember = "nome_completo";
            comboBoxClienteVendas.ValueMember = "id_clientes";

            //Exibir a data actual da venda
            labelDataVenda.Text = DateTime.Now.ToString("D");
        }

        /*Evento keypress
         * para capturar dados digitados no textboxPesquisarProducto
         */
        private void textBoxPesquisarProdVendas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && textBoxPesquisarProdVendas.Text != string.Empty)
            {
                //1 - O dataGridViewCarrinhoTemp recebe os dados através do método ListarProducto2()
                dataGridViewCarrinhoTemp.DataSource = new ProductoDAO().ListarProducto2(textBoxPesquisarProdVendas.Text);
                //2 - Visisibilidade 
                dataGridViewCarrinhoTemp.Visible = true;
            }
            else
            {
                dataGridViewCarrinhoTemp.Visible = false;
                //MessageBox.Show("Não Encontrado");
            }
        }
        //Evento click do buttonAdicionarCarrinho
        private void buttonAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            try
            {

                //A variável qtd recebe como valor os dados digitados no TextBoxQtd
                qtd = int.Parse(textBoxQtdDataGV_Venda.Text);
                int qtd_condicao = int.Parse(dataGridViewCarrinhoTemp.CurrentRow.Cells[5].Value.ToString());

                if (qtd > qtd_condicao)
                {
                    MessageBox.Show("Quantidade insuficiente", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //A variável codigo recebe como valor os dados da coluna 0 do dataGridViewCarrinhoTemp
                    codigo = int.Parse(dataGridViewCarrinhoTemp.CurrentRow.Cells[0].Value.ToString());

                    //A variável nome recebe como valor os dados da coluna 1 do dataGridViewCarrinhoTemp
                    nome = dataGridViewCarrinhoTemp.CurrentRow.Cells[1].Value.ToString();

                    //A variável categoria recebe como valor os dados da coluna 2 do dataGridViewCarrinhoTemp
                    categoria = dataGridViewCarrinhoTemp.CurrentRow.Cells[2].Value.ToString();

                    //A variável preco recebe como valor os dados da coluna 4 do dataGridViewCarrinhoTemp
                    preco = decimal.Parse(dataGridViewCarrinhoTemp.CurrentRow.Cells[4].Value.ToString());

                    descricao = dataGridViewCarrinhoTemp.CurrentRow.Cells[7].Value.ToString();

                    //subtotal aramazena o resultado da multiplicção da quantidade e preço
                    subtotal = qtd * preco;

                    //total armazena a soma de todos os subtotais
                    total += subtotal;
                    labelExibirTotal.Text = total.ToString();

                    dataTable_carrinho.Rows.Add(codigo, nome, descricao, categoria, qtd, preco, subtotal);
                    dataGridViewVendas.DataSource = dataTable_carrinho;
                    dataGridViewCarrinhoTemp.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro, tente novamente");
            }
        }

        //Remover Produtos selecionados no carrinho
        private void buttonRemoverCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                //Variável para armazenar a coluna Subtotal do dataGridViewVendas
                decimal sub = decimal.Parse(dataGridViewVendas.CurrentRow.Cells[6].Value.ToString());

                //Variável para armazenar o indice da coluna selecionada no dataGridViewVendas
                int i = dataGridViewVendas.CurrentRow.Index;

                DataRow linha = dataTable_carrinho.Rows[i];

                if (MessageBox.Show("Deseja remover o producto?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataTable_carrinho.Rows.Remove(linha);
                    dataTable_carrinho.AcceptChanges();
                    total -= sub;
                    labelExibirTotal.Text = total.ToString();
                    MessageBox.Show("Producto Removido!");
                }
                else
                {
                    MessageBox.Show("Cancelado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente " + ex);
            }
        }

        //Finalizar Venda
        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                /*Funções da variáveis abaixo  
                 * qtd_actual: A quantidade actual de um producto atravé do método RetornarQuantidade
                 * qtd_compra: Armazenar a quantidade da compra
                 * qtd_actualizada: Receber e actualizar a quantidade do producto após a compra
                 */
                int qtd_actual, qtd_compra, qtd_actualizada;

                decimal valor_pago = decimal.Parse(textBoxValorEntregue.Text);
                decimal troco = 0;

                if (valor_pago < total)
                {
                    MessageBox.Show("Valor Insuficiente!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    troco = valor_pago - total;

                    VendaModel vendaModel_ = new VendaModel(int.Parse(comboBoxClienteVendas.SelectedValue.ToString()), DateTime.Parse(labelDataVenda.Text), comboBoxTipoPagamento.Text, textBoxObsVenda.Text,
                    decimal.Parse(labelExibirTotal.Text));

                    VendaDAO vendaDAO_ = new VendaDAO();
                    textBoxTrocoVenda.Text = troco.ToString();

                    vendaDAO_.CadastraVenda(vendaModel_);

                    foreach (DataRow dr in dataTable_carrinho.Rows)
                    {
                        VendaItemModel vendaItemModel_ = new VendaItemModel();
                        vendaItemModel_.id_venda = vendaDAO_.RetornarIdVenda();
                        vendaItemModel_.id_producto = int.Parse(dr["Código"].ToString());
                        vendaItemModel_.quantidade = int.Parse(dr["Quantidade"].ToString());
                        vendaItemModel_.subtotal = decimal.Parse(dr["Subtotal"].ToString());

                        qtd_actual = new ProductoDAO().RetornarQuantidade(vendaItemModel_.id_producto);
                        qtd_compra = vendaItemModel_.quantidade;

                        //Subtraindo a quantidade actual com a quantidade comprada
                        qtd_actualizada = qtd_actual - qtd_compra;

                        new ProductoDAO().DescontarQuantidade(vendaItemModel_.id_producto, qtd_actualizada);

                        VendaItemDAO vendaItemDAO_ = new VendaItemDAO();
                        vendaItemDAO_.CadastrarVendaItem(vendaItemModel_);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, tente novamente " + ex);
            }
        }
        private void buttonNovaVenda_Click(object sender, EventArgs e)
        {
            dataGridViewVendas.Columns.Clear();

            textBoxQtdDataGV_Venda.Text = string.Empty;
            textBoxValorEntregue.Text = string.Empty;
            textBoxTrocoVenda.Text = string.Empty;
        }
        #endregion
    }
}
