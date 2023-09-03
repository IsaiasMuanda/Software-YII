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
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;
        public FuncionarioDAO() 
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar Funcionario

        public void CadastrarFuncionario(FuncionarioModel funcionarioModel_)
        {
            try
            {
                string comando_sql = @"insert into funcionarios (id_cargo,nome_completo,endereco,telefone,email)
                values (@id_cargo,@nome,@endereco,@telefone,@email)";

                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);

                cmd.Parameters.AddWithValue("@id_cargo", funcionarioModel_.id_cargo);
                cmd.Parameters.AddWithValue("@nome", funcionarioModel_.nome_completo);
                cmd.Parameters.AddWithValue("@telefone", funcionarioModel_.telefone);
                cmd.Parameters.AddWithValue("@endereco", funcionarioModel_.endereco);
                cmd.Parameters.AddWithValue("@email", funcionarioModel_.email);


                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Funcionário Cadastrado Com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar : " + ex);
            }
        }

        #endregion

        #region Listar Todos os Funcionarios no DataGridView

        public DataTable ListarFuncionarios()
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string comando_sql = @"select f.id_funcionarios as 'Código',
                f.nome_completo as 'Nome Completo',
                f.endereco as 'Endereço', 
                f.telefone as 'Telefone',
                f.email as 'Email',
                c.nome as 'Cargo'
                from funcionarios as f
                join cargos as c 
                on f.id_cargo=c.id_cargo; ";
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

        #region Editar Funcionarios
        public void EditarFuncionario(FuncionarioModel funcionarioModel_)
        {
            try
            {
                string comando_Sql = @"update funcionarios set id_cargo=@id_cargo, nome_completo=@nome,
                            telefone=@telefone,endereco=@endereco, email=@email
                            where id_funcionarios=@id";

                MySqlCommand cmd = new MySqlCommand(comando_Sql, conexao);
                cmd.Parameters.AddWithValue("@id_cargo", funcionarioModel_.id_cargo);
                cmd.Parameters.AddWithValue("@nome", funcionarioModel_.nome_completo);
                cmd.Parameters.AddWithValue("@telefone", funcionarioModel_.telefone);
                cmd.Parameters.AddWithValue("@endereco", funcionarioModel_.endereco);
                cmd.Parameters.AddWithValue("@email", funcionarioModel_.email);
                cmd.Parameters.AddWithValue("@id", funcionarioModel_.id_funcionário);

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

        #region Remover fornecedor
        public void ExcluirFuncionario(FuncionarioModel funcionarioModel)
        {
            try
            {
                string sql = "delete from funcionarios where id_funcionarios=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@id", funcionarioModel.id_funcionário);

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

        #region Pesquisar funcionario por nome Aproximado

        public DataTable PesquisarPorNomeAprox(string nome)
        {
            try
            {
                DataTable dataTable_ = new DataTable();
                string sql = @"select f.id_funcionarios as 'Código',
                f.nome_completo as 'Nome Completo',
                f.endereco as 'Endereço', 
                f.telefone as 'Telefone',
                f.email as 'Email',
                c.nome as 'Cargo'
                from funcionarios as f
                join cargos as c 
                on f.id_cargo=c.id_cargo
                where nome_completo like @nome";

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

        #region Contar o número de funcionarios Para Exibir no Resumo
        public int ContarFuncionarios()
        {
            int c = 0;
            try
            {
                string comando_sql = "select count( * ) from funcionarios";
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
