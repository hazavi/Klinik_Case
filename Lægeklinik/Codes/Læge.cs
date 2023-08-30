using Lægeklinik.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lægeklinik.Codes
{
    internal class Læge : Person, IPerson
    {
        public string Specialitet { get; }

        public Læge(string fornavn, string efternavn, int tlfnr, string specialitet) : base (fornavn, efternavn, tlfnr)
        {
            Specialitet = specialitet;
        }
            
    }
}
