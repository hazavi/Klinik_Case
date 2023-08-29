using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lægeklinik.Codes
{
    abstract class Person
    {
        public string Fornavn { get; }
        public string Efternavn { get; }

        public Person(string fornavn, string efternavn)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
        }

        public abstract void ShowInfo();
    }
}
