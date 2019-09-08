using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Model.Models
{
    [Table("Trailers")]
    public class Trailer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrailerID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        public string Image { set; get; }
        [Required]
        public string Url { set; get; }
        public virtual IEnumerable<Movie> Movies { set; get; }
    }
}
