using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnidosDaVilaFC.Models;

namespace UnidosDaVilaFC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Jogadores()
        {
 
            List<Jogador> jogadores = new List<Jogador>
        {
            new Jogador(1, "Neymar", new DateTime(1992, 2, 5), 100000, "Brasileiro", "Atacante", "Ataque", "Titular"),
            new Jogador(1, "Messi", new DateTime(1992, 2, 5), 100000, "Argentina", "Meio-Campo", "Meio-Campo", "Titular"),
            new Jogador(1, "Oblak", new DateTime(1992, 2, 5), 100000, "Eslovenia", "Goleiro", "Goleiro", "Titular"),
            new Jogador(1, "Murilo", new DateTime(1992, 2, 5), 100000, "Paraguai", "Zageiro", "Defesa", "Titular"),



        };

            return View(jogadores);
        }



        public IActionResult Tecnico()
        {
            Tecnico tecnico = new Tecnico(1 , 15 , "Ofensiva" , "Abel ferreira", new DateTime(1992, 2, 5), 20000, "Português");


            return View(tecnico);
        }


        public IActionResult Patrocinios()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
