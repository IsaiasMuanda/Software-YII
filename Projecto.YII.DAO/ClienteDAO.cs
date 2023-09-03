using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projecto_YII.Projecto.YII.Conexão;
using Projecto_YII.Projecto.YII.Model;

namespace Projecto_YII.Projecto.YII.DAO
{
    public class ClienteDAO
    {
        private  MySqlConnection conexao;
        
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }
               
        #region Cadastrar Clientes
        
        public void CadastrarClientes(ClienteModel clienteModel_obj)
        {
            try
            {
                string comando_sql = @"insert into clientes (nome_completo, telefone, endereco)
                values (@nome_completo, @telefone, @endereco)";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);

                cmd.Parameters.AddWithValue("@nome_completo", clienteModel_obj.nome_completo);
                cmd.Parameters.AddWithValue("@telefone", clienteModel_obj.telefone);
                cmd.Parameters.AddWithValue("@endereco", clienteModel_obj.endereco);
                
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                
                MessageBox.Show("Cliente Cadastrado Com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar : " +ex);
            }
        }

        #endregion

        #region Listar Todos os clientes no DataGridViewClientes
        
        public DataTable ListarClientes()
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string comando_sql = "select * from clientes";
                MySqlCommand cmd = new MySqlCommand( comando_sql, conexao);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter mySqlDataAdapter_ = new MySqlDataAdapter(cmd);
                mySqlDataAdapter_.Fill(dataTable_);

                conexao.Close();
                return dataTable_;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!","Erro ao Listar" +ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        #endregion

        #region Editar Clientes
        public void EditarClientes(ClienteModel clienteModel_obj)
        {
            try
            {
                string comando_Sql = @"update clientes set nome_completo=@nome_completo,
                            telefone=@telefone,endereco=@endereco
                            where id_clientes=@id";

                MySqlCommand cmd = new MySqlCommand(comando_Sql, conexao);
                cmd.Parameters.AddWithValue("@nome_completo", clienteModel_obj.nome_completo);
                cmd.Parameters.AddWithValue("@telefone", clienteModel_obj.telefone);
                cmd.Parameters.AddWithValue("@endereco", clienteModel_obj.endereco);
                cmd.Parameters.AddWithValue("@id", clienteModel_obj.id_cliente);

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

        #region Remover Cliente
        public void ExcluirCliente(ClienteModel clienteModel_obj)
        {
            try
            {
                string sql = "delete from clientes where id_clientes=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id",clienteModel_obj.id_cliente);

                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Excluído com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex ,"Erro", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Pesquisar Cliente por nome

        public DataTable PesquisarPorNome(string nome)
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string sql = "select * from clientes where nome_completo = @nome";

                MySqlCommand cmd = new MySqlCommand(sql,conexao);
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

        #region Pesquisar Cliente por nome Aproximado

        public DataTable PesquisarPorNomeAprox(string nome)
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string sql = "select * from clientes where nome_completo like @nome";

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

        #region Contar o número de clientes Para Exibir no Resumo
        public int ContarClientes()
        {
            int c = 0;
            try
            {
                string comando_sql = "select count( * ) from clientes";
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);

                conexao.Open();
                c = Convert.ToInt32(cmd.ExecuteScalar());
                conexao.Close();
                return c;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!", "Erro ao Contar" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        #endregion

        #region Exibir a quantidade de Clientes Diarios atendidos

        public int VendasDiarias()
        {
            try
            {
                int q = 0;
                string sql = "select count(id_clientesFK) from vendas where data_venda = @data";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@data", DateTime.Today);

                conexao.Open();
                object obj = cmd.ExecuteScalar();
                if(obj != null && obj != DBNull.Value)
                {
                    q = Convert.ToInt32(obj);
                    conexao.Close() ;
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
