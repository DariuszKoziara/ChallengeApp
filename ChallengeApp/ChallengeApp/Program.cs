string name = "Ewa";
var age = 35;
var sex = "woman";

if (sex == "woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "man" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}