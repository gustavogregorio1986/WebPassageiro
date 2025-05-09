using Microsoft.AspNetCore.Mvc;

namespace WebPassageiro.Controllers
{
    public class AviaoController : Controller
    {
        public IActionResult CadastrarAviao()
        {
            return View();
        }

        public IActionResult ConsultarAviao()
        {
            return View();
        }
    }
}
