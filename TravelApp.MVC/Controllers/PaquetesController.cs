using Microsoft.AspNetCore.Mvc;
using TravelApp.MVC.Models;
using TravelApp.MVC.Services;

namespace TravelApp.MVC.Controllers
{
    public class PaquetesController : Controller
    {
        private readonly ApiService _apiService;

        public PaquetesController(ApiService apiService)
        {
            _apiService = apiService;
        }

        // GET: Paquetes
        public async Task<IActionResult> Index()
        {
            var paquetes = await _apiService.GetPaquetesAsync();
            return View(paquetes);
        }

        // GET: Paquetes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var paquete = await _apiService.GetPaqueteAsync(id);
            if (paquete == null)
            {
                return NotFound();
            }
            return View(paquete);
        }

        // GET: Paquetes/Create
        public async Task<IActionResult> Create()
        {
            var ciudades = await _apiService.GetCiudadesAsync();
            ViewBag.Ciudades = ciudades;
            return View();
        }

        // POST: Paquetes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Paquete paquete)
        {
            if (ModelState.IsValid)
            {
                var success = await _apiService.CreatePaqueteAsync(paquete);
                if (success)
                {
                    TempData["Success"] = "Paquete registrado exitosamente";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Error al registrar el paquete");
                }
            }

            var ciudades = await _apiService.GetCiudadesAsync();
            ViewBag.Ciudades = ciudades;
            return View(paquete);
        }
    }
}