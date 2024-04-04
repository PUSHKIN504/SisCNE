using FrontendCNE.Models;
using FrontendCNE.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FrontendCNE.Controllers
{
    public class DepartamentoController1 : Controller
    {
        public DepartamentoService _departamentoServicios;
        public DepartamentoController1(DepartamentoService departamentoServicios)
        {
            _departamentoServicios = departamentoServicios;
        }
        // GET: DepartamentosController
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<DepartamentoViewModel>();
                var list = await _departamentoServicios.ObtenerDepartamentoList();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartamentosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartamentoViewModel item)
        {
            try
            {
                item.Dep_UsuarioCreacion = 1;
                item.Dep_FechaCreacion = DateTime.Now;
                item.Depar_Estado = true;
                var list = await _departamentoServicios.CrearDepartamento(item);
                return RedirectToAction("Index");
                //return View(new List<DepartamentoViewModel> { (DepartamentoViewModel)list.Data } );
            }
            catch (Exception ex)
            {
                return View(item);
            }
        }

    }
}
    

