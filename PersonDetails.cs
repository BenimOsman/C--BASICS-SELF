using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__BASICS
{
    internal class PersonDetails
    {
        public PersonDetails() { }
        // auto-implemented properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        // Constructor to initialize properties
        public PersonDetails(string name, int age, string address, string phoneNumber, string email)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        // Method to display person details
        public void DisplayDetails()
        {
            Console.WriteLine("Person Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
        }
        // Method to update person details
        public void UpdateDetails(string name, int age, string address, string phoneNumber, string email)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        // Method to validate email format
        public bool ValidateEmail()
        {
            // Simple email validation logic
            return Email.Contains("@") && Email.Contains(".");
        }
        // Method to validate phone number format
        public bool ValidatePhoneNumber()
        {
            // Simple phone number validation logic (e.g., length check)
            return PhoneNumber.Length == 10 && PhoneNumber.All(char.IsDigit);
        }
        // Method to check if the person is an adult
        public bool IsAdult()
        {
            return Age >= 18;
        }
        // Method to check if the person is a senior citizen
        public bool IsSeniorCitizen()
        {
            return Age >= 65;
        }

        // Method to get a summary of the person details
        public bool IsMobile()
        {
            return PhoneNumber.StartsWith("+") || PhoneNumber.StartsWith("0");
        }
        public string GetSummary()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}, Phone: {PhoneNumber}, Email: {Email}";
        }
    }
}