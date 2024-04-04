﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace CNE.Entities.Entities
{
    public partial class tbMesas
    {
        public tbMesas()
        {
            tbPersonas = new HashSet<tbPersonas>();
            tbVotos = new HashSet<tbVotos>();
        }

        public int Mes_Id { get; set; }
        public int? Mes_Jurado { get; set; }
        public int? Mes_Custodio1 { get; set; }
        public int? Mes_Custodio2 { get; set; }
        public int Mes_UsuarioCreacion { get; set; }
        public DateTime Mes_FechaCreacion { get; set; }
        public int? Mes_UsuarioModificacion { get; set; }
        public DateTime? Mes_FechaModificacion { get; set; }
        public bool? Mes_Estado { get; set; }
        public int? CeV_Id { get; set; }

        public virtual tbCentrosVotaciones CeV { get; set; }
        public virtual tbEmpleados Mes_Custodio1Navigation { get; set; }
        public virtual tbEmpleados Mes_Custodio2Navigation { get; set; }
        public virtual tbEmpleados Mes_JuradoNavigation { get; set; }
        public virtual tbUsuarios Mes_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Mes_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPersonas> tbPersonas { get; set; }
        public virtual ICollection<tbVotos> tbVotos { get; set; }
    }
}