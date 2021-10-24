using System;

namespace PrimeNumbers
{
    public class PrimeNumber
    {
        #region Fields
        static PrimeNumber instance = null;
        #endregion

        #region Properties
        public static PrimeNumber Instance
        {
            get
            {
                if (instance == null)
                    instance = new PrimeNumber();
                return instance;
            }
        }
        #endregion

        #region Methods
        public bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            double posibilities = Math.Sqrt(n);
            for (int factor = 2; factor <= posibilities; factor++)
            {
                if (n % factor == 0)
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
    }
}
