using MovieProject.Model.Abtract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieProject.Model.Models
{
    [Table("Movies")]
    public class Movie : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieID { set; get; }
        [Required]
        [MaxLength(100)]
        public string Name { set; get; }
        [Required]
        public string Image { set; get; }
        [Column(TypeName ="xml")]
        public string MoreImage { set; get; }
        public string Actor { set; get; }
        public string Description { set; get; }
        public string Directors { set; get; }
        public string Time { set; get; }
        public int? Year { set; get; }
        public string Country { set; get; }
        public string Tags { set; get; }
        [Required]
        public string MovieLink { set; get; }
        [Required]
        public string TrailerLink { set; get; }
        [Required]
        public int CategoryID { set; get; }

        public int? Rate { set; get; }
        [Required]
        public int TrailerID { set; get; }
        public int Viewed { set; get; }
        [Column(TypeName="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        
        public bool? Homeflag { set; get; }
        public bool? Hotflag { set; get; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { set; get; }
        [ForeignKey("TrailerID")]
        public virtual Trailer Trailer { set; get; }

    }
}
