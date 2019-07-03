using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace PaymentTerminal
{
    public class PaymentTerminal
    {
        private ICentralNode iCentralNode;

        public PaymentTerminal(ICentralNode iCentralNode)
        {
            this.iCentralNode = iCentralNode;
        }

        public BusinessStatistics GetStatisticsFromServer()
        {
            return iCentralNode.GetBusinessStatistics();
        }

        public List<ComplexOrder> GetTableAccount(int tableNumber)
        {
            return iCentralNode.GetTableOrdersList(tableNumber);
        }

        public void CloseTableAndGenerateInvoice(int tableNumber)
        {
            iCentralNode.CloseTableAndGenerateInvoice(tableNumber);
        }
    }
}
