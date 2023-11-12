using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    internal class Company:Job
    {
        public void FullInfo()
        {
            Console.WriteLine($"{Name}{Description}{WorkingHours}");
        }
       
    }
}
