using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;

using data = JonasTest.Data.Model;
using core = JonasTest.Core;
using JonasTest.Repository;
using JonasTest.Repository.ConverterExtention;

namespace JonasTest.Parser.Operation
{
	public class BulkOperationCoordinator 
	{
		

	public async Task ProcessRoot(List<Core.Root> roots)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
			var repository = new RootRepository(context);
			await repository.AddRange(roots);
			await context.SaveChangesAsync();
		}
	}
		
		public async Task ProcessAcademics(List<core.Academics> academics)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new AcademicsRepository(context);
				await repository.AddRange(academics);
				await context.SaveChangesAsync();
			}
	}
	public async Task ProcessAdmissions(List<core.Admissions> admissions)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new AdmissionsRepository(context);
				await repository.AddRange(admissions);
				await context.SaveChangesAsync();
			}
	}
	public async Task ProcessCompletion(List<core.Completion> Completions)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new CompletionRepository(context);
				await repository.AddRange(Completions);
				await context.SaveChangesAsync();
			}
	}
	public async Task ProcessCost(List<core.Cost> Costs)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new CostRepository(context);
				await repository.AddRange(Costs);
				await context.SaveChangesAsync();
			}
	}
	public async Task ProcessEarnings(List<core.Earnings> Earningss)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new EarningsRepository(context);
				await repository.AddRange(Earningss);
				await context.SaveChangesAsync();
			}
	}
	public async Task ProcessRepayment(List<core.Repayment> Repayments)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new RepaymentRepository(context);
				await repository.AddRange(Repayments);
				await context.SaveChangesAsync();
			}
	}
	public async Task ProcessSchool(List<core.School> Schools)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new SchoolRepository(context);
				await repository.AddRange(Schools);
				await context.SaveChangesAsync();
			}
	}
	public async Task ProcessTitleIV(List<core.TitleIV> TitleIVs)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new TitleIVRepository(context);
				foreach(var t in TitleIVs)
					await repository.AddAsync(t);
				//await context.SaveChangesAsync();
			}
	}
	public async Task ProcessStudent(List<core.Student> students)
	{
		using (var context = new JonasTest.Data.Model.ScoreCardContext())
		{
				var repository = new StudentRepository(context);
				await repository.AddRange(students);
				await context.SaveChangesAsync();
			}
		}
	}
}