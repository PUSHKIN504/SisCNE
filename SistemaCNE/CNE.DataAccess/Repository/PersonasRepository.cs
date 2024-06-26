﻿using CNE.BusinessLogic.Services;
using CNE.Entities.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNE.DataAccess.Repository
{
    public class PersonasRepository : IRepository<tbPersonas>
    {
        public RequestStatus Insert(tbPersonas item)
        {
            const string sql = "[Gral].[sp_Departamentos_insertar]";



            using (var db = new SqlConnection(CNEContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                //parametro.Add("@Dep_Id", item.Dep_Id);
                //parametro.Add("@Dep_Descripcion", item.Dep_Descripcion);
                //parametro.Add("@Dep_UsuarioCreacion", item.Dep_UsuarioCreacion);
                //parametro.Add("@Dep_FechaCreacion", item.Dep_FechaCreacion);


                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "Exito" : "Error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }

        }

        public IEnumerable<tbPersonas> List()
        {
            const string sql = "Gral.sp_Departamentos_listar";

            List<tbPersonas> result = new List<tbPersonas>();

            using (var db = new SqlConnection(CNEContext.ConnectionString))
            {
                result = db.Query<tbPersonas>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public tbPersonas VotoVerf(string  DNI)
        {
            tbPersonas result = new tbPersonas();
            using (var db = new SqlConnection(CNEContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Per_CedulaIdentidad", DNI);
                result = db.QueryFirst<tbPersonas>(ScriptsBaseDeDatos.ObtenerYaVoto, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }

        }

        public RequestStatus Delete(tbPersonas item)
        {
            throw new NotImplementedException();
        }

        public tbPersonas Details(int? id)
        {
            throw new NotImplementedException();
        }



        public tbPersonas find(int? id)
        {
            throw new NotImplementedException();
        }



        RequestStatus IRepository<tbPersonas>.Update(tbPersonas item)
        {
            throw new NotImplementedException();
        }
    }
}
