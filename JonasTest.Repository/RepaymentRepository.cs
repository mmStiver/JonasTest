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
	public class RepaymentRepository : IRepaymentRepository
	{
		private readonly data.ScoreCardContext _context;

		public RepaymentRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Repayment>> GetAllAsync()
		{
			var Repayment = await _context.Repayment.ToListAsync();
			return Repayment.Select(r => r.ToTransferObject());
		}
		public async Task<core.Repayment> GetByIdAsync(int unitid)
		{
			var Repayment = await QueryByIdAsync(unitid);
			if (Repayment != null)
				return Repayment.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Repayment Repayment)
		{
			if (await RepaymentExists(Repayment.UNITID))
				return false;
			var newRepayment = Repayment.ToDataObject();
			_context.Repayment.Add(newRepayment);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.Repayment> Repayments)
		{
			var RepaymentRange = Repayments.Where(r =>! _context.Repayment.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			await _context.Repayment.AddRangeAsync(RepaymentRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.Repayment Repayment)
		{
			if (!await RepaymentExists(Repayment.UNITID))
				return false;
			var upRepayment = Repayment.ToDataObject();
			_context.Repayment.Update(upRepayment);

			_context.Update(upRepayment);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await RepaymentExists(unitId))
				return false;
			var toRemove = _context.Repayment.Find(unitId);
			_context.Repayment.Remove(toRemove);
			return !_context.Repayment.Any(r => r.Unitid == unitId);
		}

		private async Task<data.Repayment> QueryByIdAsync(int unitid)
		{
			return await _context.Repayment.FindAsync(unitid);
		}
		private async Task<bool> RepaymentExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
