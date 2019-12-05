using Codehouse.CodeChallenges.Business.ChallengeZero;

namespace Codehouse.CodeChallenges.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var merchant = new GloveMerchant();

            var glovesList = new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            System.Console.Write("Gloves colours list: { ");
            foreach (var i in glovesList)
            {
                System.Console.Write($"{i} ");
            }
            System.Console.Write("}");

            System.Console.WriteLine($"\nPairs: {merchant.CountPairs(glovesList)}");

            System.Console.WriteLine("\nPress any key to close...");
            System.Console.ReadKey();
        }
    }
}
