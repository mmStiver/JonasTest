using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface IStudentRepository
	{
		Task<IEnumerable<core.Student>> GetAllAsync();
		Task<core.Student> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Student Student);
		Task<bool> UpdateAsync(core.Student Student);
		Task<bool> DeleteAsync(int unitId);
	}
}
