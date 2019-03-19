using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface ICostRepository
	{
		Task<IEnumerable<core.Cost>> GetAllAsync();
		Task<core.Cost> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Cost Cost);
		Task<bool> UpdateAsync(core.Cost Cost);
		Task<bool> DeleteAsync(int unitId);
	}
}
