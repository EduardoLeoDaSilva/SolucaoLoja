using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public Produto Produto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Pedido pedido { get; set; }
    }
}
