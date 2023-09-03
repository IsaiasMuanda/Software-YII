using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class FuncionarioModel
    {
        public FuncionarioModel()
        {
        }

        public FuncionarioModel(int id_cargo, string nome_completo, string endereco, string telefone, string email)
        {
            this.id_cargo = id_cargo;
            this.nome_completo = nome_completo;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
        }

        public int id_funcionário { get; set; }
        public int id_cargo { get; set; }
        public string nome_completo { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set;}
    }
}
