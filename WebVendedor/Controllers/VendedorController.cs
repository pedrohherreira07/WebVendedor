using Microsoft.AspNetCore.Mvc;

namespace WebVendedor.Controllers
{
    public class VendedorController : Controller
    {
        public IActionResult MeusDados()
        {
            ViewBag.Titulo = "Meus dados";
            ViewBag.SubTitulo = "Aqui você poderá alterar seus dados";
            return View();
        }

        public IActionResult MinhasVendas()
        {
            ViewBag.Titulo = "Minhas vendas";
            ViewBag.SubTitulo = "Aqui você poderá pesquisar suas vendas";
            return View();
        }

        public IActionResult Acesso()
        {
            return View();
        }

        public IActionResult Inicial()
        {
            ViewBag.Titulo = "Perfil vendedor";
            ViewBag.SubTitulo = "Aqui você poderá cadastrar seus clientes, realizar vendas e consultar seus resultados";
            return View();
        }
    }
}
