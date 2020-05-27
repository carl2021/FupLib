using System;

namespace FupLib
{
    public class TransportCalc
    {
        public static double Average(int antalKm, double antalLiter)
        {
            double average;
            average = (antalLiter / antalKm) * 100;

            return average;
        }

        public void Total(string transporter)
        {
            
        }
     
    }
}
