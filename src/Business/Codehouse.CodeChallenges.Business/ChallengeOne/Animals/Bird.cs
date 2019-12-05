using Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours;

namespace Codehouse.CodeChallenges.Business.ChallengeOne.Animals
{
    public class Bird : Animal, IMakeSound
    {
        public bool Fly()
        {
            DoAction("I am flying");

            return true;
        }

        public bool Sing()
        {
            DoAction($"I am singing");

            return true;
        }
    }
}
