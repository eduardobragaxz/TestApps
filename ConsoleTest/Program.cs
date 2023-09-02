using System.Text.Json;

namespace ConsoleTest;

public class Program
{
    static readonly List<Article> ListOfPeople = new();
    static void Main(string[] args)
    {
        Console.WriteLine("Read or write?");

        if (Console.ReadLine() == "read")
        {
            List<Article> articles = ReadJson();
            
            foreach(Article article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Author);
            }
        }
        else
        {
            WriteJson();
        }
    }

    static public List<Article> ReadJson()
    {
        File.OpenRead(@"C:\Users\braga\Downloads\test.json");
        string json = File.ReadAllText(@"C:\Users\braga\Downloads\test.json");
        //using Stream stream = File.Create(@"C:\Users\braga\Downloads\test.json");
        return JsonSerializer.Deserialize<List<Article>>(json)!;
    }

    static public void WriteJson()
    {
        JsonSerializerOptions jsonSerializerOptions = new()
        {
            WriteIndented = true
        };
        Article person = new()
        {
            Id = 1,
            Title = "Headline",
            Author = "Eduardo Braga"

        };
        Article person1 = new()
        {
            Id = 2,
            Title = "Headline2",
            Author = "Eduardo Braga"

        };

        ListOfPeople.Add(person);
        ListOfPeople.Add(person1);

        string json = JsonSerializer.Serialize(ListOfPeople, jsonSerializerOptions);
        File.WriteAllText(@"C:\Users\braga\Downloads\test.json", json);
    }
}

public struct Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? Author { get; set; }
    public string? Content { get; set; }
}
