using System.Collections.Generic;

namespace Amusement_park
{
    public class Order
    {
        static int id = 0;
        public int Id { get; set; }

        public int TicketId { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int FinallPrice { get; set; }

        public string PaymentMethod { get; set; }

        public int Quantity { get; set; }

        public Order()
        {
            
        }
        public Order(Order o)
        {
            Id = id;
            id++;
            TicketId = o.TicketId;
            CustomerId = o.CustomerId;
            OrderDate = o.OrderDate;
            FinallPrice = o.FinallPrice;
            PaymentMethod = o.PaymentMethod;
            Quantity = o.Quantity;
        }

        public Order(int idFromBody,Order o)
        {
            Id = idFromBody;
            TicketId = o.TicketId;
            CustomerId = o.CustomerId;
            OrderDate = o.OrderDate;
            FinallPrice = o.FinallPrice;
            PaymentMethod = o.PaymentMethod;
            Quantity = o.Quantity;
        }
        public Order(int ticketId, int customerId, DateTime orderDate, int finallPrice, string paymentMethod, int quantity)
        {
            Id = id;
            id++;  
            TicketId = ticketId;
            CustomerId = customerId;
            OrderDate = orderDate;
            FinallPrice = finallPrice;
            PaymentMethod = paymentMethod;
            Quantity = quantity;
        }
    }
}
