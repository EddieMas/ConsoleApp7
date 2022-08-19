using System;

namespace palindrome
{
    internal class Palindrome
    {
        private int chisla;
        public int Chisla
        {
            get { return chisla; }
            set { chisla = value; }
        }
        public Palindrome()
        {
            Chisla = 0;
        }
        public Palindrome(int ne_randomr)
        {
            this.Chisla = ne_randomr;
        }
        public Palindrome(Palindrome palindrome)
        {
            this.Chisla = palindrome.Chisla;
        }
        public bool Proverka()
        {
            int num_1 = this.chisla;
            short numOfDigits = 0;
            while (num_1 > 0)
            {
                num_1 /= 10;
                numOfDigits++;
            }
            short[] digitsOfNum = new short[numOfDigits];
            int num_2 = this.chisla;
            for (short i = 0; i < numOfDigits; i++)
            {
                digitsOfNum[i] = Convert.ToInt16(num_2 % 10);
                num_2 /= 10;
            }
            for (short i = 0; i < numOfDigits / 2; i++)
            {
                if (digitsOfNum[i] != digitsOfNum[numOfDigits - i - 1])
                    return false;
            }
            return true;
        }
        public string Otvet()
        {
            string otvet = String.Empty;
            if (this.Proverka())
                otvet = new String("da");
            else
                otvet = new String("net");
            return $"{this.Chisla} {otvet} eto palindrom";
        }
    }
}