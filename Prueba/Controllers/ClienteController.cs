using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.models;
using MyApp;

namespace Prueba.Controllers
{
    public class ClienteController : Controller
    {
        private readonly List<CLiente> clientes;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AltaCliente(int i, string n, string des, int t, string d)
        {
            Cliente cliente_ = new Cliente(i,n,des,t,d);
            clientes.Add(cliente_);
            return Redirect("Index");
        }

    }
}
