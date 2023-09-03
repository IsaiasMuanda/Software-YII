using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class CargoModel
    {
        public CargoModel() {}

        public CargoModel(string nome)
        {
            this.nome = nome;
        }

        public int id_cargo { get; set; }
        public string nome { get; set; }
    }
}
