using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Modelos
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Nombre es requerido")]
        [MaxLength(60,ErrorMessage ="Nombre debe de ser maximo de 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripcion es requerido")]
        [MaxLength(150,ErrorMessage ="descripcion debe ser maximo de 150 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Estado es requerido")]
        public bool Estado { get; set; }

    }
}
