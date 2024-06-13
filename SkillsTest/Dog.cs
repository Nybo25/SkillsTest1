using System;
using System.Diagnostics;

namespace SkillsTest
{ 
    public class Dog
    {
         public int Id { get; set; }
         public string Name { get; set; }
         public Race Race { get; set; }
         public int YearOfBirth { get; set; }

         public Dog(int id, string name, Race race, int yearOfBirth)
         {
           Id = id;
           Name = name;
           Race = race;
           YearOfBirth = yearOfBirth;
         }

         public override string ToString()
         {
          return $"Id: {Id}, Name: {Name}, Race: {Race}, YearOfBirth: {YearOfBirth}";
         }
    }
}
