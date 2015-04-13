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
        public bool DebugEnable { get; set; }
        public bool RunningModeConsole { get; set; }

        public bool RunningModeService { get; set; }

        public Starter()
        {

            this.DebugEnable = false;
            this.RunningModeConsole = false;
            this.RunningModeService = false;
        }


        public void Run()
        {
            //  temp fix for debug. remove when debug class is done.
            Debug.DebugEnable = this.DebugEnable;

            var runApplication = true;

            Debug.Notic("Application is starting");
            

            //TODO 5    Check starting values
            #region Check starting values
            Debug.Notic("Checking starting values");
            if ((this.RunningModeConsole) && (this.RunningModeService))
            {
                runApplication = false;

            }

            #endregion


            if (runApplication)
            {
                
            }

            //System.Threading.Thread.CurrentThread.Abort();
            //if (this.Debug)
            //    Console.WriteLine("FEL....");


            //TODO  5   Check configurationfile

            //TODO 5    Start applikation





        }

        public static class  Debug
        {
            public static bool DebugEnable { get;set; }
            
            public static void Error(string text)
            {
                if (DebugEnable)
                    Console.WriteLine(DateTime.Now +  " - Starter - " + text);
            }
            public static void Warning(string text)
            {
                if (DebugEnable)
                    Console.WriteLine(DateTime.Now + " - Starter - " + text);
            }
            public static void Notic(string text)
            {
                if (DebugEnable)
                    Console.WriteLine(DateTime.Now + " - Starter - " + text);
            }
             
        }
        
    }
}
