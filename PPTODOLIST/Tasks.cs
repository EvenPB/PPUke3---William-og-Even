using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTODOLIST
{
    internal class Tasks
    {
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }

        public Tasks(string navn, string beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
        }

        public Tasks()
        {

        }
    }
}