internal class Program
{
    private static void Main(string[] args)
    {
        List<string> products = new List<string>
        {
            "Laptop", "Headphones", "Keyboard", "Mouse", "Monitor", "Smartphone", "Tablet", "Charger"
        };

        Console.WriteLine("Enter a keyword to search for products:");

        string keyword = Console.ReadLine().ToLower();
        var matchedProducts = new List<string>();

        // Filter products by keyword
        foreach (var product in products)
        {
            if (product.ToLower().Contains(keyword))
            {
                matchedProducts.Add(product);
            }
        }

        // Display results
        Console.WriteLine("\nMatching Products:");
        if (matchedProducts.Count > 0)
        {
            foreach (var product in matchedProducts)
            {
                Console.WriteLine(product);
            }
        }
        else
        {
            Console.WriteLine("No products found.");
        }
    }
}