using System;
using System.Collections.Generic;

namespace ConsoleInheretence
{
    class Program
    {
        static void Main(string[] args)
        {
            Djur djur = new Djur();
            Hund hund = new Hund();
            Svamp svamp = new Svamp();

            djur.Name = "Ett djur";

            hund.Name = "Gråhund";
            hund.Ben = 4;
            hund.Svans = "Yvig knor";
            hund.Nivå = 5;
            hund.Beskrivning = "Kraftig käcke med huggtänder";

            svamp.Name = "Flugsvamp";
            svamp.Nivå = 2;
            svamp.Utsende = "Röd med vita prickar";
            svamp.Beskrivning = "Giftig att äta";

            //djur.Info();
            //hund.Info();

            Console.WriteLine("Är hund ett barn av Djur: " + (hund is Djur));

            (hund as Djur).Info();

            Console.WriteLine("---------------------");

            List<Djur> djurList = new List<Djur>();

            djurList.Add(hund);
            djurList.Add(djur);

            foreach (Djur item in djurList)
            {
                if (item is Hund)
                {
                    item.Info();

                }
            }

            //Console.WriteLine(djur); // = Console.WriteLine(djur.ToString());

            Console.WriteLine("--------------------");

            List<IFarlig> farliga = new List<IFarlig>();

            farliga.Add(svamp);
            farliga.Add(hund);
            

            foreach (IFarlig item in farliga)
            {
                item.FarligInfo();
            }

        }
    }
}
