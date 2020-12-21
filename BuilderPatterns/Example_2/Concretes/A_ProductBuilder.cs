
using BuilderPatterns.LAB_2.Abstracts;
using BuilderPatterns.LAB_2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns.LAB_2.Concretes
{
    public class A_ProductBuilder : ProductBuilder
    {
        ProductModel model = new ProductModel();
        public override void ApplyDiscount()
        {
            model.DiscountPrice = model.UnitPrice * (decimal)0.90;
            model.DiscountedAppliyed = true;
        }

        public override ProductModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1000;
            model.ProductName = "Lüfer";
            model.UnitPrice = 30;
        }
    }
}
