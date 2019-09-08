using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieProject.Model.Models
{
    [Table("Ads")]
   public class Ads
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdsID { set; get; }
        [Required]
        [MaxLength(100)]
        public string NameAds { set; get; }
        [Required]
        public string ImageAds { set; get; }
        [Required]
        public string UrlAds { set; get; }
    }
}
