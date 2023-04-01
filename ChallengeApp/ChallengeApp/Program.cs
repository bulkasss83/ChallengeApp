using ChallengeApp;

Employee user1 = new Employee("Andrzej", "Nowak", "27");
Employee user2 = new Employee("Wincenty", "Kowalski", "33");
Employee user3 = new Employee("Eleonora", "Karas", "29");

user1.AddScore(10); // Time keeping
user1.AddScore(6);  // Sickness
user1.AddScore(7);  // Efficiency
user1.AddScore(9);  // Productivity
user1.AddScore(10);  // Cooperation
var result1 = user1.Result;

user2.AddScore(10); // Time keeping
user2.AddScore(10);  // Sickness
user2.AddScore(10);  // Efficiency
user2.AddScore(10);  // Productivity
user2.AddScore(10);  // Cooperation
var result2 = user2.Result;

user3.AddScore(8); // Time keeping
user3.AddScore(5);  // Sickness
user3.AddScore(10);  // Efficiency
user3.AddScore(10);  // Productivity
user3.AddScore(5);  // Cooperation
var result3 = user3.Result;

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};
int maxResult = 0;
Employee userWithMaxResult = null;
foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        maxResult = user.Result;
        userWithMaxResult = user;
    }

}
Console.WriteLine("Higest score is own by:  " + userWithMaxResult.Name + " " + userWithMaxResult.Surname);
Console.WriteLine("Age is:  " + userWithMaxResult.age);
Console.WriteLine("Score is:  " + maxResult);



//1) stworzyc klase employee z Imie,nazwisko,wiek oraz zdobyte punkty
//2) 3 pracownikow i kazdemu przydziel po 5 ocen z zakresu 1-10
//3) napisz program ktory wyszuka pracownika z nawyzsza liczba punktow
// a nastepnie wyswietli liczbe zdobytych punktow