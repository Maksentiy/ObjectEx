using ObjectEx.Models;

namespace ObjectEx;

internal class Program
{
    static void Main(string[] args)
    {
        var persons = new Person[4]
        {
            new Person("Max", 29),
            new Person("Kira", 27),
            new Person("Max", 32),
            new Person("Kira", 27),
        };

        Console.WriteLine("To string");
        foreach (var person in persons)
        {
            Console.WriteLine(person.ToString());
        }

        Console.WriteLine();

        Console.WriteLine("Equals");
        CompareTwoPersons(persons[0], persons[2]);
        CompareTwoPersons(persons[1], persons[3]);

        Console.WriteLine();

        Console.WriteLine("HashCode");
        foreach (var person in persons)
        {
            Console.WriteLine($"[{person.ToString()}] Hashcode: { person.GetHashCode()}");
        }

        Console.WriteLine();

        Console.WriteLine("==");
        Console.WriteLine($"Is {persons[0].ToString()} == {persons[1].ToString()}? {persons[0] == persons[1]}");
        Console.WriteLine($"Is {persons[1].ToString()} == {persons[3].ToString()}? {persons[1] == persons[3]}");

        Console.WriteLine("!=");
        Console.WriteLine($"Is {persons[0].ToString()} != {persons[1].ToString()}? {persons[0] != persons[1]}");
        Console.WriteLine($"Is {persons[1].ToString()} != {persons[3].ToString()}? {persons[1] != persons[3]}");

        Console.WriteLine(">");
        Console.WriteLine($"Is [{persons[0].ToString()}] age > [{persons[1].ToString()}] age? {persons[0] > persons[1]}");
        Console.WriteLine($"Is [{persons[1].ToString()}] age > [{persons[2].ToString()}] age? {persons[1] > persons[2]}");

        Console.WriteLine("!=");
        Console.WriteLine($"Is [{persons[0].ToString()}] age < [{persons[1].ToString()}] age? {persons[0] < persons[1]}");
        Console.WriteLine($"Is [{persons[1].ToString()}] age < [{persons[2].ToString()}] age? {persons[1] < persons[2]}");
    }

    public static void CompareTwoPersons(Person person1, Person person2) 
    {
        if (person1.Equals(person2)) 
        {
            Console.WriteLine($"{person1.ToString()} equals to {person2.ToString()}");
        }
        else
        {
            Console.WriteLine($"{person1.ToString()} not equals to {person2.ToString()}");
        }
    }
}
