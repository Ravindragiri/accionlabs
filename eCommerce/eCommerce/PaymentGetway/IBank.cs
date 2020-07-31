using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.PaymentGetway
{
    public interface IBank
    {
        decimal GetCharge(decimal orderAmount);
    }
}
