using Codehouse.CodeChallenges.Business.ChallengeOne.Animals;

namespace Codehouse.CodeChallenges.One.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken();
            chicken.Walk();
            chicken.MakeSound();

            System.Console.WriteLine("");

            var duck = new Duck();
            duck.Walk();
            duck.Fly();
            duck.MakeSound();

            System.Console.ReadKey();
        }
    }
}
