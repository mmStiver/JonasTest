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
	public class StudentController : ContextController
	{
		private IStudentRepository _repository;
		
		public StudentController(ScoreCardContext context, ILoggerFactory logFactory)
			: base(context, logFactory)
		{
			this._repository = new StudentRepository(this._context);
		}

		// GET api/Student/5
		[HttpGet("{unitId}")]
		public async Task<ActionResult<Core.Student>> Get(int unitId)
		{
			var Student = await this._repository.GetByIdAsync(unitId);

			return Student;
		}

		// POST api/Student
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] Core.Student value)
		{
			await this._repository.UpdateAsync(value);
			await _context.SaveChangesAsync();
			return Ok();
		}

		// PUT api/Student/5
		[HttpPut("{unitId}")]
		public async Task<ActionResult> Put([FromBody] Core.Student value)
		{
			await this._repository.DeleteAsync(value.UNITID);
			await this._repository.AddAsync(value);
			await _context.SaveChangesAsync();

			return Ok();
		}

		// DELETE api/Student/5
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
