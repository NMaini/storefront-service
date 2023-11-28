using System.Collections.Generic;
using storefront_service.core.contracts;
using storefront_service.core.models;

namespace storefront_service.core.services
{
    public class ProductService: IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>();
        }
    }
}