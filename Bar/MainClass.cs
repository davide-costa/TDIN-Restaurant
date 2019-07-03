using System;
using System.Runtime.Remoting;
using System.Windows.Forms;
using Common;
using OrderProcessor;

namespace Bar
{
    public static class MainClass
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RemotingConfiguration.Configure("Bar.exe.config", false);
            ICentralNode iCentralNode = (ICentralNode)RemoteNew.New(typeof(ICentralNode));
            ListOrdersGUI gui = new ListOrdersGUI();
            OrderProcessor.OrderProcessor orderProcessor = new OrderProcessor.OrderProcessor(iCentralNode, gui);
            gui.SetOrderProcessor(orderProcessor);
            iCentralNode.NewBarClientOrder += orderProcessor.handleNewOrder;
            Application.Run(gui);
        }
    }
}
