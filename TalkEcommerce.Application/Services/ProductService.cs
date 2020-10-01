using System.Threading.Tasks;
using TalkEcommerce.Context;
using TalkEcommerce.Entities;
using TalkEcommerce.Models;

namespace TalkEcommerce.Services
{
    public class ProductService
    {
        private readonly TalkECommerceDbContext _talkECommerceDbContext; 
        public ProductService()
        {
            _talkECommerceDbContext = new TalkECommerceDbContext();  
        }

        public async Task<ProductViewModel> Add(ProductInputModel productInputModel)
        {
            var product = new Product(productInputModel.Title, productInputModel.Description, productInputModel.Price);
            
            await _talkECommerceDbContext.Products.AddAsync(product);
            await _talkECommerceDbContext.SaveChangesAsync();

            return new ProductViewModel(product.Id, product.Title);
        }
    }
}
