using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace laboratorio2.Dominio
{
    public class AlmacenPersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }

        [Display]
        [Required(ErrorMessage ="Este campo es requerido")]
        public string NombrePersona { get; set; }

        [Display]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int EdadPersona { get; set; }

        [Display]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string DescripcionPersona { get; set; }
    }
}
