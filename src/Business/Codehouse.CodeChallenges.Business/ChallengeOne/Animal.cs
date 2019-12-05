namespace Codehouse.CodeChallenges.Business.ChallengeOne
{
    public class Animal
    {
        internal void DoAction(string action)
        {
            System.Console.WriteLine(action);
        }

        public void Walk()
        {
            DoAction("I am walking");
        }
    }
}
