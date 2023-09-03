using MySql.Data.MySqlClient;
using Projecto_YII.Projecto.YII.Conexão;
using Projecto_YII.Projecto.YII.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.DAO
{
    public class VendaItemDAO
    {
        MySqlConnection Conexao;
        public VendaItemDAO()
        {
            this.Conexao = new ConnectionFactory().getConnection();
        }

        #region Cadastrar Venda Item

        public void CadastrarVendaItem(VendaItemModel vendaItemModel_)
        {
            try
            {
                string sql = @"insert into venda_item (id_vendasFK, id_productosFK, quantidade, subtotal)
                values (@id_vendasFK, @id_productosFK, @quantidade, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@id_vendasFK", vendaItemModel_.id_venda);
                cmd.Parameters.AddWithValue("@id_productosFK", vendaItemModel_.id_producto);
                cmd.Parameters.AddWithValue("@quantidade", vendaItemModel_.quantidade);
                cmd.Parameters.AddWithValue("@subtotal", vendaItemModel_.subtotal);

                Conexao.Open();
                cmd.ExecuteNonQuery();
                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        #endregion
    }
}
