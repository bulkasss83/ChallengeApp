
using ChallengeApp;

public class Tests
    {
         [Test]
        public void WhenEmployeeCollectTwoScorec_ShouldReturnCorectSum() 
        // nazewnictwo testu przyjete powinno byc w oparciu o zalozony test
                                                                               // w oparciu co bedziemy testowac
        {
            // arrange
            var employee = new Employee ("Waldemar", "Konieczny", "37");
            employee.AddScore(5);
            employee.AddScore(7);


            //act
            var result = employee.Result;

            //assert

            Assert.That(result, Is.EqualTo(12));


        }
    }
;