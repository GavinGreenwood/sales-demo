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
    }

}
