using AutoMapper;
using CNE.BusinessLogic.Services;
using CNE.Common.Models;
using CNE.Entities.Entities;
using Microsoft.AspNetCore.Http;
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
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly IMapper _mapper;
        public VotacionesController(GeneralServices generalServices, IMapper mapper, VotacionesServices votacionesServices, IHttpContextAccessor httpContextAccessor)
        {
            _generalServices = generalServices;
            _votacionesServices = votacionesServices;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("InfoVotante/{DNI}")]
        public IActionResult List(string DNI)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            session.SetString("DNI", DNI);
            var list = _generalServices.YaVoto(DNI);
            return Json(list);
        }

        [HttpGet("Presidentes/List")]
        public IActionResult PreList()
        {
            var list = _votacionesServices.ListadoPresi();
            return Json(list);
        }
        [HttpGet("Alcaldes/List/{DNI}")]
        public IActionResult AlList(string DNI)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            session.SetString("DNI", DNI);
            var list = _votacionesServices.ListAlc(session.GetString("DNI"));
            return Json(list);
        }
        [HttpPost("Voto/Create")]
        public IActionResult Insert(VotoViewModel item)
        {
            var model = _mapper.Map<tbVotos>(item);
            var modelo = new tbVotos()
            {
                Pre_Id = item.Pre_Id,
                Mes_Id = item.Mes_Id,
                Alc_Id = item.Alc_Id,
            };
            var list = _votacionesServices.InsertarVoto(modelo);
            return Ok(list);
        }
    }
}
