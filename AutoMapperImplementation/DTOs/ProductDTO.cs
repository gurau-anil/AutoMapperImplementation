namespace AutoMapperImplementation.DTOs
{
    public class ProductDTO
    {
		public int ProductID { get; set; }
		public string ProductNumber { get; set; }
		public string Colour { get; set; }
		public decimal StandardCost { get; set; }
		public decimal ListPrice { get; set; }
		public string Size { get; set; }
		public decimal Weight { get; set; }
		public int ProductCategoryID { get; set; }
		public int ProductModelID { get; set; }
	}
}
