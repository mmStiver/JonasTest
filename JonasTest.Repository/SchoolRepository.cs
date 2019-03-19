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
	public class SchoolRepository : ISchoolRepository
	{
		private readonly data.ScoreCardContext _context;

		public SchoolRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.School>> GetAllAsync()
		{
			var School = await _context.School.ToListAsync();
			return School.Select(r => r.ToTransferObject());
		}
		public async Task<core.School> GetByIdAsync(int unitid)
		{
			var School = await QueryByIdAsync(unitid);
			if (School != null)
				return School.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.School School)
		{
			if (await SchoolExists(School.UNITID))
				return false;
			var newSchool = School.ToDataObject();
			_context.School.Add(newSchool);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.School> Schools)
		{
			var SchoolRange = Schools.Where(r => !_context.School.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			_context.School.AddRange(SchoolRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.School School)
		{
			if (!await SchoolExists(School.UNITID))
				return false;
			var upSchool = School.ToDataObject();
			_context.School.Update(upSchool);

			_context.Update(upSchool);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await SchoolExists(unitId))
				return false;
			var toRemove = _context.School.Find(unitId);
			_context.School.Remove(toRemove);
			return !_context.School.Any(r => r.Unitid == unitId);
		}

		private async Task<data.School> QueryByIdAsync(int unitid)
		{
			return await _context.School.FindAsync(unitid);
		}
		private async Task<bool> SchoolExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
