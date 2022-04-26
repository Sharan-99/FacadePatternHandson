using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternLibrary
{
    public class Circle : Shape 
    {
        public void Draw()
        {
            Console.WriteLine("Circle drawn...");
        }
    }
}
