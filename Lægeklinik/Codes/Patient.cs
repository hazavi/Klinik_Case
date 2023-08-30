using Lægeklinik.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lægeklinik.Codes
{
    internal class Patient : Person
    {
        public List<Læge> TildelteLæger { get; } = new List<Læge>();

        public Patient(string fornavn, string efternavn, int tlfnr) : base(fornavn, efternavn, tlfnr)
        {
            TildelteLæger = new List<Læge>();
        }
        public void TildelLæge(Læge læge)
        {
            // Tjek for kombinationen af Kirurgi og Onkologi
            if (TildelteLæger.Exists(l => l.Specialitet == "Kirurgi" || l.Specialitet == "Onkologi") &&
                (læge.Specialitet == "Kirurgi" || læge.Specialitet == "Onkologi"))
            {
                throw new Exception("Advarsel: En patient kan ikke have Kirurgi og Onkologi samtidig.");
            }

            // Tjek antallet af patienter tildelt lægen
            if (TildelteLæger.Count >= 3)
            {
                throw new Exception("Advarsel: Lægen har allerede 3 eller flere patienter.");
            }

            TildelteLæger.Add(læge);
        }

     
    }
}
