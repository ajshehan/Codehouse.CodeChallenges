using Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours;

namespace Codehouse.CodeChallenges.Business.ChallengeOne.Animals
{
    public class Bird : Animal, IWalkBehaviour, ISoundBheviour
    {
        private IWalkBehaviour WalkBehaviour { get; }
        private ISoundBheviour SoundBheviour { get; }

        public Bird()
        {
            WalkBehaviour = new WalkBehaviour();
            SoundBheviour = new SoundBheviour();
        }

        public void Walk()
        {
            WalkBehaviour.Walk();
        }

        public void MakeSound(string sound)
        {
            SoundBheviour.MakeSound(sound);
        }
    }
}
