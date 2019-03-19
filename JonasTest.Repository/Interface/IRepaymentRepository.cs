using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface IRepaymentRepository
	{
		Task<IEnumerable<core.Repayment>> GetAllAsync();
		Task<core.Repayment> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Repayment Repayment);
		Task<bool> UpdateAsync(core.Repayment Repayment);
		Task<bool> DeleteAsync(int unitId);
	}
}
