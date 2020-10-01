using System.Threading.Tasks;
using TalkEcommerce.Context;
using TalkEcommerce.Entities;
using TalkEcommerce.Models;
using TalkEcommerce.Repositories;

namespace TalkEcommerce.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository; 
        public ProductService(IProductRepository talkECommerceDbContext)
        {
            _productRepository = talkECommerceDbContext;  
        }

        public async Task<ProductViewModel> Add(ProductInputModel productInputModel)
        {
            var product = new Product(productInputModel.Title, productInputModel.Description, productInputModel.Price);

            await _productRepository.Add(product);

            return new ProductViewModel(product.Id, product.Title);
        }
    }
}
