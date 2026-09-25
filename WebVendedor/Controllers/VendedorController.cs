using Microsoft.AspNetCore.Mvc;
using WebVendedor.DTO;

namespace WebVendedor.Controllers
{
    public class VendedorController : Controller
    {
        #region Carregar as páginas
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

        #endregion

        #region API 

        [HttpPut("/Vendedor/GravarMeusDados")]

        public async Task<IActionResult> Gravar([FromBody] GravarVendedorDTO objTela)
        {
            if(string.IsNullOrWhiteSpace(objTela.Nome) || string.IsNullOrWhiteSpace(objTela.Telefone) ||
                string.IsNullOrWhiteSpace(objTela.Email) || string.IsNullOrWhiteSpace(objTela.Endereco))
            {
                return BadRequest(new ResponseDTO {Codigo=0, Mensagem="Preencher os campos"});
            }
            
            return Ok();
        }

        #endregion
    }
}
