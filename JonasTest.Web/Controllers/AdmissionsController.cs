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
	public class AdmissionsController : ContextController
	{
		private IAdmissionsRepository _repository;
		private string baseKey = "admission_";

		public AdmissionsController(ScoreCardContext context, ILoggerFactory logFactory, IMemoryCache memoryCache, IOptions<ApiSettings> options)
			: base(context, logFactory, memoryCache, options)
		{
			this._repository = new AdmissionsRepository(this._context);
		}

		// GET api/Admissions/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Admissions>> Get(int unitId)
		{
			Core.Admissions Admissions;

			Admissions = GetCacheValue<Core.Admissions>(baseKey + unitId);
			if (Admissions != null) return Admissions;

			Admissions = await this._repository.GetByIdAsync(unitId);

			AddCacheValue<Core.Admissions>(baseKey + unitId, Admissions);

			return Admissions;
		}

		// POST api/Admissions
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Admissions value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Admissions>(baseKey + value.UNITID, value);

			return Ok();
		}

		// PUT api/Admissions/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Admissions value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			AddCacheValue<Core.Admissions>(baseKey + value.UNITID, value);

			return Ok();
		}

		// DELETE api/Admissions/5
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
