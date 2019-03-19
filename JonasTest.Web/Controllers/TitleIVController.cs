using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

using JonasTest.Data.Model;
using JonasTest.Repository;
using JonasTest.Repository.Interface;

namespace JonasTest.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TitleIVController : ContextController
	{
		private ITitleIVRepository _repository;
		
		public TitleIVController(ScoreCardContext context, ILoggerFactory logFactory)
			: base(context, logFactory)
		{
			this._repository = new TitleIVRepository(this._context);
		}

		// GET api/TitleIV/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.TitleIV>> Get(int unitId)
		{
			var TitleIV = await this._repository.GetByIdAsync(unitId);

			return TitleIV;
		}

		// POST api/TitleIV
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.TitleIV value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();
			return Ok();
		}

		// PUT api/TitleIV/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.TitleIV value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			return Ok();
		}

		// DELETE api/TitleIV/5
		[HttpDelete("{unitId}")]
		public async Task<ActionResult> Delete(int unitId)
		{
			await this._repository.DeleteAsync(unitId);
			await _context.SaveChangesAsync();

			if (await _repository.GetByIdAsync(unitId) == null)
				return Ok();
			else return BadRequest();
		}
	}
}
