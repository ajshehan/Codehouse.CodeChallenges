namespace Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours
{
    public class FlyBheviour : BaseBehaviourAction, IFlyBeheviour
    {
        public void Fly()
        {
            DoAction("I am flying");
        }
    }
}
