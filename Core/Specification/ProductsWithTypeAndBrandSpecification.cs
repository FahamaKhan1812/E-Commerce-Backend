using Core.Entities;
using System.Linq.Expressions;

namespace Core.Specification;
public class ProductsWithTypeAndBrandSpecification : BaseSpecification<Products>
{
    public ProductsWithTypeAndBrandSpecification()
    {
        AddInclude(x => x.ProductType);
        AddInclude(x => x.ProductBrand);
    }

    public ProductsWithTypeAndBrandSpecification(int id) 
        : base(x => x.Id == id)
    {
        AddInclude(x => x.ProductType);
        AddInclude(x => x.ProductBrand);
    }
}
