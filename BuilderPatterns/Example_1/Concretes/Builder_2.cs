using BuilderPatterns.LAB_1.Delegate;
using BuilderPatterns.LAB_1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns.LAB_1.Concretes
{
    public class Builder_2 : IBuilder
    {
        private Product product = new Product();
        public void Hamburger()
        {
            product.Add("Hamburger:");
            product.Add("Bread");
            product.Add("cheddar");
            product.Add("Onion");
            product.Add("Meat");
            product.Add("Bread");
            product.Add("\n");
        }

        public void ChickenBurger()
        {
            product.Add("Chicken Burger:");
            product.Add("Bread");
            product.Add("mayonnaise");
            product.Add("ketchup");
            product.Add("Chicken");
            product.Add("Bread");
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
