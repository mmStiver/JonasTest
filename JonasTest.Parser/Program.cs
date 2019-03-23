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
			string[] filePaths = Directory.GetFiles(DataFilePAth);
			files = filePaths.ToList();
			//files.Add(DataFilePAth + "MERGED2016_17_PP.csv");
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
				//.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
				//.Select(csv => csv.Result)
				.ToList();

			var root1s = roots.Where(csv => csv.IsValid) //filter out valid rows ToDo:we can handle exceptions at a later date;
						 .Select(csv => csv.Result);

			var errs = roots.Where(csv => !csv.IsValid).ToList();

			var bulkProcess = new BulkOperationCoordinator();
			foreach(var chunk in root1s.Batch(loadCount)) { 
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
				try { 
					await bulkProcess.ProcessAcademics(chunk.ToList());
				} catch (Exception ex) {
					//lOG ERROR 

					//log skipped rows
					var l1asdf = chunk.ToList();
					var ed = l1asdf;
					//throw;
					//Keep processing
				}
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
				try { 
					await bulkProcess.ProcessSchool(chunk.ToList());
				}
				catch (Exception ex)
				{
					//lOG ERROR 

					//log skipped rows
					var l1asdf = chunk.Where(s => 
							s.INSTNM.Count() >= 100
						|| s.CITY.Count() >= 20
						|| s.STABBR.Count() >= 20
						|| s.ZIP.Count() >= 20
						|| s.ACCREDAGENCY.Count() >= 20
						|| s.INSTURL.Count() >= 20
						|| s.NPCURL.Count() >= 20
						|| s.ALIAS.Count() >= 20
						|| s.ACCREDCODE.Count() >= 20
						|| s.T4APPROVALDATE.Count() >= 20)
						.ToList();
					var ed = l1asdf;
					//throw;
					//Keep processing
				}
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
			
			await pgm.Run();
			}catch(Exception ex)
			{
			err = ex.Message	;
			}
		}
	}
}
