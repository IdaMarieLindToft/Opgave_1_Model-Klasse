using System;
using System.Reflection.Metadata.Ecma335;

namespace Opgave1_Model_Class
{
    public class FanOutPut

//Opgave 1 Model-klasse
//Du skal lave et projekt af typen Class Library(.NET core).
//Dit projekt skal indeholde en klasse, FanOutput, med følgende properties
//• Id et tal
//• Navn, en tekst-streng, min 2 karakterer lang
//• Temp et tal mellem 15 og 25 (målt i grader celsius, 15 <= Temp <= 25)
//• Fugt et tal mellem 30 og 80 (relativ fugtighed, 30 <= Fugt <= 80)
//Der skal kastes passende exceptions, hvis betingelserne ikke overholdes.
//Du skal lave en unit test af din klasse FanOutput.
//Din test skal have et godt “Code Coverage”

    {
        private int _id;
        private string _navn;
        private int _temp;
        private int _fugt;

        public FanOutPut(int id, string navn, int temp, int fugt)
        {
            _id = id;
            _navn = navn;
            _temp = temp;
            _fugt = fugt;

        }

        public FanOutPut() { }

        public int Id
        {
            get { return _id; }
            set { value = _id; }
        }

        public string Navn
        {
            get { return _navn; }
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException("Længden på navnet skal være minimum 2 karakterer langt");
                _navn = value;
            }
        }

        public int Temp
        {
            get { return _temp; }
            set
            {
                if (value <= 14 || value >= 26) throw new ArgumentOutOfRangeException("Temperaturen skal være mellem 15 og 25 grader");
                _temp = value;

            }
        }

        public int Fugt
        {
            get { return _fugt; }
            set
            {
                if (value <= 29 || value >= 81) throw new ArgumentOutOfRangeException("Fugt tallet skal være mellem 30 og 80 grader");
                _fugt = value;
            }
        }     



    }
}
