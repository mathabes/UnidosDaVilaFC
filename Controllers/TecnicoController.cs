using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnidosDaVilaFC.Models;

namespace UnidosDaVilaFC.Controllers
{
    public class TecnicoController : Controller
    {
        private readonly ILogger<TecnicoController> _logger;

        public TecnicoController(ILogger<TecnicoController> logger)
        {
            _logger = logger;
        }
        public IActionResult Tecnico()
        {
            Tecnico tecnico = new Tecnico(1, 15, "Ofensiva", "Abel ferreira", new DateTime(1992, 2, 5), 20000, "Português");


            return View(tecnico);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
