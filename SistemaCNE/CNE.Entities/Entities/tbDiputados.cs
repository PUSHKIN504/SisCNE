﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace CNE.Entities.Entities
{
    public partial class tbDiputados
    {
        public tbDiputados()
        {
            tbVotosPorDiputados = new HashSet<tbVotosPorDiputados>();
        }

        public int Dip_Id { get; set; }
        public int? Dip_Votos { get; set; }
        public string Dip_ImgUrl { get; set; }
        public int Dip_UsuarioCreacion { get; set; }
        public DateTime Dip_FechaCreacion { get; set; }
        public int? Dip_UsuarioModificacion { get; set; }
        public DateTime? Dip_FechaModificacion { get; set; }
        public bool? Dip_Estado { get; set; }
        public int? Par_id { get; set; }

        public virtual tbPersonas Dip { get; set; }
        public virtual tbUsuarios Dip_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Dip_UsuarioModificacionNavigation { get; set; }
        public virtual tbPartidos Par { get; set; }
        public virtual ICollection<tbVotosPorDiputados> tbVotosPorDiputados { get; set; }
    }
}