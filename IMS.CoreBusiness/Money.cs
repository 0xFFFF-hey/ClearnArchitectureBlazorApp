using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public record Money(double Amount, string Currency)
    {
        public Money Add(Money other)
        {
            if (Currency != other.Currency)
                throw new InvalidOperationException("Cannot add money of different currencies.");
            return new Money(Amount + other.Amount, Currency);
        }
    }
}
