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
    public class VendaDAO
    {
        private MySqlConnection conexao;

        public VendaDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Registrar Venda

        public void CadastraVenda(VendaModel vendaModel_)
        {
            try
            {
                string sql = @"insert into vendas (id_clientesFK, data_venda,tipo_pagamento, observacao, total_venda)
                         values(@id_clientesFK, @data, @tipo, @obs, @total)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id_clientesFK", vendaModel_.id_cliente);
                cmd.Parameters.AddWithValue("@data", vendaModel_.data_venda);
                cmd.Parameters.AddWithValue("@tipo", vendaModel_.tipo_pagamento);
                cmd.Parameters.AddWithValue("@obs", vendaModel_.observacao);
                cmd.Parameters.AddWithValue("@total", vendaModel_.total);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Venda Finalizada com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex);
            }
        }

        #endregion

        #region Retornar Id Venda

        public int RetornarIdVenda()
        {
            try
            {
                int id_v = 0;

                string sql = @"select max(id_vendas) id_vendas from vendas";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);


                conexao.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id_v = reader.GetInt32("id_vendas");

                }
                conexao.Close();
                return id_v;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                conexao.Close();

                return 0;
            }
        }
        #endregion

        #region Listar Vendas por periodo

        public DataTable ListarVendaPorData(DateTime dataInicio, DateTime dataFim)
        {
            try
            {

                DataTable dataTable = new DataTable();

                string sql = @"select v.id_vendas as 'Código Da Venda',
                c.nome_completo as 'Cliente',
                v.data_venda as 'Data Da Venda',
                v.tipo_pagamento as 'Pagamento',
                v.total_venda 'Total',
                v.observacao as 'Observação'
                from vendas as v
                join clientes as c 
                on v.id_clientesFK = c.id_clientes
                where data_venda between @dataInicio and @dataFim";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@dataInicio", dataInicio);
                cmd.Parameters.AddWithValue("@dataFim", dataFim);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                conexao.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteceu um erro " + ex);
                return null;
            }
        }

        #endregion

        #region Caixa Diaria
        public decimal CaixaDiaria()
        {
            try
            {
                decimal caixa = 0;

                string sql = @"select sum(total_venda) from vendas
                where data_venda = @data";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@data", DateTime.Today);

                conexao.Open();
                object r = cmd.ExecuteScalar(); 
                if (r != null && r!=DBNull.Value)
                {
                    caixa = (decimal)r;
                    conexao.Close();
                    return caixa;
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

        #region Listar Itens

        public DataTable ListarItens(int id)
        {
            try
            {
                DataTable dataTable_ = new DataTable();

                string sql = @"select
                p.tipo as 'Producto',
                p.preco as 'Preço',
                i.quantidade as 'Quantidade',
                i.subtotal as 'Subtotal'
                from venda_item as i  join
                productos as p on (i.id_productosFK = p.id_productos) where id_vendasFK = @id";

                MySqlCommand cmd = new MySqlCommand( sql, conexao );
                cmd.Parameters.AddWithValue ("@id", id);

                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dataTable_);

                conexao.Close() ;
                return dataTable_;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex);
                return null;
            }
        }

        #endregion
    }
}
