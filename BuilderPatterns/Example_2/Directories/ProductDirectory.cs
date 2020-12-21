using BuilderPatterns.LAB_2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns.LAB_2.Directories
{
    public class ProductDirectory
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.GetModel();
            productBuilder.ApplyDiscount();
        }
    }
}
