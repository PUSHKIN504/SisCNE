﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNE.Common.Models
{
    class AlcaldesViewModel
    {
        public int Alc_Id { get; set; }
        public int? Alc_Votos { get; set; }
        public string Alc_ImgUrl { get; set; }
        public int Alc_UsuarioCreacion { get; set; }
        public DateTime Alc_FechaCreacion { get; set; }
        public int? Alc_UsuarioModificacion { get; set; }
        public DateTime? Alc_FechaModificacion { get; set; }
        public bool? Alc_Estado { get; set; }
        [NotMapped]
        public int? Par_id { get; set; }
        [NotMapped]
        public string Par_ImgUrl { get; set; }
        [NotMapped]
        public string Per_Nombre { get; set; }
        [NotMapped]
        public string Per_Apellido { get; set; }
    }
}
