using AppEntity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicativoNetCore.repository
{
    public class PedidoRepository
    {
        private readonly ApplicationContext context;
        private readonly IHttpContextAccessor contextAcessor;
        public PedidoRepository(ApplicationContext context, IHttpContextAccessor contextAccessor )
        {
            this.context = context;
            this.contextAcessor = contextAccessor;
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
