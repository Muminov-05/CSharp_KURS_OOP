
using System;
using System.Collections.Generic;

class StudentSer
{
    List<Student> students = new List<Student>();

    public void CreateStudent(Student student)
    {
        students.Add(student);
    }
    public List<Student> ReadStudent()
    {
        return students;
    }
    public void DeleteStudent(int id)
    {
        for (int i = 0; i < students.Count(); i++)
        {
            if (students[i].Id == id)
            {
                students.Remove(students[i]);
                Console.WriteLine($" Student with id = {id} was deleted.");
            }
        }
    }
    public void UpdateStudent(Student newStudent)
    {
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == newStudent.Id)
            {
                students[i].FirstName = newStudent.FirstName;
                students[i].LastName = newStudent.LastName;
                students[i].Age = newStudent.Age;
                return;
            }
        }
        Console.WriteLine("Student dont found for update.");
    }
}