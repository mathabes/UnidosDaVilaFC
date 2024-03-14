using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnidosDaVilaFC.Models;

namespace UnidosDaVilaFC.Controllers
{
    public class PatrocinioController : Controller
    {
        private readonly ILogger<PatrocinioController> _logger;

        public PatrocinioController(ILogger<PatrocinioController> logger)
        {
            _logger = logger;
        }
        public IActionResult Patrocinios()
        {
            List<Patrocinio> patrocinadores = new List<Patrocinio>
            {
                new Patrocinio(1,"https://logosmarcas.net/wp-content/uploads/2020/04/Adidas-Logo.png", "Adidas", 20000000, 2028),
                new Patrocinio(2,"https://logodownload.org/wp-content/uploads/2022/08/blaze-logo-0.png", "Blaze", 500000000, 2024),
                new Patrocinio(3,"https://1000logos.net/wp-content/uploads/2021/05/Sony-logo.png", "Sony", 80000000, 2030)
            };
            return View(patrocinadores);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
