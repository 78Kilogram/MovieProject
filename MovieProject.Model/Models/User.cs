using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieProject.Model.Models
{
    [Table("Users")]
     public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Password { set; get; }
    }
}
