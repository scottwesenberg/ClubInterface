using System;

namespace ClubInterface
{
    interface IClub
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method
        public string Fullname();
    }

    class ClubMember : IClub
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        // Default constructor
        public ClubMember()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
            Email = "";
            Age = 0;
            Gender = "";
        }

        // Parameterized constructor
        public ClubMember(int id, string firstName, string lastName, string email, int age, string gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
            Gender = gender;
        }

        // Method to display all fields
        public void DisplayMemberInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nEmail: {2}\nAge: {3}\nGender: {4}",
                Id, Fullname(), Email, Age, Gender);
        }

        // Method to display only the full name
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object variable and add data to the fields
            ClubMember member1 = new ClubMember(1, "Sir", "Shrek", "OutMeSwamp@gmail.com", 30, "Male");

            // Use the display method to display the information in a Console.WriteLine statement
            member1.DisplayMemberInfo();

            Console.ReadKey();
        }
    }
}
