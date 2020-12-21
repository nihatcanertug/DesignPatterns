using BuilderPatterns.LAB_1.Delegate;
using BuilderPatterns.LAB_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns.LAB_1.Concretes
{
    public class Builder_1 : IBuilder
    {
        private Product product = new Product();
        public void Hamburger()
        {
            product.Add("Meat");
        }

        public void ChickenBurger()
        {
            product.Add("Chicken");
        }


        public Product GetProduct()
        {
            return product;
        }
    }
}
