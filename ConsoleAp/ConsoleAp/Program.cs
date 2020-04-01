using System;


namespace Week11
{
    class Program
    {
        //Write a method determine a unassigned integer is power of 2
        // a power of 2 will remid me of how binary numeral system work
        static void Main(string[] args)
        {
            Console.WriteLine(powerof2(1));
        }

        static bool powerof2(uint a)
        {
            int bitpos = 1;
            for (int i = 0; i < 32; i++)
            {
                if(a==bitpos)
                {
                    return true;
                }

                bitpos <<= 1;
            }
            return false;
        }
    }
}
