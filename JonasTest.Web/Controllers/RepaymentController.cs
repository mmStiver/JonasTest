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
	public class RepaymentController : ContextController
	{
		private IRepaymentRepository _repository;
		private string baseKey = "repayment_";

		public RepaymentController(ScoreCardContext context, ILoggerFactory logFactory, IMemoryCache memoryCache, IOptions<ApiSettings> options)
			: base(context, logFactory, memoryCache, options)
		{
			this._repository = new RepaymentRepository(this._context);
		}

		// GET api/Repayment/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Repayment>> Get(int unitId)
		{
			Core.Repayment repayment;

			repayment = GetCacheValue<Core.Repayment>(baseKey + unitId);
			if (repayment != null) return repayment;

			repayment = await this._repository.GetByIdAsync(unitId);

			AddCacheValue<Core.Repayment>(baseKey + unitId, repayment);

			return repayment;
		}

		// POST api/Repayment
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Repayment value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Repayment>(baseKey + value.UNITID, value);

			return Ok();
		}

		// PUT api/Repayment/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Repayment value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Repayment>(baseKey + value.UNITID, value);

			return Ok();
		}

		// DELETE api/Repayment/5
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
