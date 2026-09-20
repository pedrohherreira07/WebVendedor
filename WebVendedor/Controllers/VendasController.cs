using Microsoft.AspNetCore.Mvc;

namespace WebVendedor.Controllers
{
    public class VendasController : Controller
    {
        public IActionResult RealizarVenda()
        {
            ViewBag.Titulo = "Realizar vendas";
            ViewBag.SubTitulo = "Realize suas vendas";
            return View();
        }
    }
}
