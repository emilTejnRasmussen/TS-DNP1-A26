using System.Text.Json;
using Ex1___JSON_intro;

var p1 = new Person(
    "Alice",
    "Jensen",
    25,
    1.68,
    false,
    'F',
    ["Reading", "Running", "Gaming"]
);

var p2 = new Person(
    "Martin",
    "Nielsen",
    32,
    1.84,
    true,
    'M',
    ["Cycling", "Cooking", "Football"]
);

var p3 = new Person(
    "Sofie",
    "Larsen",
    28,
    1.72,
    false,
    'F',
    ["Painting", "Traveling", "Swimming"]
);

List<Person> persons = [p1, p2, p3];

var jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions
{
    WriteIndented = true
});

Console.WriteLine(jsonFormatted);
