using SingletonPatterns.LAB_1;
using SingletonPatterns.LAB_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: In Lab applications, we cannot generate the class with the new keyword outside the class. This is because we will produce objects with singleton and in this context we have closed the constructor private for external access and we did not contradict the singleton.      

            #region LAB_1
            var systemManager = SystemManager.CreateSingletonObject();
            systemManager.SystemMessage();
            #endregion

            #region LAB_2   
            int Multiply= SingletonClass.Sınıf.Multiply(10, 15);
            Console.WriteLine(Multiply);
            Console.ReadKey();
            #endregion

        }
    }
}
