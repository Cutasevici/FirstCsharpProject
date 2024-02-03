using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Medii_de_Programare.HR
{
    internal class JuniorReasercher : Researcher
    {
        public JuniorReasercher(string firstName, string lastName, string email,
            DateTime birthDay, double? hourlyRate) : base(firstName,
                lastName, email, birthDay, hourlyRate)
        {

        }
    }
}
