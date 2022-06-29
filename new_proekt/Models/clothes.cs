using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace new_proekt.Models
{
    public class clothes
    {
        public clothes()
        {
            Clients = new List<client>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        [Display(Name = "Item Code")]
        public string ItemCode { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "The Image URL")]
        public string ImageURL { get; set; }
        public virtual ICollection<client> Clients { get; set; }
    }
}