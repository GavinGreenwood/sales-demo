using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SalesDemo.MultiTenancy.HostDashboard.Dto;

namespace SalesDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}