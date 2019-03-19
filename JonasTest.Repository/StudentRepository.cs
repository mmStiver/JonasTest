using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;

using data = JonasTest.Data.Model;
using core = JonasTest.Core;
using JonasTest.Repository.ConverterExtention;
using JonasTest.Repository.Interface;

namespace JonasTest.Repository
{
	public class StudentRepository : IStudentRepository
	{
		private readonly data.ScoreCardContext _context;

		public StudentRepository(data.ScoreCardContext dataContext)
		{
			_context = dataContext;
		}

		public async Task<IEnumerable<core.Student>> GetAllAsync()
		{
			var Student = await _context.Student.ToListAsync();
			return Student.Select(r => r.ToTransferObject());
		}
		public async Task<core.Student> GetByIdAsync(int unitid)
		{
			var Student = await QueryByIdAsync(unitid);
			if (Student != null)
				return Student.ToTransferObject();
			return null;
		}
		public async Task<bool> AddAsync(core.Student Student)
		{
			if (await StudentExists(Student.UNITID))
				return false;
			var newStudent = Student.ToDataObject();
			_context.Student.Add(newStudent);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> AddRange(List<core.Student> Students)
		{
			var StudentRange = Students.Where(r => !_context.Student.Any(x => x.Unitid == r.UNITID)).AsParallel().Select(r => r.ToDataObject());
			await _context.Student.AddRangeAsync(StudentRange);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> UpdateAsync(core.Student Student)
		{
			if (!await StudentExists(Student.UNITID))
				return false;
			var upStudent = Student.ToDataObject();
			_context.Student.Update(upStudent);

			_context.Update(upStudent);
			return _context.ChangeTracker.HasChanges();
		}
		public async Task<bool> DeleteAsync(int unitId)
		{
			if (!await StudentExists(unitId))
				return false;
			var toRemove = _context.Student.Find(unitId);
			_context.Student.Remove(toRemove);
			return !_context.Student.Any(r => r.Unitid == unitId);
		}

		private async Task<data.Student> QueryByIdAsync(int unitid)
		{
			return await _context.Student.FindAsync(unitid);
		}
		private async Task<bool> StudentExists(int unitid)
		{
			return await QueryByIdAsync(unitid) != null;
		}
	}
}
