namespace Codehouse.CodeChallenges.Business.ChallengeOne
{
    public class Animal
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
