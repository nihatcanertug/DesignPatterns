using BuilderPatterns.LAB_1.Concretes;
using BuilderPatterns.LAB_1.Delegate;
using BuilderPatterns.LAB_1.Directories;
using BuilderPatterns.LAB_1.Interface;
using BuilderPatterns.LAB_2.Abstracts;
using BuilderPatterns.LAB_2.Concretes;
using BuilderPatterns.LAB_2.Directories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LAB_1
            Directory directory = new Directory();
            IBuilder builder_1 = new Builder_1();
            IBuilder builder_2 = new Builder_2();

            directory.Constructor(builder_1);
            Product p_1 = builder_1.GetProduct();
            p_1.Display();
            Console.ReadKey();

            directory.Constructor(builder_2);
            Product p_2 = builder_2.GetProduct();
            p_2.Display();
            #endregion

            #region LAB_2
            ProductDirectory productDirectory = new ProductDirectory();
            ProductBuilder productBuilder = new A_ProductBuilder();
            productDirectory.GenerateProduct(productBuilder);

            var model = productBuilder.GetModel();
            Console.WriteLine(model.Id);
            Console.WriteLine(model.ProductName);
            Console.WriteLine(model.UnitPrice);
            Console.WriteLine(model.DiscountPrice);
            Console.WriteLine(model.DiscountedAppliyed);
            #endregion

           


            Console.ReadKey();
        }
    }
}
