using System.Collections.Generic;
using storefront_service.core.models;

namespace storefront_service.core.contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}