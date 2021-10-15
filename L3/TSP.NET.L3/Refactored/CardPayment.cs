namespace TSP.NET.L3.Refactored
{
    public class CardPayment : IPayment
    {
        public void BuyTicket(TicketDetails ticket)
        {
            ChargeCard(ticket);
        }

        private void ChargeCard(TicketDetails ticket)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price);
        }
        internal class ProcessingCenterGateway
        {
            public void Charge(decimal ticketPrice)
            {
                //charging process
            }
        }
    }
}
