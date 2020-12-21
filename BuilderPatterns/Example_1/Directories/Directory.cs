using BuilderPatterns.LAB_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns.LAB_1.Directories
{
    public class Directory
    {


        // Do not confuse it with the constructor method in OOP anyway, the name of the constructor in oop is in the name of the class.
        public void Constructor(IBuilder builder)
        {
            builder.Hamburger();
         
            builder.ChickenBurger();

        }
    }
}
