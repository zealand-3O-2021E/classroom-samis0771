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
            studerendes.Add(new Studerende("Sami",24,05));
            studerendes.Add(new Studerende("Sami2", 02, 02));
            studerendes.Add(new Studerende("Sami", 13, 03));

            //Nytoprettet objekt af Klassrum
            KlasseRum klasseRum1 = new KlasseRum("3B", studerendes, new DateTime(2022, 9, 4));

            Console.WriteLine(klasseRum1);


            //Printer liste ud i string
            foreach (var item in studerendes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
           
        }
    }
}
