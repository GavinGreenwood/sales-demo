using Abp.AspNetCore.Mvc.Authorization;
using SalesDemo.Authorization;
using SalesDemo.Storage;
using Abp.BackgroundJobs;

namespace SalesDemo.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}