using Microsoft.AspNetCore.Mvc;
using TravelApp.MVC.Models;
using TravelApp.MVC.Services;

namespace TravelApp.MVC.Controllers
{
    public class PasajesController : Controller
    {
        private readonly ApiService _apiService;

        public PasajesController(ApiService apiService)
        {
            _apiService = apiService;
        }

        // GET: Pasajes
        public async Task<IActionResult> Index()
        {
            var pasajes = await _apiService.GetPasajesAsync();
            return View(pasajes);
        }

        // GET: Pasajes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var pasaje = await _apiService.GetPasajeAsync(id);
            if (pasaje == null)
            {
                return NotFound();
            }
            return View(pasaje);
        }

        // GET: Pasajes/Create
        public async Task<IActionResult> Create()
        {
            var ciudades = await _apiService.GetCiudadesAsync();
            ViewBag.Ciudades = ciudades;
            return View();
        }

        // POST: Pasajes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pasaje pasaje)
        {
            if (ModelState.IsValid)
            {
                var success = await _apiService.CreatePasajeAsync(pasaje);
                if (success)
                {
                    TempData["Success"] = "Pasaje creado exitosamente";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("", "Error al crear el pasaje");
                }
            }

            var ciudades = await _apiService.GetCiudadesAsync();
            ViewBag.Ciudades = ciudades;
            return View(pasaje);
        }
    }
}