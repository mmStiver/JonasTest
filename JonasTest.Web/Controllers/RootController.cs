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
	public class RootController : ContextController
	{
		private IRootRepository _repository;
		private string baseKey = "root_";

		public RootController(ScoreCardContext context, ILoggerFactory logFactory, IMemoryCache memoryCache)
			: base(context, logFactory, memoryCache)
		{
			this._repository = new RootRepository(this._context);
		}

		// GET api/root/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Root>> Get(int unitId)
		{
			Core.Root root;

			root = GetCacheValue<Core.Root>(baseKey + unitId);
			if (root != null) return root;

			root = await this._repository.GetByIdAsync(unitId);

			AddCacheValue<Core.Root>(baseKey + unitId, root);

			return root;
		}

		// POST api/root
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Root value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Root>(baseKey + value.UNITID, value);

			return Ok();
		}

		// PUT api/root/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Root value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Root>(baseKey + value.UNITID, value);

			return Ok();
		}

		// DELETE api/root/5
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
