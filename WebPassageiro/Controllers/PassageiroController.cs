using Microsoft.AspNetCore.Mvc;

namespace WebPassageiro.Controllers
{
    public class PassageiroController : Controller
    {
        public IActionResult CadastrarPassageiro()
        {
            return View();
        }

        public IActionResult ConsultarPassageiro()
        {
            return View();
        }
    }
}
