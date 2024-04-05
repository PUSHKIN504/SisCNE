using AutoMapper;
using CNE.BusinessLogic.Services;
using CNE.Common.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNE.API.Controllers
{
    public class VotacionesController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly VotacionesServices _votacionesServices;

        private readonly IMapper _mapper;
        public VotacionesController(GeneralServices generalServices, IMapper mapper, VotacionesServices votacionesServices)
        {
            _generalServices = generalServices;
            _votacionesServices = votacionesServices;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("InfoVotante/{DNI}")]
        public IActionResult List(string DNI)
        {
            var list = _generalServices.YaVoto(DNI);
            return Json(list);
        }

        [HttpGet("Presidentes/List")]
        public IActionResult PreList()
        {
            var list = _votacionesServices.ListadoPresi();
            return Json(list);
        }
    }
}
