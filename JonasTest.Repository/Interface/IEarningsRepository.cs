using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface IEarningsRepository
    {
		Task<IEnumerable<core.Earnings>> GetAllAsync();
		Task<core.Earnings> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Earnings Earnings);
		Task<bool> UpdateAsync(core.Earnings Earnings);
		Task<bool> DeleteAsync(int unitId);
	}
}
