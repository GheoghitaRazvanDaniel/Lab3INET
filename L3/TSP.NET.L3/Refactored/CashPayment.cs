using System;

namespace TSP.NET.L3.Refactored
{
    class CashPayment : IPayment
    {
        private decimal _cashAccepted;
        Action action;

        public CashPayment()
        {
            this.action = onPayChangeToMobilePhone;
        }
        public void BuyTicket(TicketDetails ticket)
        {
            AcceptCash(ticket);
            DispenseChange(ticket);
        }
        private void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }

        private void DispenseChange(TicketDetails ticket)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                this.action?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; //or true :)
        }

        public void onPayChangeToMobilePhone()
        {
            // Aici ar fi actiunea onPayChangeToMobilePhone
        }
    }
}
