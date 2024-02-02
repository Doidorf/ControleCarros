using Microsoft.AspNetCore.Mvc;

namespace ControleCarros.Controllers
{
    public class CarrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();

        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        public IActionResult FiltrarCategoria()
        {
            return View();
        }

        public IActionResult FiltrarValor()
        {
            return View();
        }
    }
}
