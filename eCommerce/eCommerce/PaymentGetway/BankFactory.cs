using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.PaymentGetway
{
    public enum PaymentOptionEnum
    {
        Best,
        BankOne,
        BankTwo
    }

    public class BankFactory
    {
        public IBank GetBank(PaymentOptionEnum paymentOption, decimal orderAmount)
        {
            IBank bank = default(IBank);
            switch (paymentOption)
            {
                case PaymentOptionEnum.Best:
                    bank = BestPaymentOptionProcessor.GetBestPaymentOptions(orderAmount);
                    break;
                case PaymentOptionEnum.BankOne:
                    bank = new BankOne();
                    break;
                case PaymentOptionEnum.BankTwo:
                    bank = new BankTwo();
                    break;
            }
            return bank;
        }
    }

}
