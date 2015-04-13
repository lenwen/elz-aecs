using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aecs.srv.server
{
    public class Starter
    {
        public bool Debug { get; set; }
        public bool RunningModeConsole { get; set; }

        public bool RunningModeService { get; set; }

        public Starter()
        {

            this.Debug = false;
            this.RunningModeConsole = false;
            this.RunningModeService = false;
        }


        public void Run()
        {

            Console.WriteLine("applikation is starting");

            //TODO 5    Check starting values

            //TODO  5   Check configurationfile

            //TODO 5    Start applikation
            
        }

        
    }
}
