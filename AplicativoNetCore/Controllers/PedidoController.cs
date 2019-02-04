using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicativoNetCore.repository;
using AppEntity;
using Microsoft.AspNetCore.Mvc;
using Objetos;

namespace AplicativoNetCore.Controllers
{
    public class PedidoController : Controller
    {

        private readonly ApplicationContext context;
        private readonly IItemPedidoRepository itemPedidoRepository;

        public PedidoController(ApplicationContext context, IItemPedidoRepository itemPedidoRepository)
        {
            this.context = context;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public IActionResult Carrossel()
        {
            var produtos = context.Set<Produto>().ToList();
            return View(produtos);
        }

        public IActionResult Carrinho(string codigoProduto)
        {
            var pedido = itemPedidoRepository.AddItemPedido(codigoProduto);
            return View(pedido);
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Resumo()
        {
            return View();
        }

    }
}