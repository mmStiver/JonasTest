using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using JonasTest.Data.Model;

namespace JonasTest.Data.GateWay.Interface
{
	interface ITitleIVGateway
	{
		Task<Core.TitleIV> GetTitleIVAsync(int uniId);
		Task<bool> InsertTitleIVAsync(TitleIv titleIV);
	}
}
