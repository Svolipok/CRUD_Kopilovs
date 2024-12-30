namespace CRUD_Kopilovs.Models
{
    public enum Status
    {
        Created,
        Paid,
        Delivered
    }

    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
    }
}
