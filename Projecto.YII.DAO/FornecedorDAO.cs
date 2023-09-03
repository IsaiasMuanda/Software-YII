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
    public class FornecedorDAO
    {
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar Fornecedores

        public void CadastrarFornecedores(FornecedorModel fornecedorModel_)
        {
            try
            {
                string comando_sql = @"insert into fornecedores (nome, telefone, endereco, email)
                values (@nome, @telefone, @endereco, @email)";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);

                cmd.Parameters.AddWithValue("@nome", fornecedorModel_.nome);
                cmd.Parameters.AddWithValue("@telefone", fornecedorModel_.telefone);
                cmd.Parameters.AddWithValue("@endereco", fornecedorModel_.endereco);
                cmd.Parameters.AddWithValue("@email", fornecedorModel_.email);


                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Fornecedor Cadastrado Com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar : " + ex);
            }
        }

        #endregion

        #region Listar Todos os Fornecedores no DataGridViewFornecedores

        public DataTable ListarFornecedores()
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string comando_sql = @"select id_fornecedores as 'Código',
                nome as 'Fornecedor',
                endereco as 'Endereço',
                telefone as 'Telefone',
                email as 'Email' from fornecedores;";
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter mySqlDataAdapter_ = new MySqlDataAdapter(cmd);
                mySqlDataAdapter_.Fill(dataTable_);

                conexao.Close();
                return dataTable_;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Listar" + ex);
                return null;
            }
        }

        #endregion

        #region Editar Clientes
        public void EditarFornecedores(FornecedorModel fornecedorModel_)
        {
            try
            {
                string comando_Sql = @"update fornecedores set nome=@nome,
                            telefone=@telefone,endereco=@endereco, email=@email
                            where id_fornecedores=@id";

                MySqlCommand cmd = new MySqlCommand(comando_Sql, conexao);
                cmd.Parameters.AddWithValue("@nome", fornecedorModel_.nome);
                cmd.Parameters.AddWithValue("@telefone", fornecedorModel_.telefone);
                cmd.Parameters.AddWithValue("@endereco", fornecedorModel_.endereco);
                cmd.Parameters.AddWithValue("@email", fornecedorModel_.email);
                cmd.Parameters.AddWithValue("@id", fornecedorModel_.id_fornecedor);

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

        #region Remover Fornecedor
        public void ExcluirFornecedor(FornecedorModel fornecedorModel_)
        {
            try
            {
                string sql = "delete from fornecedores where id_fornecedores=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", fornecedorModel_.id_fornecedor);

                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Excluído com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Pesquisar fornecedor por nome Aproximado

        public DataTable PesquisarPorNomeAprox(string nome)
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string sql = "select * from fornecedores where nome like @nome";

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

        #region Contar o número de fornecedores Para Exibir no Resumo
        public int ContarFornecedores()
        {
            int c = 0;
            try
            {
                string comando_sql = "select count( * ) from fornecedores";
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
    }
}
