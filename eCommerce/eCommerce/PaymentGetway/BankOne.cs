using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.PaymentGetway
{
    public class BankOne : IBank
    {
        public decimal GetCharge(decimal orderAmount)
        {
            if (orderAmount < 50)
            {
                return (orderAmount * 2) / 100;
            }
            return (orderAmount * 1) / 100;
        }
    }
}
