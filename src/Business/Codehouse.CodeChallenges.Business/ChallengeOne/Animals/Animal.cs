using Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours;

namespace Codehouse.CodeChallenges.Business.ChallengeOne.Animals
{
    public class Animal : IWalk
    {
        internal void DoAction(string action)
        {
            System.Console.WriteLine(action);
        }

        public bool Walk()
        {
            DoAction("I am walking");

            return true;
        }
    }
}
