using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeProvider
{
    public class ExchangeProvider
    {
        /// <summary>
        /// Курс у.е.
        /// </summary>
        public double Cource => 64.25;

        /// <summary>
        /// Текущая комиссия
        /// </summary>
        public double GetCommission(double value)
        {
            if (value < 1000)
            {
                return 4.0;
            }

            if (value < 10000)
            {
                return 3.0;
            }

            if (value < 50000)
            {
                return 2.0;
            }

            if (value < 100000)
            {
                return 1.0;
            }

            return 0.3;
        }

        /// <summary>
        /// Перевести деньги
        /// </summary>
        public double Exchange(double value)
        {
            return (value / Cource) * (1 - GetCommission(value) / 100);
        }
    }
}
