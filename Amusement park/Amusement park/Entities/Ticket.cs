namespace Amusement_park
{
    public class Ticket
    {
        static int id = 0;
        public int Id { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public string Sort { get; set; }

        public int Price { get; set; }

        public DateTime Validity { get; set; }
        public Ticket()
        {
            
        }
        public Ticket(Ticket t)
        {
            Id = id;
            id++;
            DateOfPurchase = t.DateOfPurchase;
            Sort = t.Sort;
            Price = t.Price;
            Validity = t.Validity;
        }

        public Ticket(int idFromBody,Ticket t)
        {
            Id = idFromBody;
            DateOfPurchase = t.DateOfPurchase;
            Sort = t.Sort;
            Price = t.Price;
            Validity = t.Validity;
        }
    }
}
