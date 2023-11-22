using Abp.AspNetCore.Mvc.Authorization;
using SalesDemo.Authorization.Users.Profile;
using SalesDemo.Graphics;
using SalesDemo.Storage;

namespace SalesDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageValidator imageValidator) :
            base(tempFileCacheManager, profileAppService, imageValidator)
        {
        }
    }
}