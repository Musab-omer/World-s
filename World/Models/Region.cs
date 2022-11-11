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
        public int ContientId { get; set; }
        public Continent Contient { get; set; }
    }
}
