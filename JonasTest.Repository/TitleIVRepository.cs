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
	public class TitleIVRepository : ITitleIVRepository
	{
		private readonly data.ScoreCardContext _context;

		public TitleIVRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.TitleIV>> GetAllAsync()
		{
			var titleIV = await _context.TitleIv.ToListAsync();
			return titleIV.Select(r => r.ToTransferObject());
		}
		public async Task<core.TitleIV> GetByIdAsync(int unitid)
		{
			var titleIV = await QueryByIdAsync(unitid);
			if (titleIV != null)
				return titleIV.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.TitleIV titleIV)
		{
			if(await TitleIVExists(titleIV.UNITID))
				return false;

			//Use Gateway to stored proc
			var gateway = new Data.GateWay.TitleIVGateway(_context.Database.GetDbConnection().ConnectionString);

			var result = await gateway.InsertTitleIV(titleIV.ToDataObject());
			return result;

				//EF Can't handle object size.
			//if (await TitleIVExists(TitleIV.UNITID))
			//	return false;
			//var newTitleIV = TitleIV.ToDataObject();
			//_context.TitleIv.Add(newTitleIV);
			//return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.TitleIV> TitleIVs)
		{
			var titleIVRange = TitleIVs.Where(r => !_context.TitleIv.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			await _context.TitleIv.AddRangeAsync(titleIVRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.TitleIV TitleIV)
		{
			if (!await TitleIVExists(TitleIV.UNITID))
				return false;
			var upTitleIV = TitleIV.ToDataObject();
			_context.TitleIv.Update(upTitleIV);

			_context.Update(upTitleIV);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await TitleIVExists(unitId))
				return false;
			var toRemove = _context.TitleIv.Find(unitId);
			_context.TitleIv.Remove(toRemove);
			return !_context.TitleIv.Any(r => r.Unitid == unitId);
		}

		private async Task<data.TitleIv> QueryByIdAsync(int unitid)
		{
			return await _context.TitleIv.FindAsync(unitid);
		}
		private async Task<bool> TitleIVExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
