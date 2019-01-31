using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    public class Pedido
    {


        public int PedidoId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        public List<ItemPedido> Itens { get; set; }

        public Pedido()
        {
            Pessoa = new Pessoa();
        }
    }
}
