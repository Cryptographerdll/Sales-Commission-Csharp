using System;

namespace SalesCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               A large company pays its salespeople on a commission basis.
               The salespeople receive $200 per week plus 9% of their gross sales for that week. 
            For example, a salesperson who sells $5,000 worth of merchandise in a week receives $200 plus 9% of $5,000, or a total of $650. 
            You’ve been supplied with a list of the items sold by each salesperson. The values of these items are as follows:
                item 1:  239.99
                item 2:  129.75
                item 3:  99.95
                item 4: 350.89
                Develop a C# app that inputs one salesperson’s items sold for the last week, 
            then calculates and displays that salesperson's earnings. There’s no limit to the number of items that can be sold by a salesperson.
             */
          int item1Sold = 0;
          int item2Sold = 0;
          int item3Sold = 0;
          int item4Sold = 0;

            Console.WriteLine("how many of items1 were sold ");
            item1Sold = int.Parse(Console.ReadLine());

            Console.WriteLine("how many of items2 were sold ");
            item2Sold = int.Parse(Console.ReadLine());

            Console.WriteLine("how many of items3 were sold ");
            item3Sold = int.Parse(Console.ReadLine());

            Console.WriteLine("how many of items4 were sold ");
            item4Sold = int.Parse(Console.ReadLine());

            CommissionStructure cs = new CommissionStructure(item1Sold, item2Sold, item3Sold, item4Sold);

            // Total sales :
            Console.Write("Total sales including 200$ : {0:C}", cs.Commission());
            Console.ReadKey();

        }
    }
}
