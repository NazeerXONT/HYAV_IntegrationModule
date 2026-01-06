using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Integration.Domain.Entities;

namespace Integration.Application.Interfaces;

public interface IBusinessUnitRepository
{
    Task<List<BusinessUnitDBMAP>> GetAllActiveBusinessUnitsAsync();
    Task<BusinessUnitDBMAP?> GetBusinessUnitByCodeAsync(string businessUnitCode);
    Task<BusinessUnitDBMAP> GetBusinessUnitByDivisionAsync(string division);
}
