using System;
using System.Runtime.Remoting;
using System.Windows.Forms;
using Common;
using OrderProcessor;

namespace Kitchen
{
    public static class MainClass
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ListOrdersGUI gui = new ListOrdersGUI();
            RemotingConfiguration.Configure("Kitchen.exe.config", false);
            ICentralNode iCentralNode = (ICentralNode)RemoteNew.New(typeof(ICentralNode));
            OrderProcessor.OrderProcessor orderProcessor = new OrderProcessor.OrderProcessor(iCentralNode, gui);
            gui.SetOrderProcessor(orderProcessor);
            iCentralNode.NewKitchenClientOrder += orderProcessor.handleNewOrder;
            Application.Run(gui);
        }
    }
}
