using AppEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicativoNetCore.repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationContext context;
        private readonly IHttpContextAccessor contextAcessor;
        public PedidoRepository(ApplicationContext context, IHttpContextAccessor contextAccessor )
        {
            this.context = context;
            this.contextAcessor = contextAccessor;
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = context.Set<Pedido>().Where(p => p.PedidoId == pedidoId).Include(p => p.Itens).ThenInclude(t => t.Produto) .SingleOrDefault();
            if(pedido == null)
            {
                pedido = new Pedido();
                context.Set<Pedido>().Add(pedido);
                context.SaveChanges();
            }
            return pedido;
        }

        private int? GetPedidoId()
        {
            return contextAcessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            contextAcessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }


    }
}
