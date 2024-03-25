namespace Entities.Concretes
{
	public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public Decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public short UnitsInStock { get; set; }

    }
}
