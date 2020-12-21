using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatterns.LAB_2
{
    public class SingletonClass
    {
        // By making the Constructor private, we prevented this class from being instantiated from outside.    
        private SingletonClass()
        {

        }

        private static SingletonClass _singleObje = new SingletonClass();
        // We defined a property to provide external access to the static object (_singleObje) we created.

        public static SingletonClass Sınıf
        {
            get { return _singleObje; }
        }

            public int Multiply(int s1,int s2)
        {
            return s1 * s2;
        }

       
    }
}
