

class NewGroup
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public NewGroup() { }
    public NewGroup(int id, string name, string description)
    {
        Id = id; Name = name; Description = description;
    }
}
