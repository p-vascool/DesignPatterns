using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        public string InstanceName { get; set; }
        public Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new();
            return instance;
        }
    }
}
