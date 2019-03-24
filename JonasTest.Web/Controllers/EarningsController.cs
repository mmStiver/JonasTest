using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

using JonasTest.Data.Model;
using JonasTest.Repository;
using JonasTest.Repository.Interface;
using JonasTest.Web.Config;

namespace JonasTest.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EarningsController : ContextController
	{
		private IEarningsRepository _repository;
		private string baseKey = "earnings_";

		public EarningsController(ScoreCardContext context, ILoggerFactory logFactory, IMemoryCache memoryCache, IOptions<ApiSettings> options)
			: base(context, logFactory, memoryCache, options)
		{
			this._repository = new EarningsRepository(this._context);
		}

		// GET api/Earnings/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Earnings>> Get(int unitId)
		{
			Core.Earnings earnings;

			earnings = GetCacheValue<Core.Earnings>(baseKey + unitId);
			if (earnings != null) return earnings;

			earnings = await this._repository.GetByIdAsync(unitId);

			AddCacheValue<Core.Earnings>(baseKey + unitId, earnings);

			return earnings;
		}

		// POST api/Earnings
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Earnings value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Earnings>(baseKey + value.UNITID, value);

			return Ok();
		}

		// PUT api/Earnings/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Earnings value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Earnings>(baseKey + value.UNITID, value);

			return Ok();
		}

		// DELETE api/Earnings/5
		[HttpDelete("{unitId}")]
		public async Task<ActionResult> Delete(int unitId)
		{
			await this._repository.DeleteAsync(unitId);
			await _context.SaveChangesAsync();

			if (await _repository.GetByIdAsync(unitId) == null)
				return Ok();

			RemoveCacheValue(baseKey + unitId);

			return BadRequest();
		}
	}
}
