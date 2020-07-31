using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.PaymentGetway
{
    public class BankTwo : IBank
    {
        public decimal GetCharge(decimal orderAmount)
        {
            return (orderAmount * (decimal)1.5) / 100;
        }
    }
}
