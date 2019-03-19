using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NUnit.Framework;
using NUnit.Compatibility;

using TinyCsvParser;
using TinyCsvParser.Mapping;

using JonasTest.Parser;
using JonasTest.Parser.CSVMapper;
using JonasTest.Core;

namespace JonasTest.Test
{
	[TestFixture]
	class TinyCSVParserTest
	{ 
			private const string testCSVFile = @"CSVTestData\\mergedTest.csv";
			private const string testLargeCSVFile = @"CSVTestData\\MERGED2016_17_PP.csv";


		[Test]
		public void csvParser_RootParserOnMERGED_ReturnListOfRootInstances()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVRootMapper csvMapper = new CSVRootMapper(headers);
			CsvParser<Root> csvParser = new CsvParser<Root>(csvParserOptions, csvMapper);

			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void csvParser_AcademicsParserOnMERGED_ReturnListOfAcademicsInstances()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVSAcademicsMapper csvMapper = new CSVSAcademicsMapper(headers);
			CsvParser<Academics> csvParser = new CsvParser<Academics>(csvParserOptions, csvMapper);

			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);
			var errors = result.Where(e => !e.IsValid);
			Assert.IsTrue(result.All(x => x.IsValid));;
		}

		[Test]
		public void csvParser_AdmissionsParserOnMERGED_ReturnListOfAdmissionsInstances()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVAdmissionsMapper csvMapper = new CSVAdmissionsMapper(headers);
			CsvParser<Admissions> csvParser = new CsvParser<Admissions>(csvParserOptions, csvMapper);

			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);
			var errors = result.Where(e => !e.IsValid);
			Assert.IsTrue(result.All(x => x.IsValid));
		}

		
		[Test]
		public void csvParser_CompletionParserOnMERGED_ReturnCompletiontInstance()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVCompletionMapper csvMapper = new CSVCompletionMapper(headers);
			CsvParser<Completion> csvParser = new CsvParser<Completion>(csvParserOptions, csvMapper);


			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void csvParser_CostParserOnMERGED_ReturnListOfCostInstances()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVCostMapper csvMapper = new CSVCostMapper(headers);
			CsvParser<Cost> csvParser = new CsvParser<Cost>(csvParserOptions, csvMapper);

			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);
			var errors = result.Where( e => !e.IsValid );
			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void csvParser_EarningsParserOnMERGED_ReturnEarningstInstance()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVEarningsMapper csvMapper = new CSVEarningsMapper(headers);
			CsvParser<Earnings> csvParser = new CsvParser<Earnings>(csvParserOptions, csvMapper);


			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void csvParser_RepaymentParserOnMERGED_ReturnRepaymenttInstance()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVRepaymentMapper csvMapper = new CSVRepaymentMapper(headers);
			CsvParser<Repayment> csvParser = new CsvParser<Repayment>(csvParserOptions, csvMapper);


			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void csvParser_SchoolParserOnMERGED_ReturnSchooltInstance()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVSchoolMapper csvMapper = new CSVSchoolMapper(headers);
			CsvParser<School> csvParser = new CsvParser<School>(csvParserOptions, csvMapper);


			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void csvParser_StudentParserOnMERGED_ReturnStudenttInstance()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVStudentMapper csvMapper = new CSVStudentMapper(headers);
			CsvParser<Student> csvParser = new CsvParser<Student>(csvParserOptions, csvMapper);

			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);
			var errs = result.All(x => !x.IsValid);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void csvParser_TitleIVParserOnMERGED_ReturnTitleIVtInstance()
		{

			var headers = File.ReadLines(testLargeCSVFile).First().Split(',').ToList();
			CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
			CSVTitleIVMapper csvMapper = new CSVTitleIVMapper(headers);
			CsvParser<TitleIV> csvParser = new CsvParser<TitleIV>(csvParserOptions, csvMapper);


			var result = csvParser
					.ReadFromFile(testLargeCSVFile, Encoding.UTF8)
					.ToList();

			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}
	}
}
