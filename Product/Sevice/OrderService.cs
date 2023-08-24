using System;
public class OrderService
{
    private readonly ProductService _productService;
    private readonly PaymentService _paymentService;

    public OrderService(ProductService productService, PaymentService paymentService)
    {
        _paymentService = paymentService;
        _paymentService = paymentService;
    }

    public bool Order(Guid id, DibitCard card)
    {
        var product  = _productService.Order(id);
        if(product is not null )
        {
            try
            {
                _paymentService.Checkout(product.Price, card);
                return true;
            }
            catch (Exception)
            {
                _productService.Return(id);
                return false;
            }
             
        }
        return false;
    }

    public bool Order(ProductFilterModel productFilterModel, DibitCard card)
    {
        var products = _productService.Get(productFilterModel);
        try
        {
            if (products is not null)
            {
                foreach (var product in products)
                {
                    _paymentService.Checkout(product.Price, card);
                    return true;
                }
            }
        } catch (Exception ex)
        {
            foreach (var product in products)
                _productService.Return(product.Id);
            return false;
        }
        return false;
    }
}
