﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FidelityTools.Models
{
    public class Categorias
            {
        
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string nombre { get; set; }
    }
}
