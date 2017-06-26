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
    class RandomNumber
    {
        protected Random random;
        protected int currentRandomNumber;

        public RandomNumber()
        {
            currentRandomNumber = 0;
            random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
        }

        public int GenerateRandomNumber()
        {
            currentRandomNumber = random.Next();
            return currentRandomNumber;
        }

        public int GetCurrentRandomNumber() { return currentRandomNumber; }
    }
}
