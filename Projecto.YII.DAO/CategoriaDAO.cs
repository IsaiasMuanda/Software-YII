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
    public class CategoriaDAO
    {
        private MySqlConnection conexao;

        public CategoriaDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar Categorias

        public void CadastraCategoria(CategoriaModel categoriaModel_)
        {
            try
            {
                string sql = @"insert into categoria (nome, descricao)
                values (@nome,@descricao)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", categoriaModel_.nome);
                cmd.Parameters.AddWithValue("@descricao", categoriaModel_.descricao);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Categoria Adicionada Com Sucesso");

                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Listar Categorias

        public DataTable ListarCategorias()
        {
            try
            {
                DataTable dataTable = new DataTable();
                string sql = "select id_categoria as Código, nome as Tipo, descricao as Descrição from categoria";
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

        #region Editar categorias

        public void EditarCategoria(CategoriaModel categoriaModel_)
        {
            try
            {
                string sql = "update categoria set nome=@nome, descricao=@descricao where id_categoria=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", categoriaModel_.nome);
                cmd.Parameters.AddWithValue("@descricao", categoriaModel_.descricao);
                cmd.Parameters.AddWithValue("@id", categoriaModel_.id_categoria);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Categoria Actualizada Com Sucesso");

                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Remover categorias

        public void RemoverCategoria(CategoriaModel categoriaModel_)
        {
            try
            {
                string sql = "delete from categoria where id_categoria=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", categoriaModel_.id_categoria);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Categoria Removida Com Sucesso");

                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Pesquisar categorias

        public DataTable PesquisarPorAprx(string nome)
        {
            try
            {
                string sql = "select * from categoria where nome like @nome";
                 DataTable dataTable = new DataTable();
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", nome);

                MySqlDataAdapter dataAdapter_ = new MySqlDataAdapter(cmd);
                dataAdapter_.Fill(dataTable);

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion
    }
}
