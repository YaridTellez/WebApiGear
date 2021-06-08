using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class PersonModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="varchar(45)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(45)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Email { get; set; }        
        
        [Required]
        public int Phone { get; set; }
        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(45)")]
        public string Password { get; set; }
    }
}
