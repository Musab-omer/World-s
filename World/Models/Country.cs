using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public char Code { get; set; }
        public int  RegionId { get; set; }
        public Region Region { get; set; }
        public List<State> States { get; set; }
    }
}
