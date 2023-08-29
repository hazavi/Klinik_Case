using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lægeklinik.Codes
{
    internal class Læge : Person
    {
        public string Telefonnummer { get; }
        public string Specialitet { get; }

        public Læge(string fornavn, string efternavn, string telefonnummer, string specialitet)
            : base(fornavn, efternavn)
        {
            Telefonnummer = telefonnummer;
            Specialitet = specialitet;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Læge: {Fornavn} {Efternavn}, Specialitet: {Specialitet}, Tlf.nr.: {Telefonnummer}");
        }
    }
}
