using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        private string _klasserum;
        private List<Studerende> _klasseliste;
        private DateTime _semesterstart;

        public string Klasserum
        {
            get { return _klasserum; }
            set { _klasserum = value; }
        }

        public List<Studerende> Klasseliste
        {
            get { return _klasseliste; }
            set { _klasseliste = value; }
        }

        public DateTime Semsterstart
        {
            get { return _semesterstart; }
            set { _semesterstart = value; }
        }
        

        public KlasseRum()
        {

        }

        //Konstruktøren anveder værdier fra property

        public KlasseRum(string klasseRum, List<Studerende> studerendeliste, DateTime semsterstart)
        {
            Klasserum = klasseRum;
            Klasseliste = studerendeliste;
            Semsterstart = semsterstart;

        }

        public override string ToString()
        {
            return "Klasse navn: "+Klasserum + "\nStart: " + Semsterstart + "\n";
        }
    }
}
