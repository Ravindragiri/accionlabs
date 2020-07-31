using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.PaymentGetway
{
    public class BestPaymentOptionProcessor
    {
        public static IBank GetBestPaymentOptions(decimal orderAmount)
        {
            var bankOne = new BankOne();
            var bankTwo = new BankTwo();
            if (bankOne.GetCharge(orderAmount) <= bankTwo.GetCharge(orderAmount))
            {
                return bankOne;
            }
            return bankTwo;
        }
    }
}