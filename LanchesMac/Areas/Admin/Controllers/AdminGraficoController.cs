using LanchesMac.Areas.Admin.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Areas.Admin.Controllers
{
    public class AdminGraficoController : Controller
    {
        private readonly GraficoVendasService _graficoVendasService;

        public AdminGraficoController(GraficoVendasService graficoVendasService)
        {
            _graficoVendasService = graficoVendasService ??
                    throw new ArgumentNullException(nameof(graficoVendasService));
        }

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendasService.GetVendasLanche();
            return Json(lanchesVendasTotais);
        }

        [HttpGet]
        public IActionResult Index(int dias)
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasMensal(int dias)
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasSemanal(int dias)
        {
            return View();
        }
    }
}
