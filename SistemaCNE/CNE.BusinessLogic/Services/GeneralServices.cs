using System;
using CNE.DataAccess.Repository;
using CNE.Entities.Entities;

namespace CNE.BusinessLogic.Services
{
    public class GeneralServices
    {
        private readonly DepartamentoRepository _departamentosRepository;
        //private readonly MunicipioRepository _municipioRepository;
        //private readonly EstadoCivilRepository _estadoCivilRepository;
        private readonly PersonasRepository _personasRepository;


        public GeneralServices(DepartamentoRepository departamentosRepository/*, MunicipioRepository municipioRepository, EstadoCivilRepository estadoCivilRepository*/, PersonasRepository personasRepository )
        {
            _departamentosRepository = departamentosRepository;
            //    _municipioRepository = municipioRepository;
            //   _estadoCivilRepository = estadoCivilRepository;
            _personasRepository = personasRepository;


        }



        #region Departamento
        public ServiceResult ListadoDepartamentos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.List();
                return result.Ok(list);
            }

            catch (Exception ex)
            {

                return result.Error(ex.Message);
            }
        }





        public ServiceResult InsertarDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.Insert(item);
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



        public ServiceResult ListDepto(string id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.List(id);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex);
            }
        }


        public ServiceResult EditarDepto(tbDepartamentos item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.Update(item);
                if (list.CodeStatus > 0)
                {
                    return result.Ok($"Departamento {item.Dep_Id}  {item.Dep_Descripcion}editado con éxito", list);
                }
                else
                {
                    return result.Error("Y existe un registro con ese nombre");
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex);
            }
        }
        public ServiceResult EliminarDepto(string Dep_Id)
        {
            var result = new ServiceResult();
            try
            {
                var list = _departamentosRepository.Delete(Dep_Id);
                if (list.CodeStatus > 0)
                {
                    return result.Ok($"La accion ha sido existosa", list);
                }
                else
                {
                    return result.Error("No se pudo realizar la accion");
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex);
            }
        }



        #endregion

        #region Personas
        public ServiceResult YaVoto(string DNI)
        {
            var result = new ServiceResult();
            try
            {
                var list = _personasRepository.VotoVerf(DNI);

                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex);
            }
        }
        #endregion
    }
}
