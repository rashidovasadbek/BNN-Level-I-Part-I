var _products = new List<product>()
{
    new product("Asus",3,10),
    new product("Lenova",2,7),
    new product("Acer",3,4),
    new product("Thik Pad",4,9),
    new product("Asus vivo book",4,10),
    new product("HP",4,3),
    new product("Legion",5,8),
    new product("Samsung",4,7),
    new product("Galaxy",5,1),
    new product("Macbook Air",5,1),
};

var products = _products.OrderByDescending(_products => _products.Stars).ThenBy(_products=> _products.Inventory).ToList().Take(5);
foreach(var product in products)
{
    Console.WriteLine($"{product.Name}-{product.Inventory} in stock");
}