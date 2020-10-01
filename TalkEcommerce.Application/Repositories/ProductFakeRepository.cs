using System;
using System.Threading.Tasks;
using TalkEcommerce.Entities;

namespace TalkEcommerce.Repositories
{
    public class ProductFakeRepository : IProductRepository
    {
        public Task Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
