using Microsoft.AspNetCore.Mvc;
using U2_Animales.Models.Entities;
using U2_Animales.Models.ViewModels;

namespace U2_Animales.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = new AnimalesContext();
            var vm = context.Clase
            .Select(x => new IndexViewModel()
            {
                Id = x.Id,
                Clase = x.Nombre ?? "Sin nombre",
                Description = x.Descripcion
            }).ToList();
            return View(vm);
        }
    }
}
