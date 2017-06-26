/*
Ryan Doiron
04/20/2016
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class RangedRandomNumber : RandomNumber
    {
        protected int minimum;
        protected int maximum;

        // constructor
        public RangedRandomNumber()
        {
            minimum = 1;
            maximum = 20;
        }

        // constructor
        public RangedRandomNumber(int minimum, int maximum)
        {
            SetMinimum(minimum);
            SetMaximum(maximum);
        }

        // method
        public new int GenerateRandomNumber()
        {
            if (minimum == maximum)
            {
                return minimum;
            }
            else
            {
                currentRandomNumber = random.Next(minimum, maximum + 1);
                return currentRandomNumber;
            }
        }

        // setter
        public void SetMinimum(int minimum)
        {
            if (this.minimum < 0)
            {
                this.minimum = 0;
            }
            else if (this.minimum > maximum)
            {
                this.minimum = maximum;
            }
            else
            {
                this.minimum = minimum;
            }
        }

        // setter
        public void SetMaximum(int maximum)
        {
            if (this.maximum < 0)
            {
                this.maximum = 1;
            }
            else if(this.maximum < minimum)
            {
                this.maximum = minimum;
            }
            else if(this.maximum > 1000)
            {
                this.maximum = 1000;
            }
            else
            {
                this.maximum = maximum;
            }
        }

        // getter
        public int GetMinimum() { return minimum; }

        // getter
        public int GetMaximum() { return maximum; }
    }
}
