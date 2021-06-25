using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6EFTest.Models
{
    public class Life : Policy
    {
        //:Polizza
        public int Years { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Years: {Years}";
        }
    }
}
