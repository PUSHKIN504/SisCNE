﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace CNE.Entities.Entities
{
    public partial class tbPartidos
    {
        public tbPartidos()
        {
            tbAlcaldes = new HashSet<tbAlcaldes>();
            tbDiputados = new HashSet<tbDiputados>();
            tbPresidentes = new HashSet<tbPresidentes>();
        }

        public int Par_id { get; set; }
        public string Par_Nombre { get; set; }
        public string Par_ImgUrl { get; set; }
        public int Par_UsuarioCreacion { get; set; }
        public DateTime Par_FechaCreacion { get; set; }
        public int? Par_UsuarioModificacion { get; set; }
        public DateTime? Par_FechaModificacion { get; set; }
        public bool? Par_Estado { get; set; }

        public virtual tbUsuarios Par_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Par_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbAlcaldes> tbAlcaldes { get; set; }
        public virtual ICollection<tbDiputados> tbDiputados { get; set; }
        public virtual ICollection<tbPresidentes> tbPresidentes { get; set; }
    }
}