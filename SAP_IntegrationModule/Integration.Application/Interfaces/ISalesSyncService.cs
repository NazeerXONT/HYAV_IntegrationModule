using Integration.Application.DTOs;

namespace Integration.Application.Interfaces;

public interface ISalesSyncService
{
    Task<SalesOrderSyncResultDto> SyncSalesAsync(SalesOrderDto request);
}
