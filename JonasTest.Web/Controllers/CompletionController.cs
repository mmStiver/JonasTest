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
	public class CompletionController : ContextController
	{
		private ICompletionRepository _repository;
		
		public CompletionController(ScoreCardContext context, ILoggerFactory logFactory)
			: base(context, logFactory)
		{
			this._repository = new CompletionRepository(this._context);
		}

		// GET api/Completion/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Completion>> Get(int unitId)
		{
			var Completion = await this._repository.GetByIdAsync(unitId);

			return Completion;
		}

		// POST api/Completion
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Completion value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();
			return Ok();
		}

		// PUT api/Completion/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Completion value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

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
			else return BadRequest();
		}
	}
}
