

using System;

class GroupServices
{
    List<NewGroup> groups = new List<NewGroup> ();

    public void CreateGroup(NewGroup group)
    {
        groups.Add(group);
    }
    public List<NewGroup> ReadGroup()
    {
        return groups;
    }
    public void DeleteGroup(int id)
    {
        for (int i = 0; i < groups.Count; i++)
        {
            if(groups[i].Id == id)
            {
                groups.Remove(groups[i]);
                Console.WriteLine($" Gruppa with id = {id} was deleted.");
            }
        }
    }
    public void UpdateGroup(NewGroup new_group)
    {
        for (int i = 0; i < groups.Count(); i++)
        {
            if (groups[i].Id == new_group.Id)
            {
                groups[i].Name = new_group.Name;
                groups[i].Description = new_group.Description;
                Console.WriteLine($" Gruppa with id = {new_group.Id} was updated.");
            }
        }
    }

}