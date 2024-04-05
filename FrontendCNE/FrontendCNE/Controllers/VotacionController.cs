﻿using FrontendCNE.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendCNE.Controllers
{
    public class VotacionController : Controller
    {
        public VotacionesService _VotacionesServicios;
        public VotacionController(VotacionesService VotacionesServicios)
        {
            _VotacionesServicios = VotacionesServicios;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Votaciones/InfoVotante/{DNI}")]
        public async Task<IActionResult> YaVoto(string DNI)
        {
            try
            {
                var model = await _VotacionesServicios.ObtenerYaVoto(DNI);
                return Json(model.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
