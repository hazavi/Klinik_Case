﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lægeklinik.Interface
{
    internal interface IPerson
    {
        public string ForNavn { get; }
        public string EfterNavn { get; }
        public int TlfNr { get; }

    }
}
