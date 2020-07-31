using eCommerce.PaymentGetway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal orderAmount = 100.00M;

            BankFactory factory = new BankFactory();
            IBank bank = factory.GetBank(PaymentOptionEnum.Best, orderAmount);
            if (bank != null)
            {
                Console.WriteLine(string.Format("You have choosen Payment Getway: {0}", bank.GetType().Name));
            }
            Console.ReadKey();
        }
    }
}
