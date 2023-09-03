using MySql.Data.MySqlClient;
using Projecto_YII.Projecto.YII.Conexão;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.DAO
{
    public class FormPrincipalDAO
    {
        private MySqlConnection conexao;
        public FormPrincipalDAO() 
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        public DataTable Listar()
        {
            try
            {
                DataTable dataTable = new DataTable();
                string sql = @"select p.id_productos as 'Código',
                        c.nome as 'Categoria',
                        p.tipo as 'Nome Do Producto',
                        p.marca as 'Marca',
                      
                        p.quantidade as 'Quantidade'
                       
                
                        from productos as p
                        join categoria as c
                        on p.id_categoriaFK= c.id_categoria
                        join fornecedores as f
                        on p.id_fornecedoresFK=f.id_fornecedores
                        where quantidade < 10 ";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);

                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();
                return dataTable;
            }
            catch (Exception)
            {
                throw;
                return null;
            }
        }
    }
}
