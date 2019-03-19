using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface ISchoolRepository
	{
		Task<IEnumerable<core.School>> GetAllAsync();
		Task<core.School> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.School School);
		Task<bool> UpdateAsync(core.School School);
		Task<bool> DeleteAsync(int unitId);
	}
}
