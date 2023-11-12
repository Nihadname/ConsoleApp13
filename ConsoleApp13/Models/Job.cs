using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    internal class Job
    {
        public string Name;
        protected string Description;
       private int _WorkingHours;
        public int WorkingHours {
            get
            {
                if(_WorkingHours >12)
                {
                    Console.WriteLine("bu cetin isdir");
                  

                }
                return _WorkingHours;
            }
            set { _WorkingHours = value; }
        
        }
        public void Test()
        {
            Console.WriteLine(Name);
        }
        public void Test2()
        {
            Console.WriteLine(Description);
        }
        public void Test3()
        {
            Console.WriteLine(WorkingHours);
        }

    }
}
