using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PigeonLib;

namespace PigeonCore
{
    class Program
    {
        static void Main(string[] args)
        {
            wl("Starting Pigeon Core...");
            wl("-----------------------------------");
            wl("Configurations");
            wl("-----------------------------------");
            Class1 cls = new Class1();
            wl(cls.getConfigurationDesc());
            Console.ReadLine();
            wl("Checking Nginx Configuration File..");

            
        }
        private static void wl(string data)
        {
            Console.WriteLine(data);
                
        }
           
    }
}
