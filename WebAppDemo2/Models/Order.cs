namespace WebAppDemo2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public string Phone { get; set; }
        public DateTime OrderTime { get; set; }
        public int BookID { get; set; }
        public int UserID { get; set; }
        public virtual Book? Book { get; set; }
        public virtual User? User { get; set; }
    }
}
