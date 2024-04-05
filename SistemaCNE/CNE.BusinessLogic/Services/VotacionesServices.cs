using CNE.DataAccess.Repository;
using CNE.Entities.Entities;
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
        private readonly VotoRepository _votoRepository;


        public VotacionesServices(PresidenteRepository presidenteRepository, VotoRepository votoRepository/*, MunicipioRepository municipioRepository, EstadoCivilRepository estadoCivilRepository*/)
        {
            _presidenteRepository = presidenteRepository;
            //    _municipioRepository = municipioRepository;
            //   _estadoCivilRepository = estadoCivilRepository;
            _votoRepository = votoRepository;


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

        #region Voto
        public ServiceResult InsertarVoto(tbVotos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _votoRepository.Insert(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok(list);
                }
                else
                {
                    return result.Error(list);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion
    }
}
