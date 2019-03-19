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
	public class CostRepository : ICostRepository
	{
		private readonly data.ScoreCardContext _context;

		public CostRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Cost>> GetAllAsync()
		{
			var Cost = await _context.Cost.ToListAsync();
			return Cost.Select(r => r.ToTransferObject());
		}
		public async Task<core.Cost> GetByIdAsync(int unitid)
		{
			var cost = await QueryByIdAsync(unitid);
			if (cost != null)
				return cost.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Cost cost)
		{
			if (await CostExists(cost.UNITID))
				return false;
			var newCost = cost.ToDataObject();
			_context.Cost.Add(newCost);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.Cost> Costs)
		{
			var CostRange = Costs.Where(r =>! _context.Cost.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			await _context.Cost.AddRangeAsync(CostRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.Cost Cost)
		{
			if (!await CostExists(Cost.UNITID))
				return false;
			var upCost = Cost.ToDataObject();
			_context.Cost.Update(upCost);

			_context.Update(upCost);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await CostExists(unitId))
				return false;
			var toRemove = _context.Cost.Find(unitId);
			_context.Cost.Remove(toRemove);
			return !_context.Cost.Any(r => r.Unitid == unitId);
		}

		private async Task<data.Cost> QueryByIdAsync(int unitid)
		{
			return await _context.Cost.FindAsync(unitid);
		}
		private async Task<bool> CostExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
