﻿using System.Threading.Tasks;
using Abp.Application.Services;
using SalesDemo.Sessions.Dto;

namespace SalesDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
