using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace lr4_1
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger(); 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            log.Error("this is error, u know?");
            log.Info("info, but about?");
            log.Debug("u run ur test, but u r happy?");
            log.Warn("!!!WARNING!!! u lost ur life");
            log.Fatal("u r late. ur happy leave us");

            Console.ReadLine();
        }
    }
}
