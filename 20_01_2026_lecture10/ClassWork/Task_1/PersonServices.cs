
class PersonService
{
    public List<Person> people = new List<Person>();

    public void AddPerson(Person person)
    {
        people.Add(person);
    }
    public List<Person> GetAll()
    {
        return people;
    }

    public string GetInfo(Person person)
    {
        return $"Здравствуйте! Меня зовут {person.FirstName} {person.LastName}.";
    }
}