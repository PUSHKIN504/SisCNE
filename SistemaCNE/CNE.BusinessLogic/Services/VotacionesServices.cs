using CNE.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNE.BusinessLogic.Services
{
    public class VotacionesServices
    {
        private readonly PresidenteRepository _presidenteRepository;
        //private readonly MunicipioRepository _municipioRepository;
        //private readonly EstadoCivilRepository _estadoCivilRepository;


        public VotacionesServices(PresidenteRepository presidenteRepository/*, MunicipioRepository municipioRepository, EstadoCivilRepository estadoCivilRepository*/)
        {
            _presidenteRepository = presidenteRepository;
            //    _municipioRepository = municipioRepository;
            //   _estadoCivilRepository = estadoCivilRepository;


        }

        #region Presidentes

        public ServiceResult ListadoPresi()
        {
            var result = new ServiceResult();
            try
            {
                var list = _presidenteRepository.List();
                return result.Ok(list);
            }

            catch (Exception ex)
            {

                return result.Error(ex.Message);
            }
        }
        #endregion
    }
}
