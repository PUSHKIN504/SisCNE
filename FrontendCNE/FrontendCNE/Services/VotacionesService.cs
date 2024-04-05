using FrontendCNE.Models;
using FrontendCNE.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendCNE.Services
{
    public class VotacionesService
    {
        private readonly API _api;

        public VotacionesService(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> ObtenerYaVoto(string DNI)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PersonasViewModel>, PersonasViewModel>(req =>
                {
                    req.Path = $"API/Votaciones/InfoVotante?DNI={DNI}";
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
