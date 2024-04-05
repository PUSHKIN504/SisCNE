using FrontendCNE.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendCNE.Controllers
{
    public class PresidenteController : Controller
    {
        
        public PresidenteService _presidenteServicios;
        public PresidenteController(PresidenteService presidenteServicios)
        {
            _presidenteServicios = presidenteServicios;
        }
        public IActionResult Index()
        {
            return View("~/Views/Votacion/Presidentes.cshtml");
        }

        [HttpGet("Presidentes/List")]
        public async Task<IActionResult> PreList()
        {
            try
            {
                var model = await _presidenteServicios.PresList();
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
