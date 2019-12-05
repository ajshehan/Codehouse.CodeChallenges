using Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours;

namespace Codehouse.CodeChallenges.Business.ChallengeOne.Animals
{
    public class Duck : Bird, IFlyBeheviour
    {
        private IFlyBeheviour FlyBheviour { get; }

        public Duck()
        {
            FlyBheviour = new FlyBheviour();
            Sound = "Quack, quack";
        }

        public void MakeSound()
        {
            MakeSound(this.Sound);
        }

        public void Fly()
        {
            FlyBheviour.Fly();
        }
    }
}
