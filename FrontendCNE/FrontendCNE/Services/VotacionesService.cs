using FrontendCNE.Models;
using FrontendCNE.WebAPI;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendCNE.Services
{
    public class VotacionesService
    {
        private readonly API _api;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VotacionesService(API api, IHttpContextAccessor httpContextAccessor)
        {
            _api = api;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ServiceResult> ObtenerYaVoto(string DNI)
        {
            var session = _httpContextAccessor.HttpContext.Session;
            var result = new ServiceResult();

            try
            {
                session.SetString("DNI", DNI);
                var response = await _api.Get<IEnumerable<PersonasViewModel>, PersonasViewModel>(req =>
                {
                    req.Path = $"API/Votaciones/InfoVotante?DNI={session.GetString("DNI")}";
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

        public async Task<ServiceResult> CrearVoto(VotoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<VotoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/Voto/Create?Mes_Id={item.Mes_Id}&Pre_Id={item.Pre_Id}&Alc_Id={item.Alc_Id}";
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
