namespace CsharpFundamentals;

public class Person
{
    public string FirstName;
    public string LastName;

    public void Introduce()
    {
        Console.WriteLine("Hello World! My name is " + FirstName + " " + LastName);
    }
}