﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNE.DataAccess
{
    public class ScriptsBaseDeDatos
    {
        #region Departamentos
        public static string Departamento_Insertar = "Gral.sp_Departamentos_insertar";
        public static string Departamento_Listar = "Gral.sp_Departamentos_listar";
        public static string Depa_Llenar = "Gral.sp_Departamentos_buscar";
        public static string Depa_Editar = "Gral.sp_Departamentos_actualizar";
        public static string Depa_Eliminar = "Gral.sp_Departamentos_eliminar";

        #endregion

        #region Votaciones
        public static string ObtenerYaVoto = "Vota.sp_Personas_ObtenerSiVoto";

        #endregion
    }
}
