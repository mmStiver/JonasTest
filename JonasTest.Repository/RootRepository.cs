using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;

using data = JonasTest.Data.Model;
using core = JonasTest.Core;
using JonasTest.Repository.ConverterExtention;
using JonasTest.Repository.Interface;

namespace JonasTest.Repository
{
    public class RootRepository : IRootRepository
	{
		private readonly data.ScoreCardContext _context;

		public RootRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Root>> GetAllAsync()
		{
			var root = await _context.Root.ToListAsync();
			return root.Select(r => r.ToTransferObject());
		}
		public async Task<core.Root> GetByIdAsync(int unitid)
		{
			var root = await QueryByIdAsync(unitid);
			if(root != null)
				return root.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Root root)
		{
			if (await RootExists(root.UNITID))
				return false;
			var newRoot = root.ToDataObject();
			_context.Root.Add(newRoot);
			return true;
		}
		public async Task<bool> AddRange(List<core.Root> roots)
		{
			var rootRange = roots.Where(r => ! _context.Root.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject()).ToList();
			await _context.Root.AddRangeAsync(rootRange);
			return true;
		}
		public async Task<bool> UpdateAsync(core.Root root )
		{
			if (!await RootExists(root.UNITID))
				return false;
			var upRoot = root.ToDataObject();
			_context.Root.Update(upRoot);

			_context.Update(upRoot);
			return true;
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await RootExists(unitId))
				return false;
			var toRemove = _context.Root.Find(unitId);
			_context.Root.Remove(toRemove);
			return !_context.Root.Any(r => r.Unitid == unitId);
		}
		public async Task<core.Root> GetByOpeidAsync(int opeid )
		{
			var root = await _context.Root.Where(a => a.Opeid == opeid).FirstAsync();
			return root.ToTransferObject();
		}
		public async Task<core.Root> GetByRootByOpeid6Async(int opeid6)
		{
			var root = await _context.Root.Where(a => a.Opeid6 == opeid6).FirstAsync();
			return root.ToTransferObject();
		}
	
		private async Task<data.Root> QueryByIdAsync(int unitid)
		{
			return await _context.Root.FindAsync(unitid);
		}
		private async Task<bool> RootExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
