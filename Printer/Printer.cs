using System;
using Common;

namespace Printer
{
    [Serializable]
    class Printer : MarshalByRefObject
    {
        public Printer(ICentralNode iCentralNode)
        {
            iCentralNode.PrintInvoice += HandleNewInvoiceGenerated;
        }

        public void HandleNewInvoiceGenerated(object sender, string generatedInvoiceString)
        {
            Console.Write(generatedInvoiceString + "\n\n\n");
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
