using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


using TinyCsvParser;
using TinyCsvParser.Mapping;

using JonasTest.Parser;
using JonasTest.Parser.CSVMapper;
using JonasTest.Core;

namespace JonasTest.Parser.Operation
{
	public class CSVParseManager
	{
		private string CSVInputFile;
		private List<string> CSVFileHeaders;
		private readonly CsvParserOptions csvParseOptions;

			public CSVParseManager(string csv)
			{
				this.CSVInputFile = csv;

				this.csvParseOptions= new CsvParserOptions(true, ',');
				this.CSVFileHeaders = File.ReadLines(CSVInputFile).First().Split(',').ToList();
				
			}
	
			public  ParallelQuery<CsvMappingResult<Root>> ParseRoot()
			{
				CSVRootMapper csvMapper = new CSVRootMapper(CSVFileHeaders);
				CsvParser<Root> csvParser = new CsvParser<Root>(this.csvParseOptions, csvMapper);
				
				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);
			}


			public ParallelQuery<CsvMappingResult<Academics>> ParseAcademics()
			{
				
				CSVSAcademicsMapper csvMapper = new CSVSAcademicsMapper(CSVFileHeaders);
				CsvParser<Academics> csvParser = new CsvParser<Academics>(this.csvParseOptions, csvMapper);

				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);

			}

			public ParallelQuery<CsvMappingResult<Admissions>> ParseAdmissions()
			{							
				CSVAdmissionsMapper csvMapper = new CSVAdmissionsMapper(CSVFileHeaders);
				CsvParser<Admissions> csvParser = new CsvParser<Admissions>(this.csvParseOptions, csvMapper);

				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);

		}



			public  ParallelQuery<CsvMappingResult<Completion>> ParseCompletion()
		{
				
				CSVCompletionMapper csvMapper = new CSVCompletionMapper(CSVFileHeaders);
				CsvParser<Completion> csvParser = new CsvParser<Completion>(this.csvParseOptions, csvMapper);


				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);

		}	


			public  ParallelQuery<CsvMappingResult<Cost>> ParseCost()
		{
				CSVCostMapper csvMapper = new CSVCostMapper(CSVFileHeaders);
				CsvParser<Cost> csvParser = new CsvParser<Cost>(this.csvParseOptions, csvMapper);

				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);
			}


			public  ParallelQuery<CsvMappingResult<Earnings>> ParseEarnings()
		{
				
				CSVEarningsMapper csvMapper = new CSVEarningsMapper(CSVFileHeaders);
				CsvParser<Earnings> csvParser = new CsvParser<Earnings>(this.csvParseOptions, csvMapper);


				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);
			}


			public  ParallelQuery<CsvMappingResult<Repayment>> ParseRepayment()
		{
				
				CSVRepaymentMapper csvMapper = new CSVRepaymentMapper(CSVFileHeaders);
				CsvParser<Repayment> csvParser = new CsvParser<Repayment>(this.csvParseOptions, csvMapper);


				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);
			}


			public  ParallelQuery<CsvMappingResult<School>> ParseSchool(){
				
				CSVSchoolMapper csvMapper = new CSVSchoolMapper(CSVFileHeaders);
				CsvParser<School> csvParser = new CsvParser<School>(this.csvParseOptions, csvMapper);


				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);
			}


			public  ParallelQuery<CsvMappingResult<Student>> ParseStudent() { 
				
				CSVStudentMapper csvMapper = new CSVStudentMapper(CSVFileHeaders);
				CsvParser<Student> csvParser = new CsvParser<Student>(this.csvParseOptions, csvMapper);
				
			
			return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);
			}


			public  ParallelQuery<CsvMappingResult<TitleIV>> ParseTitleIV(){
				
				CSVTitleIVMapper csvMapper = new CSVTitleIVMapper(CSVFileHeaders);
				CsvParser<TitleIV> csvParser = new CsvParser<TitleIV>(this.csvParseOptions, csvMapper);


				return csvParser
						.ReadFromFile(CSVInputFile, Encoding.UTF8);
		}
	}
}
