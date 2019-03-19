using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface IAcademicsRepository
	{
		Task<IEnumerable<core.Academics>> GetAllAsync();
		Task<core.Academics> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Academics Academics);
		Task<bool> UpdateAsync(core.Academics Academics);
		Task<bool> DeleteAsync(int unitId);
	}
}
