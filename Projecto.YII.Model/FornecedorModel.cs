using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class FornecedorModel
    {
        public FornecedorModel() { }

        public FornecedorModel(string nome, string endereco, string telefone, string email)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }

        public int id_fornecedor { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
