using Autofac.Extras.Moq;
using Ecommerance.Core.Domain;
using Ecommerance.Core.Repositories;
using Ecommerance.Infrastucture.Helpers;
using Ecommerance.Infrastucture.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ecommerance.tests.Repositories
{

    public class ProductRepositoryTest
    {
        [Fact]
        public async Task add_async_should_add_async_on_product_repository()
        {
            //Arrange
            var logger = new Mock<ILogger<ProductRepository>>();

            var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "MovieListDatabase")
            .Options;

            var context = new AppDbContext(options);

                context.Product.Add(new Product(Guid.NewGuid()
                                                , 1
                                                , 1
                                                , "żółty"
                                                , "s"
                                                , Guid.Parse("b974a7cf-68ce-4b35-ab89-2101c253a670")
                                                , Guid.Parse("d37aa518-6978-434d-8c54-f88af0eea3c8")
                                                , Guid.Parse("20d0b89a-d37a-4f1d-b8bb-dc213c8cae5a")
                                                , new Guid()
                                                , 109.90));
                context.SaveChanges();
            

            //Act
            var newProduct = new Product(Guid.NewGuid(), 1, 1, "żółty", "s", Guid.Parse("b974a7cf-68ce-4b35-ab89-2101c253a670"), Guid.Parse("d37aa518-6978-434d-8c54-f88af0eea3c8"), Guid.Parse("20d0b89a-d37a-4f1d-b8bb-dc213c8cae5a"), new Guid(), 109.90);
            
                ProductRepository productRepository = new ProductRepository(logger.Object, context);
                await productRepository.AddAsync(newProduct);

            //Assert
                var existingProduct = await productRepository.GetByIdAsync(newProduct.Id);

                Assert.Equal(newProduct, existingProduct);
                
            


            
        }


    }
}
