using System;
using System.Collections.Generic;


namespace JonasTest.Repository.ConverterExtention
{
	public static class Root_converter
	{
		public static Core.Root ToTransferObject(this Data.Model.Root data) { 
			var core = new Core.Root();
			core.UNITID = data.Unitid;
			core.OPEID = data.Opeid;
			core.OPEID6 = data.Opeid6;
			core.LATITUDE = data.Latitude;
			core.LONGITUDE = data.Longitude;
				return core;
		}
		public static Data.Model.Root ToDataObject(this Core.Root core)
		{
			var data = new Data.Model.Root();
				data.Unitid = 	core.UNITID	;
				data.Opeid  = 	core.OPEID	;
				data.Opeid6 = 	core.OPEID6	;
				data.Latitude =	core.LATITUDE;
				data.Longitude = core.LONGITUDE;
			return data;
		}
	}
}
