using Microsoft.AspNetCore.Mvc;
using storefront_service.core.models;
using storefront_service.core.contracts;

namespace storefront_service.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IEnumerable<Product> GetProducts()
    {
        return new List<Product>();
    }
}