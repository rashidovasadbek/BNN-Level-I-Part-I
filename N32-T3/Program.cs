using N32_T3.Model;
using N32_T3.Service;

Product productA = new Product("qovun", "samarqand qovuni");
Product productB = new Product("nok", "shvetiski nok");
Product productC = new Product("behi", "shvetiski behi");
//ProductService.GetInstance();
var  productService = ProductService.GetInstance();
productService.Add("olam", "shvetiski olama");
productService.Add("nok", "shvetiski nok");
productService.Add("behi", "shvetiski behi");

productService.Clone(productService._products[1].Id);

productService.Display();

