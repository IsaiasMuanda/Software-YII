using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class VendaModel
    {
        public VendaModel(int id_cliente, DateTime data_venda, string tipo_pagamento, string observacao, decimal total)
        {
            this.id_cliente = id_cliente;
            this.data_venda = data_venda;
            this.tipo_pagamento = tipo_pagamento;
            this.observacao = observacao;
            this.total = total;
        }

        public int id_venda { get; set; }
        public int id_cliente { get; set; }
        public DateTime data_venda { get; set; }
        public string tipo_pagamento { get; set; }
        public string observacao { get; set; }
        public decimal total { get; set; }
    }
}
