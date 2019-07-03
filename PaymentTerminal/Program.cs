using System.Runtime.Remoting;
using System.Windows.Forms;
using Common;

namespace PaymentTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RemotingConfiguration.Configure("PaymentTerminal.exe.config", false);
            ICentralNode iCentralNode = (ICentralNode)RemoteNew.New(typeof(ICentralNode));
            PaymentTerminalGUI gui = new PaymentTerminalGUI();
            PaymentTerminal paymentTerminal = new PaymentTerminal(iCentralNode);
            gui.SetPaymentTerminal(paymentTerminal);
            Application.Run(gui);
        }
    }
}