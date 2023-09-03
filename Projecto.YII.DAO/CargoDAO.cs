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
    public class CargoDAO
    {
        private MySqlConnection conexao;

        public CargoDAO()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar cargos

        public void CadastrarCargos(CargoModel cargoModel_)
        {
            try
            {
                string sql = @"insert into cargos (nome)
                values (@nome)";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", cargoModel_.nome);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Novo Cargo Adicionado Com Sucesso");

                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Listar cargos

        public DataTable ListarCargos()
        {
            try
            {
                DataTable dataTable = new DataTable();
                string sql = "select id_cargo as Código, nome as Tipo from cargos";
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

        #region Editar cargos

        public void EditarCargo(CargoModel cargoModel_)
        {
            try
            {
                string sql = "update cargos set nome=@nome where id_cargo=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", cargoModel_.nome);
                cmd.Parameters.AddWithValue("@id", cargoModel_.id_cargo);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cargo Actualizado Com Sucesso");

                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Remover cargos

        public void RemoverCargos(CargoModel cargoModel_)
        {
            try
            {
                string sql = "delete from cargos where id_cargo=@id";

                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@id", cargoModel_.id_cargo);

                conexao.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cargo Removido Com Sucesso");

                conexao.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion

        #region Pesquisar cargos

        public DataTable PesquisarPorAprx(string nome)
        {
            try
            {
                DataTable dataTable = new DataTable();

                string sql = "select * from cargos where nome like @nome";
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
