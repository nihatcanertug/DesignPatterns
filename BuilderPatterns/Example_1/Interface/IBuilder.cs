using BuilderPatterns.LAB_1.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns.LAB_1.Interface
{
    public interface IBuilder
    {
        void Hamburger();
        void ChickenBurger();

        Product GetProduct();
    }
}
