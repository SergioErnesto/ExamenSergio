using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial_I_Sergio_Lopez.Models
{
    public class Producto
    {
        [Key]
        [StringLength(99999,MinimumLength =1,ErrorMessage ="Rango 1 a 99999")]
        public int ProductoID { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Ingrese entre 3 a 30 caracteres")]
        public string Description { get; set; }
        [Required]
        public DataType Currency { get; set; }
        public DataType Fecha { get; set; }
    }
}