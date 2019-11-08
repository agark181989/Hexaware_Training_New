using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShopWebMvc.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name cannot be empty")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="Price can not be empty")]
        [Range(1, Double.MaxValue, ErrorMessage ="Invaild price value")]
        public double Price { get; set;}

        
        [Required(ErrorMessage = "Quantity can not be empty")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Invaild quantity value")]
        public int Quantity { get; set; }

        [Required(ErrorMessage ="Brand name is required")]
        public string Brand { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Manufacturing date can not be empty")]
        public DateTime ManufacturingDate { get; set; }

        [Display(Name="Category")]
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
