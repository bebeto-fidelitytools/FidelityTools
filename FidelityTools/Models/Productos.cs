using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FidelityTools.Models
{
    public class Productos
    {
        [StringLength(50)]
        public int id { get; set; }
        [Required]
        [StringLength(50), MinLength(3),  ]
        public string nombre { get; set; }

        [Required]
        public int stock { get; set; }
        [Required] 
        public decimal precio { get; set; }
        [Required]

        public int idCategoria { get; set; }
      

    }
}
