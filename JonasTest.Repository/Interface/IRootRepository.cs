﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using core = JonasTest.Core;

namespace JonasTest.Repository.Interface
{
    public interface IRootRepository: IRepository
	{
		Task<IEnumerable<core.Root>> GetAllAsync(int take, int skip);
		Task<core.Root> GetByIdAsync(int unitid);
		Task<bool> AddAsync(core.Root root);
		Task<bool> UpdateAsync(core.Root root);
		Task<bool> DeleteAsync(int unitId);
		Task<core.Root> GetByOpeidAsync(string opeid);
		Task<core.Root> GetByRootByOpeid6Async(int opeid6);
	}
}
