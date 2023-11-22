using Abp.Localization;
using Abp.UI;
using SalesDemo.Authorization;
using SalesDemo.Editions;
using SalesDemo.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;
using SalesDemo.Products.Dtos;
using Abp.Runtime.Validation;

namespace SalesDemo.Tests.Products
{
    // ReSharper disable once InconsistentNaming
    public class ProductsAppService_Tests : AppTestBase
    {
        private readonly IProductsAppService _classUnderTest;

        public ProductsAppService_Tests()
        {
            _classUnderTest = Resolve<IProductsAppService>();
        }

        public class Create : ProductsAppService_Tests
        {

            [Fact()]
            public async Task GivenCreate_WhenNameIsTooShort_ShouldThrowUserFriendlyException()
            {
                var input = new CreateOrEditProductDto
                {
                    Name = "Te",
                    Description = "Test Description",
                    Sku = "12345678",
                };

                await Assert.ThrowsAsync<AbpValidationException>(() => _classUnderTest.CreateOrEdit(input));
            }

            [Fact()]
            public async Task GivenCreate_WhenPruductSkuNot8Characters_ShouldThrowUserFriendlyException()
            {
                var input = new CreateOrEditProductDto
                {
                    Name = "Test Product",
                    Description = "Test Description",
                    Sku = "1234567",
                };

                await Assert.ThrowsAsync<AbpValidationException>(() => _classUnderTest.CreateOrEdit(input));
            }

            [Fact()]
            public async Task GivenCreate_ShouldMapDtoToEntityAndCreateProduct()
            {
                var input = new CreateOrEditProductDto
                {
                    Name = "Test Product",
                    Description = "Test Description",
                    Sku = "12345678",
                };

                await _classUnderTest.CreateOrEdit(input);

                var product = UsingDbContext(context => context.Products.FirstOrDefault(p => p.Name == input.Name));
                product.ShouldNotBeNull();
                product.Name.ShouldBe(input.Name);
                product.Description.ShouldBe(input.Description);
                product.Sku.ShouldBe(input.Sku);
            }
        }

        public class Edit : ProductsAppService_Tests
        {
            public Edit() { 
                UsingDbContext(context => context.Products.Add(new Product
                {
                    Name = "Test Product",
                    Description = "Test Description",
                    Sku = "12345678",
                    Id = 1
                }));
            }

            [Fact()]
            public async Task GivenEdit_ShouldMapDtoToEntityAndUpdateProduct()
            {
                var input = new CreateOrEditProductDto
                {
                    Name = "new name",
                    Description = "New Description",
                    Sku = "77777777",
                    Id = 1
                };

                await _classUnderTest.CreateOrEdit(input);

                var product = UsingDbContext(context => context.Products.FirstOrDefault(p => p.Id == input.Id));
                product.ShouldNotBeNull();
                product.Name.ShouldBe(input.Name);
                product.Description.ShouldBe(input.Description);
                product.Sku.ShouldBe(input.Sku);

            }
        }
    }

}
