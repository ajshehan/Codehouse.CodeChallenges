namespace Codehouse.CodeChallenges.Business.ChallengeOne
{
    public class Bird : Animal
    {
        public bool Fly()
        {
            DoAction("I am flying");

            return true;
        }

        public bool Sing()
        {
            DoAction("I am singing");

            return true;
        }
    }
}
