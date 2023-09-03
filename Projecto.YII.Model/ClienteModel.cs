using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class ClienteModel
    {
        public ClienteModel()
        {
        }

        public ClienteModel(string nome_completo, string telefone, string endereco)
        {
            this.nome_completo = nome_completo;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public int id_cliente { get; set; }
        public string nome_completo { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }
    }
}
