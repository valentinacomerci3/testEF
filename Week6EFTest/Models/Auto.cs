using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6EFTest.Models
{
    public class Auto : Policy
    {
        //:Polizza
        //plate  displacement
        public String Plate { get; set; }
        public int Displacement { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Plate: {Plate}-Displacement: {Displacement} ";
        }
    }
}
