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
        
        public int IdPersona { get; set; }

        
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(50,ErrorMessage ="El nombre debe tener menos de 50 caracteres")]
        public string Nombre { get; set; }

        
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(18,80,ErrorMessage ="No Cumple con la edad necesaria")]
        public int Edad { get; set; }
        

        
        [Required(ErrorMessage = "Este campo  es obligatorio")]
        [StringLength(50, ErrorMessage = "La descricion debe tener menos de 50 caracteres")]
        public string Descripcion { get; set; }


        public AlmacenViewModels(AlmacenPersona alp)
        {
            this.IdPersona = alp.IdPersona;
            this.Nombre = alp.NombrePersona;
            this.Edad = alp.EdadPersona;
            this.Descripcion = alp.DescripcionPersona;
        }

        public AlmacenViewModels()
        {

        }
    }

}
