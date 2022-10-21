using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.models;
using MyApp;

namespace Prueba.Controllers
{
    public class PedidoController : Controller
    {
        private readonly List<Pedido> pedidos;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AltaPedido(int n, string ob, Cliente c, string e)
        {
            Pedido pedidos_ = new Pedido(n,ob,c,e);
            pedidos.Add(pedidos_);
            return Redirect("Index");
        }

    }
}