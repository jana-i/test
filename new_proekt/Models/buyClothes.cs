using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace new_proekt.Models
{
    public class buyclothes
    {
        public clothes clothes { get; set; }
        public List<client> clients { get; set; }
        public buyclothes()
        {
            clients = new List<client>();
        }
    }
}