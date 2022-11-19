using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Models
{
    public class City
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string AName { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
