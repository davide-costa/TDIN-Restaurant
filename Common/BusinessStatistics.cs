using System;

namespace Common
{
    [Serializable]
    public class BusinessStatistics
    {
        public int NumberOfOpenTables;
        public int NumberOfClosedTables;
        public double AmountAlreadyReceived;
        public double AmountToReceive; //money still in open tables
    }
}
