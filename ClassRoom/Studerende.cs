using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public int Fødselsmåned
        {
            get { return _fødselsmåned;  }
            set { _fødselsmåned = value; }
        }

        public int Førdselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag = value; }
        }
        public Studerende(string Navn, int Fødselsdag, int Fødselsmåned)
        {
            _navn = Navn;
            _fødselsdag = Fødselsdag;
            _fødselsmåned = Fødselsmåned;
            

        }

        public override string ToString()
        {
            return "Navn:" + Navn + " " + Fødselsmåned +"-"+ Førdselsdag;
        }

    }
}
