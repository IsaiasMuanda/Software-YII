using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class ProductoModel
    {
        public ProductoModel()
        {
        }

        public ProductoModel(int id_fornecedor, int id_categoria, decimal preco, string tipo, int quantidade, string descricao, string marca)
        {
            this.id_fornecedor = id_fornecedor;
            this.id_categoria = id_categoria;
            this.preco = preco;
            this.tipo = tipo;
            this.quantidade = quantidade;
            this.descricao = descricao;
            this.marca = marca;
            //this.data_validade = data_validade;
        }

        public int id_producto { get; set; }
        public int id_fornecedor { get; set; }
        public int id_categoria { get; set; }
        public decimal preco { get; set; }
        public string tipo { get; set; }
        public int quantidade { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public string categoria { get; set; }
        public DateTime data_validade { get; set; }

    }
}
