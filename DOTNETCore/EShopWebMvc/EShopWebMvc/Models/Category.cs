using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShopWebMvc.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage="Category name cannot be empty")]
        [MinLength(3, ErrorMessage = "Minimum 3 character required")]
        public string Name { get; set; }

        [MaxLength(500, ErrorMessage = "Minimum 500 character allowed")]
        public string Description { get; set; }
    }
}
