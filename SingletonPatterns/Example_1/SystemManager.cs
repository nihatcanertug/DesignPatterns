using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatterns.LAB_1
{
    public class SystemManager
    {
        private static SystemManager _systemManager;       // we defined the field

        private SystemManager()
        {
            // The purpose is to disable external access
        }

        // This method acts as our main singleton object creator
        public static SystemManager CreateSingletonObject()
        {
            if (_systemManager==null)
            {
                // If the systemManager object is null, that is, if it's hollow, come to me and create the object.
                _systemManager = new SystemManager();
            }
            // None if it is not null means it was created before.
            return _systemManager;
            // return this created object to me.
        }
        public void SystemMessage()
            {
            Console.WriteLine("I'm Singleton Pattern..!");
            Console.ReadKey();
            }
        
    }
}
