using Microsoft.AspNetCore.Mvc;
using RegistroYLoginPost.Models;
using RegistroYLoginPost.Repositories;

namespace RegistroYLoginPost.Controllers
{
    public class UsuariosController : Controller
    {
        private RepositoryUsuarios repo;

        public UsuariosController(RepositoryUsuarios repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register
            ( string email, string password)
        {
            Usuario user = new Usuario();
            string fileName = user.IdUsuario.ToString();

            await this.repo.RegisterUser( email, password);
            ViewData["MENSAJE"] = "Usuario regristado correctamente";
            return View();
        }
    }
}
