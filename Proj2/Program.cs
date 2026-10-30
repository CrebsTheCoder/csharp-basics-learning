Console.Write("Hey whats your name: ");
string? name = Console.ReadLine();
Console.WriteLine($"Yo waddap, {name}!");
// also conact
Console.WriteLine("How old are you " + name + "?");
int? age = int.Parse(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine("Hey I can't talk to you");
}
else
{
    Console.Write("Hey I can talk to you");
}