using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace new_proekt.Models
{
    public class client
    {
        public client()
        {
            clothes = new List<clothes>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Clubcard { get; set; }
        [Range(18,99,ErrorMessage ="Age must be between 18 and 99")]
        public int Age { get; set; }
        public bool IsSubscribed { get; set; }
        public ICollection<clothes> clothes { get; set; }
    }
}