namespace Orders.Common.Model
{
    public class Order
    {
        public int OrderID { get; set; } = -1;
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
