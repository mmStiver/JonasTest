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
	public class AcademicsRepository : IAcademicsRepository
	{
		private readonly data.ScoreCardContext _context;

		public AcademicsRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Academics>> GetAllAsync()
		{
			var Academics = await _context.Academics.ToListAsync();
			return Academics.Select(r => r.ToTransferObject());
		}
		public async Task<core.Academics> GetByIdAsync(int unitid)
		{
			var Academics = await QueryByIdAsync(unitid);
			if (Academics != null)
				return Academics.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Academics Academics)
		{
			if (await AcademicsExists(Academics.UNITID))
				return false;
			var newAcademics = Academics.ToDataObject();
			_context.Academics.Add(newAcademics);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.Academics> Academicss)
		{
			var AcademicsRange = Academicss.Where(r =>! _context.Academics.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			var li = AcademicsRange.Select(ar => ar.Unitid);
			var li2 = AcademicsRange.GroupBy(ar => ar.Unitid).Where( ar => ar.Count() > 1).ToList();
			await _context.Academics.AddRangeAsync(AcademicsRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.Academics Academics)
		{
			if (!await AcademicsExists(Academics.UNITID))
				return false;
			var upAcademics = Academics.ToDataObject();
			_context.Academics.Update(upAcademics);

			_context.Update(upAcademics);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await AcademicsExists(unitId))
				return false;
			var toRemove = _context.Academics.Find(unitId);
			_context.Academics.Remove(toRemove);
			return !_context.Academics.Any(r => r.Unitid == unitId);
		}

		private async Task<data.Academics> QueryByIdAsync(int unitid)
		{
			return await _context.Academics.FindAsync(unitid);
		}
		private async Task<bool> AcademicsExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
