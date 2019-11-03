using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    public abstract class IDuck
    {
        public void swim()
        {
            Console.WriteLine("SWIM!!");
        }

        public abstract void display();
        
    }
}
