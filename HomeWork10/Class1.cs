using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    internal class Angle
    {
        public bool itscorrect = true;
        private int gradus;
        public int Gradus
        {
            get { return gradus; }
            set
            {
                if (value >= 0)
                {
                    gradus = value % 180;
                }
                else
                {
                    gradus = 0;
                    itscorrect = false;
                }

            }
        }
        private int minutes;
        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value >= 0)
                {
                    Gradus = value / 60;
                    minutes = value % 60;
                }
                else
                {
                    minutes = 0;
                    itscorrect = false;
                }

            }
        }
        private int seconds;
        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value >= 0)
                {
                    Minutes = value / 60;
                    seconds = value % 60;
                }
                else
                {
                    seconds = 0;
                    itscorrect = false;
                }

            }
        }

        public Angle(int gradus, int minutes, int seconds)
        {
            Gradus = gradus;
            Minutes = minutes;
            Seconds = seconds;

        }

        public double ToRadians()
        {
            return  (gradus + (minutes / 60.0) + (seconds / 3600.0))* Math.PI/180;
        }
    }
}
    
