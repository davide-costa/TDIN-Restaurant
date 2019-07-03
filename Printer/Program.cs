using System;
using System.Runtime.Remoting;
using Common;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Printer.exe.config", false);
            ICentralNode iCentralNode = (ICentralNode)RemoteNew.New(typeof(ICentralNode));
            new Printer(iCentralNode);
            Console.ReadKey();
        }
    }
}
