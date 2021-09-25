using System;
using System.Collections.Generic;
using System.Text;

namespace SalesCommission
{
    class CommissionStructure
    {
        private const decimal Fist_Item = 239.99M;
        private const decimal Sec_Item = 129.75M;
        private const decimal Third_Item = 99.95M;
        private const decimal Fourth_Item = 350.89M;
        private const decimal Pay_Per_Week = 200M;
        private const decimal Percentage = 0.09M;

        public CommissionStructure(int item1Sold, int item2Sold, int item3Sold, int item4Sold)
        {
            Item1Sold = item1Sold;
            Item2Sold = item2Sold;
            Item3Sold = item3Sold;
            Item4Sold = item4Sold;
        }

        public int Item1Sold { get; set; }
        public int Item2Sold { get; set; }
        public int Item3Sold { get; set; }
        public int Item4Sold { get; set; }

        public decimal GetTotalSales()
        {
            return Fist_Item * Item1Sold + Sec_Item * Item2Sold + Third_Item * Item3Sold + Fourth_Item * Item4Sold;
        }

        public decimal Commission()
        {
            return GetTotalSales() * Percentage + Pay_Per_Week;
        }
    }
}
