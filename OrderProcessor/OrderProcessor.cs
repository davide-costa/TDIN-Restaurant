using System;
using Common;

namespace OrderProcessor
{
    public class OrderProcessor : MarshalByRefObject
    {
        private ListOrdersGUI GUI;
        private ICentralNode iCentralNode;

        public OrderProcessor(ICentralNode iCentralNode, ListOrdersGUI gui)
        {
            this.GUI = gui;
            this.iCentralNode = iCentralNode;
        }

        public void handleNewOrder(object sender, ComplexOrder complexOrder)
        {
            GUI.AddNewOrder(complexOrder);
        }

        public void DeclareOrderInPreparation(int id)
        {
            iCentralNode.DeclareOrderInPreparation(id);
        }

        public void DeclareOrderAsDone(int id)
        {
            iCentralNode.DeclareOrderAsDone(id);
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }

    }
}
