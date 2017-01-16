using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McFit_Kundenkartei
{
    [Serializable()]
    class Sportler : Person
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
        private double masse;

        public double Masse
        {
            get { return masse; }
            set {
                if (masse >= 0)
                    masse = value;
                else masse = 0;
            }
        }
        private double bmi;

        public double Bmi
        {
            get { return bmi; }
            set { 
                if (bmi >= 0)
                    bmi = value; 
                else bmi = 1;
            }
        }

        // Methoden
        public double getBMI()
        {
           return masse/groeße/groeße;
        }

        // Konstruktoren
        public Sportler(): base()
        {
            this.masse = 0;
            this.groeße = 1;
            this.bmi = 0;
        }
        public Sportler(string fn,
                        string ln,
                        string dob,
                        double m,
                        double g)
            : base(fn, ln, dob)
        {
            Masse = m;
            Groeße = g;
        }
    }
}
