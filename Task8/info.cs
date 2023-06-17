public class Person
{
    public string? name ;
    public string? surname ;
    public int? age;
    public int person;
    
    public string GetFullHaracters()
    {
        return $"Hello! My name is {name} {surname}";
    }
}