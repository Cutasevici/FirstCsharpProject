using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Medii_de_Programare.HR
{
    internal class Employee: IEmployee
    {
//Class properties 
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWOrked;
        private double wage;
        private double? hourlyRate;

        private DateTime birthDay;

        private const int minimalHoursWorkedUnit = 1;

        private Address address;
       

        public static double taxRate = 0.15;

// Setters and getters

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set {  email = value; }         
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWOrked;  }
            protected set {  numberOfHoursWOrked = value; }
        }
        public double Wage
        {
            get { return wage; }
            private set {  wage = value; }
        }
        public double? HourlyRate
        {
            get { return hourlyRate; }
            set { 
                if(hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
            }
        }
        public DateTime BirthDay
        {
            get { return birthDay; }
            set {  birthDay = value; }
        }
        public int MinimalHoursWorked
        {
            get { return minimalHoursWorkedUnit; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        

// class Constructors

        public Employee(string firstName, string lastName, string email, DateTime birthDay) :
            this(firstName, lastName, email, birthDay, 0) // call to the other constructor
        { }

        public Employee(string firstName, string lastName, string email, DateTime birthDay,
            double? hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;
           
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDay,
            double? hourlyRate, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthDay;
            HourlyRate = hourlyRate ?? 10;

            Address = new Address(street, houseNumber, zip, city);

        }

        // class Methods

        public void PerformWork()
        {
            //numberOfHoursWOrked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWOrked}" +
            //    $"hours!");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}" );
        }

        public static void UsingACustomType()
        {
            List<string> list = new List<string>();


        }
        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (numberOfHoursWOrked > 0)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and " +
                $"the tax on the bonus is {bonusTax}");
            return bonus;
        }


        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWOrked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours}" +
                $" hour!");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate.Value; // Correct casing
           // double taxRate = 0.2; // Example tax rate (adjust as needed)
            double taxAmount = wageBeforeTax * taxRate;
            Wage = wageBeforeTax - taxAmount; // Correct casing

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage}" +
                $" for {NumberOfHoursWorked} hours of work.");

            if (resetHours)
            {
                NumberOfHoursWorked = 0;
            }

            return Wage;
        }


        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmali:" +
                $"\t\t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}\nTax rate: " +
                $"\t{taxRate}\n");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($" Good job!, {firstName}");
        }
    }
}
