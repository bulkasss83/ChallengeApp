namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            //arrange
            var user = new Employee("Wincenty", "Kowalski", "33");

            user.AddScore(10);
            user.AddScore(10);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(20, result);

        }
    }
}