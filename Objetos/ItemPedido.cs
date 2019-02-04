using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    public class ItemPedido
    {
        public ItemPedido(Produto produto, decimal preco, int quantidade, Pedido pedido)
        {
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            this.pedido = pedido;
        }

        public int ItemPedidoId { get; set; }
        public Produto Produto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Pedido pedido { get; set; }
    }
}
