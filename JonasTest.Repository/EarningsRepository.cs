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
	public class EarningsRepository : IEarningsRepository
	{
		private readonly data.ScoreCardContext _context;

		public EarningsRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Earnings>> GetAllAsync()
		{
			var Earnings = await _context.Earnings.ToListAsync();
			return Earnings.Select(r => r.ToTransferObject());
		}
		public async Task<core.Earnings> GetByIdAsync(int unitid)
		{
			var earnings = await QueryByIdAsync(unitid);
			if (earnings != null)
				return earnings.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Earnings earnings)
		{
			if (await EarningsExists(earnings.UNITID))
				return false;
			var newEarnings = earnings.ToDataObject();
			_context.Earnings.Add(newEarnings);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.Earnings> earningss)
		{
			var EarningsRange = earningss.Where(r =>! _context.Earnings.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			await _context.Earnings.AddRangeAsync(EarningsRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.Earnings earnings)
		{
			if (!await EarningsExists(earnings.UNITID))
				return false;
			var upEarnings = earnings.ToDataObject();
			_context.Earnings.Update(upEarnings);

			_context.Update(upEarnings);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await EarningsExists(unitId))
				return false;
			var toRemove = _context.Earnings.Find(unitId);
			_context.Earnings.Remove(toRemove);
			return !_context.Earnings.Any(r => r.Unitid == unitId);
		}

		private async Task<data.Earnings> QueryByIdAsync(int unitid)
		{
			return await _context.Earnings.FindAsync(unitid);
		}
		private async Task<bool> EarningsExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
