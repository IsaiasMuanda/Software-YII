using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projecto_YII.Projecto.YII.Conexão
{
    public class ConnectionFactory
    {
        //STring de conexão para a Base De dados: Lojayiii
        public MySqlConnection getConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["lojayiii"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
