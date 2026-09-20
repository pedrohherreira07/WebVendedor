using Microsoft.AspNetCore.Mvc;

namespace WebVendedor.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult GerenciarClientes()
        {
            ViewBag.Titulo = "Gerencie seus clientes";
            ViewBag.SubTitulo = "Aqui você poderá cadastrar todos os seus clientes";
            return View();
        }
    }
}
