using System.Threading.Tasks;
using TalkEcommerce.Context;
using TalkEcommerce.Entities;

namespace TalkEcommerce.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly TalkECommerceDbContext _talkEcommerceDbContxt;
        public ProductRepository(TalkECommerceDbContext talkECommerceDbContext)
        {
            _talkEcommerceDbContxt = talkECommerceDbContext;
        }

        public async Task Add(Product product)
        {
            await _talkEcommerceDbContxt.Products.AddAsync(product);
            await _talkEcommerceDbContxt.SaveChangesAsync();
        }
    }
}
