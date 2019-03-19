using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface IAdmissionsRepository
	{
		Task<IEnumerable<core.Admissions>> GetAllAsync();
		Task<core.Admissions> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Admissions Admissions);
		Task<bool> UpdateAsync(core.Admissions Admissions);
		Task<bool> DeleteAsync(int unitId);
	}
}
