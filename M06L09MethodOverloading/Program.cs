using System;

namespace M06L09MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Yi","Long");
            person.GenerateEmail("gmail.com", false);
            Console.WriteLine(person.Email);

            Console.ReadLine();
        }
    }
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail("aol.com",false);
        }
        public void GenerateEmail(string domain)
        {
            GenerateEmail(domain,false);
        }
        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("aol.com", firstInitialMethod);
        }
        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{ FirstName.Substring(0, 1) }{ LastName }@{ domain }";
            }
            else
            {
                Email = $"{ FirstName }{ LastName }@{ domain }";
            }
        }
    }

    // HomeWork: Create an EmployeeModel class. 
    // Create three different constructors that take in different amounts of data.
    public class EmployeeModel: PersonModel{
        public EmployeeModel()
        {
            
        }
        public EmployeeModel(string firstName, string lastName){
            FirstName = firstName;
            LastName = lastName;
        }
        public EmployeeModel(string firstName, string lastName, string email){
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
