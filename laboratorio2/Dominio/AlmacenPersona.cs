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

        [StringLength(50, ErrorMessage = "El nombre debe tener menos de 50 caracteres")]
        public string NombrePersona { get; set; }
        
        public int EdadPersona { get; set; }

        [StringLength(50, ErrorMessage = "La descricion debe tener menos de 50 caracteres")]
        public string DescripcionPersona { get; set; }
    }
}
