using System;
public class ProductService
{
    public  List<IProduct> _inventry = new();

    public ProductService()
    {
        _inventry = new List<IProduct>();
    }
    public void Add(IProduct product)
    {
        _inventry.Add(product); 
    }

    public ProductFilterModel GetFilterDate()
    {
        ProductFilterModel productFilterModel = new ProductFilterModel();
        productFilterModel.ProductTypes = _inventry.Select(item => item.GetType().Name).Distinct();
        return productFilterModel;
    }

    public IEnumerable<IProduct> Get(ProductFilterModel productFilterModel)
    {
        var products = _inventry.Where(product => productFilterModel.ProductTypes.Contains(product.GetType().Name));
        return products = new List<IProduct>(products);
    }
    public IProduct Order(Guid productId)
    {
        IProduct product = _inventry.FirstOrDefault(item => item.Id.Equals(productId));
        if (product == null)
        {
            throw new ArgumentException("product not found");
        }
        product.IsOrdered = true;
        return product;
    }
    public IProduct Return(Guid productId) 
    {
        IProduct product = _inventry.FirstOrDefault(item => item.Id.Equals(productId));
        if (product == null)
        {
            throw new Exception("product not found");
        }
        product.IsOrdered = false;
        return product;
    }


}

