namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("Wincenty", "Kowalski", "33");

            user.AddScore(10);
            user.AddScore(10);

            //act
            var result = user.Result;

            //assert
            Assert.That(result, Is.EqualTo(20));
        }
        [Test]
        public void WhenUserCollectOnePenaltyScore_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("Wincenty", "Kowalski", "33");

            user.AddScore(10);
            user.AddScore(10);
            user.AddScore(-1);

            //act
            var result = user.Result;

            //assert
            Assert.That(result, Is.EqualTo(19));
        }
        [Test]
        public void WhenUserCollectSomePenaltyScore_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("Wincenty", "Kowalski", "33");

            user.AddScore(10); // Time keeping
            user.AddScore(-6);  // Sickness
            user.AddScore(5);  // Efficiency
            user.AddScore(-9);  // Productivity
            user.AddScore(10);  // Cooperation

            //act
            var result = user.Result;

            //assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void WhenUserCollectOnlyPenaltyScore_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new Employee("Wincenty", "Kowalski", "33");

            user.AddScore(-5); // Time keeping
            user.AddScore(-6);  // Sickness
            user.AddScore(0);  // Efficiency
            user.AddScore(-2);  // Productivity
            user.AddScore(0);  // Cooperation

            //act
            var result = user.Result;

            //assert
            Assert.That(result, Is.EqualTo(-13));
        }
    }
}