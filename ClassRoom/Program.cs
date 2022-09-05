using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sådan laver du liste
            List<Studerende> studerendes = new List<Studerende>();

            //Sådan tilføjer du
            studerendes.Add(new Studerende("Sami", 01, 2001));
            studerendes.Add(new Studerende("Sami2", 02, 2002));
            studerendes.Add(new Studerende("Sami", 03, 2003));

            //Nytoprettet objekt af Klassrum
            KlasseRum klasseRum1 = new KlasseRum("3B", studerendes, new DateTime(2022, 9, 4));
            
           
        }
    }
}
