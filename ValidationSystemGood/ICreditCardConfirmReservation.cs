using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSystemGood
{
    public interface ICreditCardConfirmReservation : IFreeConfirmReservation
    {
        string CreditCard { get; set; }
        bool PaymentCreditCard();
    }
}
