using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInheretence
{
    class Hund : Djur, IFarlig
    {
        public int Ben { get; set; }
        public string Svans { get; set; }
        private int nivå;
        public int Nivå { get { return nivå; } set { nivå = value; } }
        string beskrivning;
        public string Beskrivning { get { return beskrivning; } set { beskrivning = value; } }

        public void FarligInfo()
        {
            Console.WriteLine($"Farlig \n{Name} \nNivå: {nivå} \nBeskrivning: {beskrivning}");
        }

        public override void Info()
        {
            Console.WriteLine("Hund: " + Name);
            Console.WriteLine($"Har {Ben}st ben och en {Svans} svans");
        }
    }
}
