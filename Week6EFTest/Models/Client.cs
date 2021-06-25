using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6EFTest.Models
{
    public class Client 
    {
        //cf name lastname address
        public int CF { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }

        public ICollection<Policy> Policies { get; set; } = new List<Policy>();

        public override string ToString()
        {
            return $"{CF} - {Name}- {Lastname}-{Address}";
        }

    }
}
