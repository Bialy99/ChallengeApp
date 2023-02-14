//zadanie domowe 4 dzień
string name = "Ewa";
bool female = true;
int age = 33;

if (female && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (!female && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}

