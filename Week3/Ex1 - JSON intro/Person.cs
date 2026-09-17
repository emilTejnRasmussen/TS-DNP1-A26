namespace Ex1___JSON_intro;

public class Person(string firstName, string lastName, int age, double height, bool isMarried, char sex, string[] hobbies)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public int Age { get; set; } = age;
    public double Height { get; set; } = height;
    public bool IsMarried { get; set; } = isMarried;
    public char Sex { get; set; } = sex;
    public string[] Hobbies { get; set; } = hobbies;
}