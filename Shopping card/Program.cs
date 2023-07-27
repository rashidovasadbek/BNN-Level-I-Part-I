
Console.WriteLine("1.Mahsulot topib qo'shish");
Console.WriteLine("2.Mahsulot topoib o'chirish");
var choose = char.Parse(Console.ReadLine());

Console.WriteLine("product id:");
var product_id = int.Parse(Console.ReadLine());

Console.WriteLine("product name:");
var product_name = Console.ReadLine();
Console.WriteLine();

var shopping = new ShoppingCart();

Product product1 = new Product(1, "kartoshka");
Product product2 = new Product(2, "piyoz");
Product product3 = new Product(3, "sabzi");
shopping.items.Add(product1,3);
shopping.items.Add(product2,5);
shopping.items.Add(product3,8);

switch (choose)
{
    case '1':
        shopping.Add(new Product(product_id, product_name));

        foreach (var item in shopping.items)
        {
            Console.WriteLine($"{item.Key.Name} - {item.Value}");
        }
        break;
    case '2':
        Console.WriteLine(shopping.Remove(new Product(product_id, product_name)));

        foreach (var item in shopping.items)
        {
            Console.WriteLine($"{item.Key.Name} - {item.Value}");
        }
        break;

}
public class ShoppingCart
{
    public Dictionary<Product,int> items = new Dictionary<Product,int>();    
    
    public void Add(Product product)
    {
        foreach(var item in items)
        {
            if (item.Key.Name == product.Name)
            {
                items[item.Key]++;
                return;
            }
        }
        Console.Write("qo'shiladigan mahsulot sonni:");
        var newproductCount = int.Parse(Console.ReadLine());
        items.Add(product, newproductCount);
    }

    public bool Remove(Product product) 
    {
        foreach (var item in items)
        {
            if (item.Key.Name == product.Name)
            {
                items[item.Key]--;
                return true;
            }
        }
        return false;
    }

}


public class Product
{
    public Product(int id, string name)
    { 
      Id = id;
      Name = name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}
