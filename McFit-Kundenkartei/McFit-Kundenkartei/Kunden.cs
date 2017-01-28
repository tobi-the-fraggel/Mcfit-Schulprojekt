using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McFit_Kundenkartei
{
    [Serializable()]
    class Kunden : Person
    {
        //Instanzvariable und Properties
        private double groeße;

        public double Groeße
        {
            get { return groeße; }
            set {
                if (value > 0.0)
                    groeße = value;
                else groeße = 1;
            }
        }
        private double gewicht;

        public double Gewicht
        {
            get { return gewicht; }
            set {
                if (gewicht >= 0)
                    gewicht = value;
                else gewicht = 0;
            }
        }

         // Methoden
        public double getBMI()
        {
            double b = gewicht/groeße/groeße*10000;
            Math.Round(b, 2);
            return b;
        }

        // Konstruktoren
        public Kunden(): base()
        {
            this.gewicht = 0;
            this.groeße = 1;
        }
        public Kunden(string fn,
                        string ln,
                        string dob,
                        double m,
                        double g)
            : base(fn, ln, dob)
        {
            Gewicht = m;
            Groeße = g;
        }
    }
}
