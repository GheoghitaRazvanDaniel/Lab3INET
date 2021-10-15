using System.Collections.Generic;

namespace TSP.NET.L3.Refactored
{
    class PaymentContext
    {
        private Dictionary<PaymentMethod, IPayment> strategies = new Dictionary<PaymentMethod, IPayment>();
        public PaymentContext()
        {
            strategies.Add(PaymentMethod.CreditCard, new CardPayment());
            strategies.Add(PaymentMethod.Cash, new CashPayment());
        }

        public void compute(PaymentDetails payment, TicketDetails ticket)
        {
            strategies[payment.Method].BuyTicket(ticket);
        }

    }
}
