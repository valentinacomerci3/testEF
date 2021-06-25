using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6EFTest.Models
{
    public class Furto : Policy
    {
        //:polizza
        public int Coverage { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Coverage: {Coverage}";
        }
    }
}
