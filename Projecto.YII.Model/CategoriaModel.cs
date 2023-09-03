using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class CategoriaModel
    {
        public CategoriaModel() {}

        public CategoriaModel(string nome, string descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
        }

        public int id_categoria { get; set; }
        public string nome { get; set; }
        public string descricao { get;}
    }
}
