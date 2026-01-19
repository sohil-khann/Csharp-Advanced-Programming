namespace LambdaAndLinq.ProductManagement
{
    public class Product
    {
        public required string Name { get; set; }
        public required string Category { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Category: {Category}, Price: {Price:C}";
        }
    }
}
