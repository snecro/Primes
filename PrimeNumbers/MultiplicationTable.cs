using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public abstract class MultiplicationTable
    {
        #region Fields
        protected List<int> rows;
        protected List<int> columns;
        #endregion

        #region Properties
        public List<int> Rows
        {
            get
            {
                return rows;
            }
            private set
            {
                rows = value;
            }
        }
        public List<int> Columns
        {
            get
            {
                return columns;
            }
            private set
            {
                columns = value;
            }
        }
        #endregion

        #region Methods
        public MultiplicationTable()
        {
            rows = new List<int>();
            columns = new List<int>();
        }
        public abstract void GenerateNumbers(int n);
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("# ");
            for (int k = 0; k < columns.Count; k++)
                sb.Append(columns[k] + " ");
            sb.Append(Environment.NewLine);
            for (int i = 0; i < rows.Count; i++)
            {
                sb.Append(rows[i] + " ");
                for (int j = 0; j < columns.Count; j++)
                {
                    sb.Append(rows[i] * columns[j] + " ");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        #endregion
    }
}
