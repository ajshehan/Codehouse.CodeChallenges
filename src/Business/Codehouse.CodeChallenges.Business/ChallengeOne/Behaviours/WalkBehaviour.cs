namespace Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours
{
    public class WalkBehaviour : BaseBehaviourAction, IWalkBehaviour
    {
        public void Walk()
        {
            DoAction("I am walking");
        }
    }
}
