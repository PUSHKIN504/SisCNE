using FrontendCNE.Models;
using FrontendCNE.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendCNE.Services
{
    public class DepartamentoService
    {
        private readonly API _api;

        public DepartamentoService(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerDepartamentoList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<DepartamentoViewModel>, IEnumerable<DepartamentoViewModel>>(req =>
                {
                    req.Path = $"API/Departamento/List";
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }

        public async Task<ServiceResult> CrearDepartamento(DepartamentoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<DepartamentoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Departamento/Create";
                    req.Content = item;
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }
    }
}
