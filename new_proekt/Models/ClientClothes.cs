using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace new_proekt.Models
{
    public class ClientClothes
    {
        public clothes clothing { get; set;}
        public List<client> Clients { get; set; }
        public int ClothesID { get; set; }
        public int ClientID { get; set; }

    }
}