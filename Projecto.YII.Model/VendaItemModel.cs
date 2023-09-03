using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_YII.Projecto.YII.Model
{
    public class VendaItemModel
    {
        public int id_venda_item { get; set; }
        public int id_producto { get; set; }
        public int id_venda { get; set; }
        public int quantidade { get; set; }
        public decimal subtotal { get; set; }
    }
}
