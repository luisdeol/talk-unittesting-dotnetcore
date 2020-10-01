using Moq;
using System.Threading.Tasks;
using TalkEcommerce.Context;
using TalkEcommerce.Entities;
using TalkEcommerce.Models;
using TalkEcommerce.Repositories;
using TalkEcommerce.Services;
using Xunit;

namespace TalkECommerce.UnitTests.Services
{
    public class ProductServiceTests
    {
        [Fact]
        public async Task ProdutoValido_Add_RetornaProdutoVmComMesmosCampos()
        {
            // Arrange
            var productRepositoryMock = new Mock<IProductRepository>();

            var productInputModel = new ProductInputModel("Um chinelo", "Um chinelo tamanho 42", 10);
            
            productRepositoryMock.Setup(pr => pr.Add(It.IsAny<Product>())).Verifiable();

            var productService = new ProductService(productRepositoryMock.Object);

            // Act
            var product = await productService.Add(productInputModel);

            // Assert
            Assert.Equal(productInputModel.Title, product.Title);
            productRepositoryMock.Verify(pr => pr.Add(It.IsAny<Product>()), Times.Once);
        }
    }
}
