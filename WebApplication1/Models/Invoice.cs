namespace WebApplication1.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public DateOnly DateIssue { get; set; }
        public string InvoiceNumberId { get; set; }

        public string BillPicture { get; set; }

        public long TotalPrice { get; set; } // PRICE + TAXES
        //class
        public Item item { get; set; }
    }
}
