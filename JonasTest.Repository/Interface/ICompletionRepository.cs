using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;
namespace JonasTest.Repository.Interface
{
    public interface ICompletionRepository
    {
		Task<IEnumerable<core.Completion>> GetAllAsync();
		Task<core.Completion> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Completion Completion);
		Task<bool> UpdateAsync(core.Completion Completion);
		Task<bool> DeleteAsync(int unitId);
	}
}
