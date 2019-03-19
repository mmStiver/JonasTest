using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using NUnit.Framework;
using NUnit.Compatibility;

using TinyCsvParser;

using JonasTest.Core;
using JonasTest.Parser.Operation;

namespace JonasTest.Test
{
	[TestFixture]
	class ParseManagerTest
	{ 
			private const string testLargeCSVFile = @"CSVTestData\\MERGED2016_17_PP.csv";

		[Test]
		public void ParseRoot_ReturnListOfRootInstances()
		{

			var mngr = CreateParserManager(testLargeCSVFile);

			
			var result = mngr.ParseRoot().ToList();

			Assert.AreEqual(7175,result.Count);
			Assert.IsTrue(result.All(x => x.IsValid));
			
		}

		
		[Test]
		public void PrarseAcademics_ReturnListOfAcademicsInstances()
		{

			var mngr = CreateParserManager(testLargeCSVFile);


			var result = mngr.ParseAcademics().ToList();

			Assert.AreEqual(7175,result.Count);
			
			Assert.IsTrue(result.All(x => x.IsValid));;
		}

		[Test]
		public void PrarseAdmissions_ReturnListOfAdmissionsInstances()
		{

			var mngr = CreateParserManager(testLargeCSVFile);
			var result = mngr.ParseAdmissions().ToList();


			Assert.AreEqual(7175,result.Count);
			
			Assert.IsTrue(result.All(x => x.IsValid));
		}

		
		[Test]
		public void PrarseCompletion_ReturnCompletiontInstance()
		{

			var mngr = CreateParserManager(testLargeCSVFile);
			var result = mngr.ParseCompletion().ToList();

			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void PrarseCost_ReturnListOfCostInstances()
		{

			var mngr = CreateParserManager(testLargeCSVFile);

			var result = mngr.ParseCost().ToList();

			Assert.AreEqual(7175,result.Count);
			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void PrarseEarnings_ReturnEarningstInstance()
		{

			var mngr = CreateParserManager(testLargeCSVFile);

			var result = mngr.ParseEarnings().ToList();


			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void PrarseRepayment_ReturnRepaymenttInstance()
		{

			var mngr = CreateParserManager(testLargeCSVFile);
			var result = mngr.ParseRepayment().ToList();


			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void PrarseSchool_ReturnSchooltInstance()
		{
			var mngr = CreateParserManager(testLargeCSVFile);

			var result = mngr.ParseSchool().ToList();


			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void PrarseStudent_ReturnStudenttInstance()
		{
			var mngr = CreateParserManager(testLargeCSVFile);
			var result = mngr.ParseStudent().ToList();


			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}

		[Test]
		public void PrarseTitleIV_ReturnTitleIVtInstance()
		{
			var mngr = CreateParserManager(testLargeCSVFile);
			var result = mngr.ParseTitleIV().ToList();


			Assert.AreEqual(7175,result.Count);

			Assert.IsTrue(result.All(x => x.IsValid));
		}


		public CSVParseManager CreateParserManager(string file )
		{
			return new CSVParseManager(file);
		}
	}
}
