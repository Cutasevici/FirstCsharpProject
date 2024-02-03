using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Medii_de_Programare.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string firstName, string lastName, string email,
            DateTime birthDay, double? hourlyRate) : base(firstName, 
                lastName, email, birthDay, hourlyRate)
        {
        }

        private int numberOfReaserchesDone = 0;

        public int NumberOfReaserchesDone
        {
            get { return numberOfReaserchesDone; }
            set { numberOfReaserchesDone = value;}
        }

        public void ResearchNewThing(int researchHours)
        {
            NumberOfHoursWorked += researchHours;
            if(new Random().Next(100) > 50)
            {
                NumberOfReaserchesDone++;

                Console.WriteLine($"Reasearcher {FirstName} {LastName} has descovered" +
                    $" a new thing! Total number of things invented: {NumberOfReaserchesDone}");
            }
            else
            {
                Console.WriteLine($"reasercher {FirstName} {LastName} is working still on a new" +
                    $" new thing!");
            }
        }
    }

}
