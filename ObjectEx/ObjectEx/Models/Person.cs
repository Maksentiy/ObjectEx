namespace ObjectEx.Models;

public class Person
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age) 
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (obj is Person other)
        {
            return other.Name == Name && other.Age == Age;
        }

        return false;
    }

    public override int GetHashCode()
    {
        int nameNum = 0;
        if (!(this.Name == null))
        {
            nameNum = Name.GetHashCode() ^ 2;
        }

        return nameNum * Age.GetHashCode() ^ 4;
    }

    public static bool operator ==(Person a, Person b)
    {
        if ((a is null && b is not null) || (b is null && a is not null))
        {
            return false;
        }

        if (a is null && b is not null)
        {
            return true;
        }

        return a.Name == b.Name && a.Age == b.Age;
    }

    public static bool operator !=(Person a, Person b)
    {
        return !(a == b);
    }

    public static bool operator >(Person a, Person b)
    {
        if (a == b) 
        {
            return false;
        }

        if (a is null || b is null)
        {
            return false;
        }

        return a.Age > b.Age;
    }

    public static bool operator <(Person a, Person b)
    {
        return b > a;
    }

}
