using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McFit_Kundenkartei
{
        [Serializable()]
        class Mitarbeiter : Person
        {
            //Instanzvariable und Properties
            private double gehalt;

            public double Gehalt
            {
                get { return gehalt; }
                set
                {
                    if (value > 0.0)
                        gehalt = value;
                    else gehalt = 0.0;
                }
            }
            private string status;

            public string Status
            {
                get { return status; }
                set
                {
                    string a = "";
                    try
                    {
                        switch (a)
                        {
                            case "Urlaub":
                                status = a;
                                break;
                            case "Krank":
                                status = a;
                                break;
                            default:
                                status = "Anwesend";
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Du hast vermutlich eine Zahl eingegeben.\nBitte benutze nur die Begriffe 'Urlaub' oder 'Krank'\nDie exakte Fehlermeldung lautet:\n{0}", e.Message);
                    }
                    finally
                    { 
                        
                    }
                }
                
            }

            private int kundennummer;

            public int Kundennummer
            {
                get { return kundennummer; }
                set 
                {
                    if (kundennummer > 0)
                        kundennummer = value;
                    else kundennummer = 0;

                }
            }


            // Konstruktoren
            public Mitarbeiter(): base()
            {
                this.gehalt = 0;
                this.kundennummer = 0;
                this.status = "Anwesend";
            }
            public Mitarbeiter(string fn,
                            string ln,
                            string dob,
                            Int32 kd,
                            double ge,
                            string st)
                : base(fn, ln, dob)
            {
                Kundennummer = kd;
                Gehalt = ge;
                Status = st;
            }
    }
}

