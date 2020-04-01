using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50, MinimumLength =3,ErrorMessage ="The name must have from 3 to 50 characters")]
        public string Name { get; set; }

        [StringLength(256,ErrorMessage ="The description must not exceed 256 characters")]
        [Display(Name="Descripción")]
        public string Description { get; set; }

        public Boolean State { get; set; }
    }
}
