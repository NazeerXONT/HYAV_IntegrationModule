using Integration.Application.DTOs;

namespace Integration.Application.Interfaces;

public interface ISalesSyncService
{
    Task<CustomerSyncResultDto> SyncCustomersFromSapAsync(XontCustomerSyncRequestDto request);
}
