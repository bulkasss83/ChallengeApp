using ChallengeApp;

var employee = new Employee("Blazej", "Bulkasss");

employee.AddGrade(9f);
employee.AddGrade("1000");
employee.AddGrade(6.5);
employee.AddGrade(200);
employee.AddGrade(3.5);
employee.AddGrade(2);
employee.AddGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}"); 
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");