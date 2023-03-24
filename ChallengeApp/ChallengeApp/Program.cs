//deklaracja imienia
var name = "Ewa";

//deklaracja wieku
var age = 15;

//deklaracja plci K=kobieta M= Mężczyzna
char sex = 'M';


if (sex == 'K' && age <= 30)
{
    Console.WriteLine("kobieta ponizej 30 lat");
}
else if (age == 33)
{
    if (name == "Ewa")
    {
        Console.WriteLine("Ewa 33 lat");
    }
}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
