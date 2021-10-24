namespace PrimeNumbers
{
    public class PrimeNumbersMultiplicationTable : MultiplicationTable
    {
        #region Methods
        public override void GenerateNumbers(int n)
        {
            int count = 0;
            int i = 2;
            while (count < n)
            {
                if (PrimeNumber.Instance.IsPrime(i))
                {
                    rows.Add(i);
                    columns.Add(i);
                    count++;
                }
                i++;
            }
        }
        #endregion
    }
}
