using Codehouse.CodeChallenges.Business.ChallengeOne;

namespace Codehouse.CodeChallenges.One.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird();
            bird.Walk();
            bird.Fly();
            bird.Sing();

            System.Console.ReadKey();
        }
    }
}
