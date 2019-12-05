namespace Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours
{
    public class FlyBheviour : BaseBehaviourAction, IFlyBheviour
    {
        public void Fly()
        {
            DoAction("I am flying");
        }
    }
}
