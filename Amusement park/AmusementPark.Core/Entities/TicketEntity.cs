namespace AmusementPark.Core.Entities
{
    public class TicketEntity
    {
        public int Id { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public string Sort { get; set; }

        public int Price { get; set; }

        public DateTime Validity { get; set; }

        public TicketEntity()
        {
            
        }
        public void Copy(TicketEntity t)
        {
            Id = t.Id;
            DateOfPurchase = t.DateOfPurchase;
            Sort = t.Sort;
            Price = t.Price;
            Validity = t.Validity;
        }


        //public TicketEntity(int id,DateTime dateOfPurchase, string sort, int price, DateTime validity)
        //{
        //    Id = id;
        //    DateOfPurchase = dateOfPurchase;
        //    Sort = sort;
        //    Price = price;
        //    Validity = validity;
        //}
    }
}
