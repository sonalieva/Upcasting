using System;
using System.Collections.Generic;
using System.Text;

namespace Hometask0404
{
    public static class ExtensionMethods
    {
        public static void CustomContains()
        {

        }
        public static void CustomContains(string word)
        {

        }
        public static void CustomContains(char letter)
        {

        }

        public static bool IsPrime(this int obj)
        {
            if (obj == 1 || obj == 0)
            {
            return false;
            }
            else if (obj==2)
            {
                return true;
            }
            for (int i = 2; i*i < obj; i++)
            {
                if (obj%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
