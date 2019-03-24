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
	public class SchoolController : ContextController
	{
		private ISchoolRepository _repository;
		private string baseKey = "school_";

		public SchoolController(ScoreCardContext context, ILoggerFactory logFactory, IMemoryCache memoryCache, IOptions<ApiSettings> options)
			: base(context, logFactory, memoryCache, options)
		{
			this._repository = new SchoolRepository(this._context);
		}

		// GET api/School/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.School>> Get(int unitId)
		{
			Core.School school;

			school = GetCacheValue<Core.School>(baseKey + unitId);
			if (school != null) return school;

			school = await this._repository.GetByIdAsync(unitId);

			AddCacheValue<Core.School>(baseKey + unitId, school);

			return school;
		}

		// POST api/School
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.School value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.School>(baseKey + value.UNITID, value);

			return Ok();
		}

		// PUT api/School/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.School value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.School>(baseKey + value.UNITID, value);

			return Ok();
		}

		// DELETE api/School/5
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
