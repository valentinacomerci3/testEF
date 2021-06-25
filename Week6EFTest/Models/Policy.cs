using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6EFTest.Models
{
    abstract public class Policy
    {
        //number date import monthlyfee
        public string NUM { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public double MonthlyFee { get; set; }

        public int? ClientCode { get; set; }
        public Client Client { get; set; }

        public override string ToString()
        {
            return $"{NUM} - {Date} - {Amount} euro- {MonthlyFee} euro";
        }
    }
}
