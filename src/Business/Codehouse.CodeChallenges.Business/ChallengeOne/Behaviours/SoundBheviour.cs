namespace Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours
{
    public class SoundBheviour : BaseBehaviourAction, ISoundBheviour
    {
        public void MakeSound(string sound)
        {
            DoAction($"I am saying: \"{sound}\"");
        }
    }
}
