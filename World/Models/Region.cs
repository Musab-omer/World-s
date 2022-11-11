using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public int ContinentId { get; set; }
        public Continent Continent { get; set; }
        public List<Country> Countries { get; set; }
    }
}
