using MySql.Data.MySqlClient;
using Projecto_YII.Projecto.YII.Conexão;
using Projecto_YII.Projecto.YII.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.DAO
{
    public class ProductoDAO
    {
        private MySqlConnection conexao;

        public ProductoDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }
        #region Cadastrar Productos

        public void CadastrarProductos(ProductoModel productoModel_)
        {
            string sql = @"insert into productos (id_categoriaFK,id_fornecedoresFK,preco,tipo,quantidade,descricao,marca,data_validade)
                        values(@idC,@idF,@preco,@tipo,@quantidade,@descricao,@marca,@data_v)";

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idC", productoModel_.id_categoria);
            cmd.Parameters.AddWithValue("@idF", productoModel_.id_fornecedor);
            cmd.Parameters.AddWithValue("@preco", productoModel_.preco);
            cmd.Parameters.AddWithValue("@tipo", productoModel_.tipo);
            cmd.Parameters.AddWithValue("@quantidade", productoModel_.quantidade);
            cmd.Parameters.AddWithValue("@descricao", productoModel_.descricao);
            cmd.Parameters.AddWithValue("@marca", productoModel_.marca);
            cmd.Parameters.AddWithValue("@data_v", productoModel_.data_validade);

            conexao.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Producto Cadastrado Com Sucesso");

            conexao.Close();
        }

        #endregion

        #region Listar Productos

        public DataTable ListarProductos()
        {
            try
            {
                DataTable dataTable = new DataTable();
                string sql = @"select p.id_productos as 'Código',
                c.nome as 'Categoria',
                p.tipo as 'Nome Do Producto',
                p.marca as 'Marca',
                p.preco as 'Preço',
                p.quantidade as 'Quantidade',
                p.data_validade as 'Data De Validade',
                p.descricao as 'Descrição',
                f.nome as 'Fornecedor'
                from productos as p
                join categoria as c
                on p.id_categoriaFK= c.id_categoria
                join fornecedores as f
                on p.id_fornecedoresFK=f.id_fornecedores;";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);

                conexao.Close();
                return dataTable;

            }
            catch (Exception)
            {
                throw;
                return null;
            }
        }

        #endregion

        #region Editar Producto
        public void EditarProducto(ProductoModel productoModel_)
        {
            try
            {
                string comando_Sql = @"update productos set id_categoriaFK = @idC, id_fornecedoresFK = @idF,preco=@preco,tipo=@tipo,
                quantidade=@quantidade,descricao=@descricao,marca=@marca
                where id_productos=@id";

                MySqlCommand cmd = new MySqlCommand(comando_Sql, conexao);
                cmd.Parameters.AddWithValue("@idC", productoModel_.id_categoria);
                cmd.Parameters.AddWithValue("@idF", productoModel_.id_fornecedor);
                cmd.Parameters.AddWithValue("@preco", productoModel_.preco);
                cmd.Parameters.AddWithValue("@tipo", productoModel_.tipo);
                cmd.Parameters.AddWithValue("@quantidade", productoModel_.quantidade);
                cmd.Parameters.AddWithValue("@descricao", productoModel_.descricao);
                cmd.Parameters.AddWithValue("@marca", productoModel_.marca);
                cmd.Parameters.AddWithValue("@id", productoModel_.id_producto);


                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados Com Sucesso!");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar Dados : " + ex);
            }
        }
        #endregion

        #region Remover Producto
        public void ExcluirProducto(ProductoModel productoModel_)
        {
            try
            {
                string sql = "delete from productos where id_productos=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", productoModel_.id_producto);

                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Pesquisar producto por nome Aproximado

        public DataTable PesquisarPorNomeAprox(string nome)
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string sql = @"select p.id_productos as 'Código',
                c.nome as 'Categoria',
                p.tipo as 'Nome Do Producto',
                p.marca as 'Marca',
                p.preco as 'Preço',
                p.quantidade as 'Quantidade',
                p.data_validade as 'Data De Validade',
                p.descricao as 'Descrição',
                f.nome as 'Fornecedor'
                from productos as p
                join categoria as c
                on p.id_categoriaFK= c.id_categoria
                join fornecedores as f
                on p.id_fornecedoresFK=f.id_fornecedores
                where tipo like @nome";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter daAdapter = new MySqlDataAdapter(cmd);
                daAdapter.Fill(dataTable_);

                conexao.Close();
                return dataTable_;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                return null;
            }
        }

        #endregion

        #region Contar

        public int ContarProducto()
        {
            int c = 0;

            try
            {
                string sql = "select count(*) from productos";
                MySqlCommand cmd = new MySqlCommand( sql, conexao );

                conexao.Open();
                c = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Close();
                return c;
            }
            catch (Exception)
            {
                throw;
                return 0;
            }
        }

        #endregion

        #region Retornar Producto



        public DataTable ListarProducto2(string nome)
        {
            try
            {
                DataTable dataTable = new DataTable();
                string sql = @"select p.id_productos as 'Código',
                            c.nome as 'Categoria',
                            p.tipo as 'Nome Do Producto',
                            p.marca as 'Marca',
                            p.preco as 'Preço',
                            p.quantidade as 'Quantidade',
                            p.data_validade as 'Data De Validade',
                            p.descricao as 'Descrição'
                            
                            from productos as p
                            join categoria as c
                            on p.id_categoriaFK= c.id_categoria
                            where tipo like @nome";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);

                conexao.Close();
                return dataTable;

            }
            catch (Exception)
            {
                throw;
                return null;
            }
        }

        /*
        public ProductoModel RetornarProdID(string nome)
        {
            try
            {
                string sql = "select * from productos where tipo = @nome";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    ProductoModel productosModel = new ProductoModel();
                    productosModel.id_producto = dataReader.GetInt32("id_productos");
                    productosModel.descricao = dataReader.GetString("descricao");
                    productosModel.preco = dataReader.GetInt32("preco");
                    productosModel.tipo = dataReader.GetString("tipo");
                    productosModel.tipo = dataReader.GetString("marca");
                    productosModel.tipo = dataReader.GetDateTime("data_validade").ToString();

                    conexao.Close();

                    return productosModel;
                }
                else
                {
                    conexao.Close();
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        */
        #endregion

        #region Retorna quantidade

        public int RetornarQuantidade(int id)
        {
            try
            {
                int qtd = 0;
                string sql = "select quantidade from productos where id_productos = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);

                conexao.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    qtd = dr.GetInt32("quantidade");
                    conexao.Close();
                }
                return qtd;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
                return 0;
            }
        }

        #endregion

        #region Descontar quantidade

        public void DescontarQuantidade(int id, int quantidade)
        {
            try
            {
                string sql = "update productos set quantidade = @qtd where id_productos = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@qtd", quantidade);

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
                conexao.Close();
            }
        }

        #endregion

        #region Exibir quantidade diária vendida

        public int ProductosDiarios()
        {
            try
            {
                int q = 0;
                string sql = @"select count(vi.id_productosFK), 
                v.data_venda
                from venda_item as vi 
                join vendas as v
                on vi.id_vendasFK = v.id_vendas
                where data_venda = @data";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@data", DateTime.Today);

                conexao.Open();
                object obj = cmd.ExecuteScalar();
                if (obj != null && obj != DBNull.Value)
                {
                    q = Convert.ToInt32(obj);
                    conexao.Close();
                    return q;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
                return 0;
            }
        }

        #endregion
    }
}
