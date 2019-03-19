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

using JonasTest.Data.Model;
using JonasTest.Repository;
using JonasTest.Repository.Interface;

namespace JonasTest.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CostController : ContextController
	{
		private ICostRepository _repository;
		private string baseKey = "cost_";

		public CostController(ScoreCardContext context, ILoggerFactory logFactory, IMemoryCache memoryCache)
			: base(context, logFactory, memoryCache)
		{
			this._repository = new CostRepository(this._context);
		}

		// GET api/Cost/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Cost>> Get(int unitId)
		{
			Core.Cost cost;

			cost = GetCacheValue<Core.Cost>(baseKey + unitId);
			if (cost != null) return cost;

			cost = await this._repository.GetByIdAsync(unitId);

			AddCacheValue<Core.Cost>(baseKey + unitId, cost);

			return cost;
		}

		// POST api/Cost
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Cost value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Cost>(baseKey + value.UNITID, value);

			return Ok();
		}

		// PUT api/Cost/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Cost value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Cost>(baseKey + value.UNITID, value);


			return Ok();
		}

		// DELETE api/Cost/5
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
