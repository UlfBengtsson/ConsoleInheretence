using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInheretence
{
    interface IFarlig
    {
        int Nivå { get; set; }
        string Beskrivning { get; set; }
        void FarligInfo();
    }
}
