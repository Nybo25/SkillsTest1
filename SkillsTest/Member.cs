using System;
namespace SkillsTest
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; }

        public Member(int id, string name, string email, string phone, string address, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            BirthDate = birthDate;
            Age = DateTime.Now.Year - BirthDate.Year;
            Dogs = new List<Dog>();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}, Phone: {Phone}, Address: {Address}, BirthDate: {BirthDate}";
        }

        public void RegisterDog(Dog dog)
        {
            Dogs.Add(dog);
        }

        public void PrintDogs()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine(dog.ToString());
            }
        }

        public void RemoveDog(Dog dog)
        {
            Dogs.Remove(dog);
        }

        public double MemberFee(double baseFee)
        {
            int numberOfDogs = Dogs.Count;
            // Hvis medlemmet er over 65 år, får de den første hund til halv pris
            if (Age >= 65)
            {
                baseFee -= 500;
            }

            if (numberOfDogs <= 1) return baseFee;

            const int feePerDog = 500;
            baseFee += (numberOfDogs - 1) * feePerDog;

            return baseFee;
        }

        public bool Validate()
        {
            if (Age < 18)
            {
                throw new Exception("Medlemmet skal være over 18 år");
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Navn skal udfyldes");
            }

            if (string.IsNullOrEmpty(Email))
            {
                throw new Exception("Email skal udfyldes");
            }

            if (string.IsNullOrEmpty(Phone))
            {
                throw new Exception("Telefonnummer skal udfyldes");
            }

            if (string.IsNullOrEmpty(Address))
            {
                throw new Exception("Adresse skal udfyldes");
            }

            return true;
        }
    }
}

