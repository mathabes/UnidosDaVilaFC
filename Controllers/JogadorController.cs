using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnidosDaVilaFC.Models;

namespace UnidosDaVilaFC.Controllers
{
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }
        public IActionResult Jogadores()
        {
            List<Jogador> jogadores = new List<Jogador>
        {
            new Jogador(1, "Neymar", new DateTime(1990, 2, 5), 1000000, "Brasileiro", "Atacante", "Drible", "Titular"),
            new Jogador(2, "Messi", new DateTime(1988, 7, 8), 5000000, "Argentina", "Meia", "Visão", "Titular"),
            new Jogador(3, "Oblak", new DateTime(1995, 9, 10), 2100000, "Eslovenia", "Goleiro", "Agilidade", "Titular"),
            new Jogador(4, "Murilo", new DateTime(1997, 3, 6), 4100000, "Paraguai", "Defensor", "Marcação", "Titular")
        };

            return View(jogadores);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
