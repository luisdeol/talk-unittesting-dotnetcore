using System.Threading.Tasks;
using TalkEcommerce.Entities;

namespace TalkEcommerce.Repositories
{
    public interface IProductRepository
    {
        Task Add(Product product);
    }
}