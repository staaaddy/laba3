using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    public class Program
    {
        static void Main(string[] args) {
            Invoice invoice = new Invoice(0, "Покупець 1", "suprenet", "234F", 1);
            invoice.Calculate(1000, true);
        }
    }
}