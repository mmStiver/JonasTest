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
	public class CompletionRepository : ICompletionRepository
	{
		private readonly data.ScoreCardContext _context;

		public CompletionRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Completion>> GetAllAsync()
		{
			var Completion = await _context.Completion.ToListAsync();
			return Completion.Select(r => r.ToTransferObject());
		}
		public async Task<core.Completion> GetByIdAsync(int unitid)
		{
			var Completion = await QueryByIdAsync(unitid);
			if (Completion != null)
				return Completion.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Completion Completion)
		{
			if (await CompletionExists(Completion.UNITID))
				return false;
			var newCompletion = Completion.ToDataObject();
			_context.Completion.Add(newCompletion);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.Completion> Completions)
		{
			var CompletionRange = Completions.Where(r => !_context.Completion.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			_context.Completion.AddRange(CompletionRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.Completion Completion)
		{
			if (!await CompletionExists(Completion.UNITID))
				return false;
			var upCompletion = Completion.ToDataObject();
			_context.Completion.Update(upCompletion);

			_context.Update(upCompletion);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await CompletionExists(unitId))
				return false;
			var toRemove = _context.Completion.Find(unitId);
			_context.Completion.Remove(toRemove);
			return !_context.Completion.Any(r => r.Unitid == unitId);
		}

		private async Task<data.Completion> QueryByIdAsync(int unitid)
		{
			return await _context.Completion.FindAsync(unitid);
		}
		private async Task<bool> CompletionExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
