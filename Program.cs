// Copyright (c) 2013 Richard Long & HexBeerium
//
// Released under the MIT license ( http://opensource.org/licenses/MIT )
//

using System;
using System.Collections.Generic;
using System.Threading;

namespace jsonbroker.c_sharp.test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Thread.CurrentThread.Name = "main";

            if (0 == args.Length)
            {

                args = new String[] { "jsonbroker.library.dll", "/run=jsonbroker.library", "/include=current"};
                //args = new String[] { "jsonbroker.library.dll", "/run=jsonbroker.library", "/include=current", "/exclude=integration" };
                //args = new String[] { "jsonbroker.library.dll", "/run=jsonbroker.library", "/exclude=integration" };
                //args = new String[] { "jsonbroker.library.dll", "/run=jsonbroker.library" };
                //args = new String[] { "prototype.nunit.exe", "/run=jsonbroker.library", "/include=unit" };

            }


            NUnit.ConsoleRunner.Runner.Main(args);

        }
    }
}
