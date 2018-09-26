using System;

namespace ReallyGoodTesting
{
    public class Class : InterfaceClass
    {
        public int ToGrade(int percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentException("");
            }
            if (percentage < 6)
            {
                return -3;
            }
            else if (percentage < 50)
            {
                return 0;
            }
            else if (percentage < 60)
            {
                return 2;
            }
            else if (percentage < 80)
            {
                return 4;
            }
            else if (percentage < 85)
            {
                return 7;
            }
            else if (percentage < 95)
            {
                return 10;
            }
            else
            {
                return 12;
            }
        }
    }
}
