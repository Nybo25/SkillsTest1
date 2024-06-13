using System;
using System.Diagnostics;

namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 2: Opret Klassen Dog");
            Dog dog = new Dog(1, "Fido", Race.Labrador, 2010);
            Console.WriteLine(dog.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Opgave 3: Opret Klassen Member");
            Member member = new Member(1, "Ole", "Ole@gmail.com", "+4591827122", "Erdrupvej 24, 4242 Boeslunde", new DateTime(1980, 4, 13));
            Console.WriteLine(member.ToString());

            Console.WriteLine("\n");

            Console.WriteLine("Opgave 4: Opret CRUD metoder på klassen Member\r");
            Console.WriteLine($"Medlemmet med ID'et {member.Id} har {member.Dogs.Count} hunde registeret");
            member.RegisterDog(dog);
            Console.WriteLine($"Medlemmet med ID'et {member.Id} har {member.Dogs.Count} hunde registeret");
            member.PrintDogs();
            member.RemoveDog(dog);
            Console.WriteLine($"Medlemmet med ID'et {member.Id} har {member.Dogs.Count} hunde registeret");

            Console.WriteLine("\n");


            Console.WriteLine("Opgave 6: Beregninger del 1");

            Console.WriteLine($"Medlemmet blev født i år {member.BirthDate.Year} og er dermed {member.Age} år gammel");

            Console.WriteLine("\n");

            Console.WriteLine("Opgave 6: Beregninger del 2");
            Dog dog1 = new Dog(2, "Buddy", Race.GoldenRetriever, 2015);
            member.RegisterDog(dog);
            member.RegisterDog(dog1);

            var baseFee = 1000;
            Console.WriteLine($"Antal hunde: {member.Dogs.Count}");
            var totalCost = member.MemberFee(baseFee);
            Console.WriteLine($"Pris for medlemskab er {totalCost} kr.");

            Console.WriteLine("\n");

            Console.WriteLine("Opgave 7: Validerings funktioner");
            bool validated = member.Validate();
            Console.WriteLine(!validated ? "Medlem er ikke gyldig" : "Medlem er gyldig");

            Console.WriteLine("\n");

            Console.WriteLine("Opgave 8: Exception handling");
            try
            {
                Member member1 = new Member(2, "Janne", "Janne@gmail.com", "Karlstad 33, Kbh", "+4561672918", new DateTime(1950, 1, 1));
                bool validated1 = member1.Validate();
                if (!validated1) throw new Exception("Member is not valid");
                Console.WriteLine("Member is valid");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}