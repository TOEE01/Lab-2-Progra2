using laboratorio2.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio2.ViewModels
{
    public class AlmacenViewModels
    {
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public int IdPersona { get; set; }

        [Display]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NombrePersona { get; set; }

        [Display]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int EdadPersona { get; set; }

        [Display]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string DescripcionPersona { get; set; }


        public AlmacenViewModels(AlmacenPersona alp)
        {
            this.IdPersona = alp.IdPersona;
            this.NombrePersona = alp.NombrePersona;
            this.EdadPersona = alp.EdadPersona;
            this.DescripcionPersona = alp.DescripcionPersona;
        }


    }
}
