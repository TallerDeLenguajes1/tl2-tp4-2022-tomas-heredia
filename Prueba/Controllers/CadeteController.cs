using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MyApp;

namespace Prueba.Controllers
{
    public class CadeteController : Controller
    {
        private readonly ILogger<CadeteController> _logger;
        private readonly List<Cadete> cadetes;

        public CadeteController(ILogger<CadeteController> logger, List<Cadete> cadetes)
        {
            _logger = logger;
            this.cadetes = cadetes;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


    [HttpPost]
        public IActionResult addCadete(int i, string n, string des, int t){
            Cadete cadete_ = new Cadete(i,n,des,t);
            i++;
            cadetes.Add(cadete_);
            return Redirect("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}