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
	public class AdmissionsRepository : IAdmissionsRepository
	{
		private readonly data.ScoreCardContext _context;

		public AdmissionsRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Admissions>> GetAllAsync()
		{
			var Admissions = await _context.Admissions.ToListAsync();
			return Admissions.Select(r => r.ToTransferObject());
		}
		public async Task<core.Admissions> GetByIdAsync(int unitid)
		{
			var Admissions = await QueryByIdAsync(unitid);
			if (Admissions != null)
				return Admissions.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Admissions Admissions)
		{
			if (await AdmissionsExists(Admissions.UNITID))
				return false;
			var newAdmissions = Admissions.ToDataObject();
			_context.Admissions.Add(newAdmissions);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.Admissions> Admissionss)
		{
			var AdmissionsRange = Admissionss.Where(r => _context.Admissions.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			_context.Admissions.AddRange(AdmissionsRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.Admissions Admissions)
		{
			if (!await AdmissionsExists(Admissions.UNITID))
				return false;
			var upAdmissions = Admissions.ToDataObject();
			_context.Admissions.Update(upAdmissions);

			_context.Update(upAdmissions);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await AdmissionsExists(unitId))
				return false;
			var toRemove = _context.Admissions.Find(unitId);
			_context.Admissions.Remove(toRemove);
			return !_context.Admissions.Any(r => r.Unitid == unitId);
		}

		private async Task<data.Admissions> QueryByIdAsync(int unitid)
		{
			return await _context.Admissions.FindAsync(unitid);
		}
		private async Task<bool> AdmissionsExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
