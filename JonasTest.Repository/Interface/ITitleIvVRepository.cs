using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface ITitleIVRepository
	{
		Task<IEnumerable<core.TitleIV>> GetAllAsync();
		Task<core.TitleIV> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.TitleIV TitleIV);
		Task<bool> UpdateAsync(core.TitleIV TitleIV);
		Task<bool> DeleteAsync(int unitId);
		
		
	}
}
