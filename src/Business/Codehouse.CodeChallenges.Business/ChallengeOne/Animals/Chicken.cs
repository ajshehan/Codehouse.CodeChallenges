using Codehouse.CodeChallenges.Business.ChallengeOne.Behaviours;

namespace Codehouse.CodeChallenges.Business.ChallengeOne.Animals
{
    public class Chicken : Bird, IFlyBheviour
    {
        private IFlyBheviour FlyBheviour { get; }

        public Chicken()
        {
            FlyBheviour = new FlyBheviour();
            Sound = "Cluck, cluck";
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
