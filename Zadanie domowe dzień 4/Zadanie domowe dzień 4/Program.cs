string name = "Ewa";
string gender = "Female";
int age = 33;

if (gender == "Female")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
if (gender == "Male")
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else if (age >= 18)
    {
        Console.WriteLine("Pełnoletni Mężczyzna");
    }
}
