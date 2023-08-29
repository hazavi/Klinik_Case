using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lægeklinik.Codes
{
    internal class Patient : Person
    {
        public string Telefonnummer { get; }
        public List<Læge> TildelteLæger { get; }

        public Patient(string fornavn, string efternavn, string telefonnummer)
            : base(fornavn, efternavn)
        {
            Telefonnummer = telefonnummer;
            TildelteLæger = new List<Læge>();
        }

        public void TildelLæge(Læge læge)
        {
            // Implementer logik for at tildele læge til patient og håndtere begrænsninger
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Patient: {Fornavn} {Efternavn}, Tlf.nr.: {Telefonnummer}");
            foreach (var læge in TildelteLæger)
            {
                læge.ShowInfo();
            }
        }
    }
}
