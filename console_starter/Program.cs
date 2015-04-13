using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aecs.srv.server;

namespace aecs.srv.console_starter
{
    class Program
    {
        static void Main(string[] args)
        {

            aecs.srv.server.Starter aecStarter = new Starter();
            aecStarter.RunningModeConsole = true;
            aecStarter.DebugEnable = true;
            aecStarter.Run();


            Console.WriteLine("Press to exit");
            Console.ReadLine();

        }
    }
}
