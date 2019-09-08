using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieProject.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SlideID { set; get; }
        public string Name { set; get; }
        public string Desciption { set; get; }
        [Required]
        public string Image { set; get; }
        [Required]
        public string Url { set; get; }
        public bool? Status { set; get; }
    }
}
