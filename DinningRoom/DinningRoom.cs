using System;
using System.Collections.Generic;
using Common;

namespace DinningRoom
{
    public class DinningRoom : MarshalByRefObject
    {
        private readonly ICentralNode iCentralNode;
        private readonly DinningRoomTerminalGUI GUI;

        public DinningRoom(ICentralNode centralNode, DinningRoomTerminalGUI gui)
        {
            this.iCentralNode = centralNode;
            this.GUI = gui;
            iCentralNode.OrderReady += HandleOrderReadyNotification;
            iCentralNode.OrderReadyNotificationHandled += HandleOrderReadyHandledNotification;
        }

        public void HandleOrderReadyHandledNotification(object sender, OrderReadyNotification orderReadyNotification)
        {
            GUI.OnOrderReadyHandledNotification(orderReadyNotification);
        }

        public void HandleOrderReadyNotification(object sender, OrderReadyNotification orderReadyNotification)
        {
            GUI.OnOrderReadyUpdate(orderReadyNotification);
        }

        public void OnNewClientOrder(int tableNumber, List<BasicOrder> orders)
        {
            iCentralNode.RegisterOrdersForTable(tableNumber, orders);
        }

        public List<Product> GetAvailableProducts()
        {
            return iCentralNode.GetRestaurantAvailableProducts();
        }

        public void NotificationHandled(OrderReadyNotification orderReadyNotification)
        {
            iCentralNode.HandleOrderReadyNotificationHandled(orderReadyNotification);
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

}
