using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    public class IShape
    {
        public string Name { get; set; }
        public IShape(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Shape: " + Name);
        }
    }
}
