using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using JonasTest.Core;
using JonasTest.Data.Model;
using JonasTest.Data.ConverterExtention;

using Dapper;

namespace JonasTest.Data.GateWay
{
	public class TitleIVGateway
	{

		private readonly string _connectionString ;

		public TitleIVGateway(string connectionString)
		{
			this._connectionString =  connectionString;
		}

		public async Task<Core.TitleIV> GetTitleIVAsync(int uniId )
		{
			Core.TitleIV result;

			using (var connection = new SqlConnection(_connectionString))
			{
				await connection.OpenAsync();

				var queryResult = await connection.QueryAsync<Core.TitleIV>("cscData.usp_GetTitleIV", new { UNITID = uniId }, commandType: CommandType.StoredProcedure);
				result = queryResult.FirstOrDefault();
			}
			return result;
		}

		public async Task<bool> InsertTitleIVAsync(TitleIv titleIV)
		{
			bool queryResult;

			using (var connection = new SqlConnection(_connectionString))
			{
				await connection.OpenAsync();


				var parms = titleIV.ToSQLParameterList();

				var result = await connection.QueryAsync("cscData.usp_InsertTitleIV", parms, commandType: CommandType.StoredProcedure);
				queryResult = parms.Get<int>("@return") == 1;
			}
			return queryResult;
		}
	}
}
