Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}!");
Console.Write($"Digite  ano de seu nascimento :");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"Voce tem {age} anos.");

if(age >= 18) 
{
    Console.WriteLine("Voce é maior de idade");
}
else 
{
    Console.WriteLine("Voce é menor de idade");
}
