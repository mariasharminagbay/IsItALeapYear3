using System;

namespace IsItALeapYear3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Sharmin!");
        }

        public Boolean IsItALeapYear(int yr)
        {
            if (yr % 400 == 0)
            {
                return true;
            }
            else if (yr % 4 == 0)
            {

                if (yr % 100 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }
    }
}
