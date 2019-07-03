using System;
using System.Runtime.Remoting;

class Program
{
    static void Main(string[] args)
    {
        RemotingConfiguration.Configure("CentralNode.exe.config", false);
        Console.WriteLine("Central Node server running...");
        Console.WriteLine("Press Return to terminate.");
        Console.ReadLine();
    }
}