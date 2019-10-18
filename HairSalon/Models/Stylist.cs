using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId {get;set;}
        public string Name {get;set;}
        public string Specialties {get;set;}
        public int Price {get;set;}
        public virtual ICollection<Client> clientCollect {get;set;}
        public Stylist()
        {
            this.clientCollect = new HashSet<Client>{};
        }
    }
}