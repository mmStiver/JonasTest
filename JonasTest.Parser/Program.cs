using System;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Diagnostics;
using System.IO;

using JonasTest.Data;
using JonasTest.Core.Common.Extention;
using JonasTest.Data.Model;
using JonasTest.Repository;
using JonasTest.Parser.Operation;

namespace JonasTest.Parser
{
	public class Program
	{

		private List<string> files;
		private const string DataFilePAth = @"Data\";
		private CSVParseManager manager;
		private int loadCount;

		public void Setup()
		{
			files = new List<string>();

			//Get csv Files
			//Loop through found csv files to load
			files.Add(DataFilePAth + "MERGED2016_17_PP.csv");
			loadCount = 100;
		}

		[BenchmarkDotNet.Attributes.Benchmark]
		public async Task Run()
		{

			foreach(var file in this.files) { 
				manager = new CSVParseManager(file);
				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();
				var tasks = new List<Task>();
				await ProcessRoot();
				tasks.Add(ProcessAcademics());
				tasks.Add(ProcessAdmissions());
				tasks.Add(ProcessCompletion());
				await Task.WhenAll(tasks.ToArray());
				tasks = new List<Task>();
				
				tasks.Add(ProcessCost());
				tasks.Add(ProcessEarnings());
				await Task.WhenAll(tasks.ToArray());
				tasks = new List<Task>();
				
				tasks.Add(ProcessRepayment());
				tasks.Add(ProcessSchool());
				await Task.WhenAll(tasks.ToArray());
				tasks = new List<Task>();
				
				tasks.Add(ProcessTitleIV());
				tasks.Add(ProcessStudent());
				await Task.WhenAll(tasks.ToArray());
				
				// Get the elapsed time as a TimeSpan value.
				stopWatch.Stop();
				TimeSpan ts = stopWatch.Elapsed;

			}
		}

		public async Task ProcessRoot()
		{
			var roots = manager.ParseRoot()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();

			var bulkProcess = new BulkOperationCoordinator();
			foreach(var chunk in roots.Batch(loadCount)) { 
				await bulkProcess.ProcessRoot(chunk.ToList());
			}
		}

		public async Task ProcessAcademics () {
			var Academics = manager.ParseAcademics()
			.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
			.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
			foreach (var chunk in Academics.Batch(loadCount))
			{
				await bulkProcess.ProcessAcademics(chunk.ToList());
			}
		}
		public async Task ProcessAdmissions()
	{
			var Admissions = manager.ParseAdmissions()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
				foreach (var chunk in Admissions.Batch(loadCount))
				{
					await bulkProcess.ProcessAdmissions(chunk.ToList());
			}
		}
		public async Task ProcessCompletion()
	{
			var Completions = manager.ParseCompletion()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
					foreach (var chunk in Completions.Batch(loadCount))
					{
						await bulkProcess.ProcessCompletion(chunk.ToList());
			}
		}
		public async Task ProcessCost()
	{
			var costs = manager.ParseCost()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
			foreach (var chunk in costs.Batch(loadCount))
			{
				await bulkProcess.ProcessCost(chunk.ToList());
			}
		}
		public async Task ProcessEarnings()
	{
			var earnings = manager.ParseEarnings()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
			foreach (var chunk in earnings.Batch(loadCount))
			{
				await bulkProcess.ProcessEarnings(chunk.ToList());
			}
		}
		public async Task ProcessRepayment()
	{
			 var repayments = manager.ParseRepayment()
				  .Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				  .Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
			foreach (var chunk in repayments.Batch(loadCount))
			{
				await bulkProcess.ProcessRepayment(chunk.ToList());
			}
		}
		public async Task ProcessSchool()
	{
			var schools = manager.ParseSchool()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
			foreach (var chunk in schools.Batch(loadCount))
			{
				await bulkProcess.ProcessSchool(chunk.ToList());
			}
		}
		public async Task ProcessTitleIV()
	{
			var titleIV = manager.ParseTitleIV()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
			foreach (var chunk in titleIV.Batch(loadCount))
			{
				await bulkProcess.ProcessTitleIV(chunk.ToList());
			}
		}
		public async Task ProcessStudent()
		{
			var students = manager.ParseStudent()
				.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				.Select(csv => csv.Result)
				.ToList();
			var bulkProcess = new BulkOperationCoordinator();
			foreach (var chunk in students.Batch(loadCount))
			{
				await bulkProcess.ProcessStudent(chunk.ToList());
			}
		}

		public static async Task Main(string[] args)
		{
			string err;
			var pgm = new Program();
			try { 
			pgm.Setup();
			}catch(Exception ex)
			{
			err = ex.Message	;
			}
			await pgm.Run();
			
		}
	}
}
