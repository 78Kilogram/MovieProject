using MovieProject.Model.Abtract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieProject.Model.Models
{
    [Table("Category")]
    public class Category:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { set; get; }
        [Required]
        [MaxLength(100)]
        public string NameCategory { set; get; }
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        public bool? Homeflag { set; get; }
        public virtual IEnumerable<Movie> Movies { set; get; }
    }
}
