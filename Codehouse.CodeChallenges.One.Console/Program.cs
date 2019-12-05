using Codehouse.CodeChallenges.Business.ChallengeOne.Animals;

namespace Codehouse.CodeChallenges.One.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken
            {
                Colour = "White",
                Size = "5kg"
            };
            chicken.Walk();
            chicken.MakeSound();

            System.Console.WriteLine("");

            var duck = new Duck
            {
                Colour = "Black",
                Size = "7kg"
            };
            duck.Walk();
            duck.Fly();
            duck.MakeSound();

            System.Console.WriteLine("");

            var rooster = new Rooster()
            {
                Colour = "Black",
                Size = "10kg"
            };
            rooster.Walk();
            rooster.MakeSound();

            System.Console.ReadKey();
        }
    }
}
