using System.Text.Json;

namespace ConsoleTest;

public class Super
{
    public void DoIt()
    {
        Person person = new()
        {
            name = "eduardo",
            age = "23"
        };

    }
}


[Serializable]
public class PassItToJson
{
    public PassItToJson(Person person)
    {
        JsonSerializer.Serialize(person.name);
        JsonSerializer.Serialize(person.age);
    }
}
public class Person
{
    public required string? name;
    public required string? age;
}