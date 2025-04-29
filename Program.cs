namespace task1eraasoft
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, in the Islam's Carpet Cleaning Services");
            Console.WriteLine("please Enter number of small carpets");
            int numberOfSmallCarpet=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please Enter number of large carpets");
            int numberOfLargeCarpet = Convert.ToInt32(Console.ReadLine());
            int costOfSmallCarpet = numberOfSmallCarpet * 25;
            int costOfLargeCarpet = numberOfLargeCarpet * 35;
            int totalCost=costOfLargeCarpet+costOfSmallCarpet;
            double taxValue = .06 * totalCost;
            Console.WriteLine($"price per small carpets {costOfSmallCarpet}");
            Console.WriteLine($"price per large carpets {costOfLargeCarpet}");
            Console.WriteLine($"Cost : { totalCost }");

            
            Console.WriteLine($"Tax {taxValue}");
            Console.WriteLine("=============================================================");
            Console.WriteLine($"Total estimate : {taxValue+totalCost}");
            Console.WriteLine("This estimate valid for 30 days");

        }
    }
}
