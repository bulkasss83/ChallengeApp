
namespace ChallengeApp.Test
{
    public class Type_Test
    {

        [Test]
        public void TestingTwoTheSameStrings()
        {
            string number1 = "Adam";
            string number2 = "Adam";

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestingTwoTheSameIntigers()
        {
            int number1 = 5;
            int number2 = 5;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestingTwoNotTheSameUshort()
        {
            ushort number1 = 4;
            ushort number2 = 5;

            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void TestingTwoTheSameFloat()
        {
            float number1 = 4.132435F;
            float number2 = 4.132435F;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestingTwoNotTheSameDouble()
        {
            double number1 = 1.243546654;
            double number2 = 1.243546576;

            Assert.AreNotEqual(number1, number2);
        }

        private Employee GetUser(string name)
        
        {
            return new Employee(name); 
        }
            
    }

}



