using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Jedi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Locations { get; set; }
        public string Rank { get; set; }
        public string Padawan { get; set; }
        public string Way { get; set; }
        public string Abilities { get; set; }

        public Jedi()
        {
        }

        public Jedi(int id, string name, string locations, string rank, string padawan, string way, string abilities)
        {
            Id = id;
            Name = name;
            Locations = locations;
            Rank = rank;
            Padawan = padawan;
            Way = way;
            Abilities = abilities;
        }
    }
}
