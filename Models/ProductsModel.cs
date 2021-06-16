using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGear.Models
{
    public class ProductsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }
        [Required, StringLength(150)]
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal ProductPrice { get; set; }
        [Required]
        public int ProductStock { get; set; }
        [Required, ForeignKey(nameof(CategoryName))]
        public int IdCategory { get; set; }

        public virtual CategoryModel CategoryName { get; set; }
    }
}
