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
	public class CompletionController : ContextController
	{
		private ICompletionRepository _repository;
		private string baseKey = "completion_";

		public CompletionController(ScoreCardContext context, ILoggerFactory logFactory, IMemoryCache memoryCache, IOptions<ApiSettings> options)
			: base(context, logFactory, memoryCache, options)
		{
			this._repository = new CompletionRepository(this._context);
		}

		// GET api/Completion/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Completion>> Get(int unitId)
		{
			Core.Completion completion;

			completion = GetCacheValue<Core.Completion>(baseKey + unitId);
			if (completion != null) return completion;

			completion = await this._repository.GetByIdAsync(unitId);

			AddCacheValue<Core.Completion>(baseKey + unitId, completion);

			return completion;
		}

		// POST api/Completion
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Completion value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Completion>(baseKey + value.UNITID, value);

			return Ok();
		}

		// PUT api/Completion/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Completion value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Completion>(baseKey + value.UNITID, value);

			return Ok();
		}

		// DELETE api/Completion/5
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
