namespace ChallengeApp.Test
{
    public class EmployeeStatisticsTest
    {
        [Test]
        public void WhenGetStatisticType_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee("Blazej", "Bulkasss");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(7);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(7, statistics.Max);
        }
        [Test]
        public static void WhenGetStatisticType_ShouldReturnCorrectMin()
        {
            //arrange
            var employee = new Employee("Blazej", "Bulkasss");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(7);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public static void WhenGetStatisticType_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee = new Employee("Blazej", "Bulkasss");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(7);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(Math.Round(3.667, 3), Math.Round(statistics.Average, 3));
        }
    }
}