using System;
using System.Collections.Generic;

namespace JonasTest.Repository.ConverterExtention
{
    public static class Cost_Converter
	{

		public static Data.Model.Cost  ToDataObject(this Core.Cost core) {
			var data = new Data.Model.Cost();
				
				data.Unitid 		= core.UNITID;
				data.Npt4Pub 		= core.NPT4_PUB;
				data.Npt4Priv 		= core.NPT4_PRIV	;
				data.Npt4Prog 		= core.NPT4_PROG	;
				data.Npt4Other 		= core.NPT4_OTHER	;
				data.Npt41Pub 		= core.NPT41_PUB	;
				data.Npt42Pub 		= core.NPT42_PUB	;
				data.Npt43Pub 		= core.NPT43_PUB	;
				data.Npt44Pub 		= core.NPT44_PUB	;
				data.Npt45Pub 		= core.NPT45_PUB	;
				data.Npt41Priv 		= core.NPT41_PRIV	;
				data.Npt42Priv 		= core.NPT42_PRIV	;
				data.Npt43Priv 		= core.NPT43_PRIV	;
				data.Npt44Priv 		= core.NPT44_PRIV	;
				data.Npt45Priv 		= core.NPT45_PRIV	;
				data.Npt41Prog 		= core.NPT41_PROG	;
				data.Npt42Prog 		= core.NPT42_PROG	;
				data.Npt43Prog 		= core.NPT43_PROG	;
				data.Npt44Prog 		= core.NPT44_PROG	;
				data.Npt45Prog 		= core.NPT45_PROG	;
				data.Npt41Other 	= core.NPT41_OTHER	;
				data.Npt42Other 	= core.NPT42_OTHER	;
				data.Npt43Other 	= core.NPT43_OTHER	;
				data.Npt44Other 	= core.NPT44_OTHER	;
				data.Npt45Other 	= core.NPT45_OTHER	;
				data.Npt4048Pub 	= core.NPT4_048_PUB	;
				data.Npt4048Priv 	= core.NPT4_048_PRIV	;
				data.Npt4048Prog 	= core.NPT4_048_PROG	;
				data.Npt4048Other 	= core.NPT4_048_OTHER	;
				data.Npt43075Pub 	= core.NPT4_3075_PUB	;
				data.Npt43075Priv 	= core.NPT4_3075_PRIV	;
				data.Npt475upPub 	= core.NPT4_75UP_PUB	;
				data.Npt475upPriv 	= core.NPT4_75UP_PRIV	;
				data.Npt43075Prog 	= core.NPT4_3075_PROG	;
				data.Npt43075Other 	= core.NPT4_3075_OTHER	;
				data.Npt475upProg 	= core.NPT4_75UP_PROG	;
				data.Npt475upOther 	= core.NPT4_75UP_OTHER	;
				data.Num4Pub 		= core.NUM4_PUB;
				data.Num4Priv 		= core.NUM4_PRIV	;
				data.Num4Prog 		= core.NUM4_PROG	;
				data.Num4Other 		= core.NUM4_OTHER	;
				data.Num41Pub 		= core.NUM41_PUB	;
				data.Num42Pub 		= core.NUM42_PUB	;
				data.Num43Pub 		= core.NUM43_PUB	;
				data.Num44Pub 		= core.NUM44_PUB	;
				data.Num45Pub 		= core.NUM45_PUB	;
				data.Num41Priv 		= core.NUM41_PRIV	;
				data.Num42Priv 		= core.NUM42_PRIV	;
				data.Num43Priv 		= core.NUM43_PRIV	;
				data.Num44Priv 		= core.NUM44_PRIV	;
				data.Num45Priv 		= core.NUM45_PRIV	;
				data.Num41Prog 		= core.NUM41_PROG	;
				data.Num42Prog 		= core.NUM42_PROG	;
				data.Num43Prog 		= core.NUM43_PROG	;
				data.Num44Prog 		= core.NUM44_PROG	;
				data.Num45Prog 		= core.NUM45_PROG	;
				data.Num41Other 	= core.NUM41_OTHER	;
				data.Num42Other 	= core.NUM42_OTHER	;
				data.Num43Other 	= core.NUM43_OTHER	;
				data.Num44Other 	= core.NUM44_OTHER	;
				data.Num45Other 	= core.NUM45_OTHER	;
				data.Costt4A 		= core.COSTT4_A		 ;
				data.Costt4P 		= core.COSTT4_P		 ;
				data.TuitionfeeIn 	= core.TUITIONFEE_IN;
				data.TuitionfeeOut 	= core.TUITIONFEE_OUT;	
				data.TuitionfeeProg = core.TUITIONFEE_PROG;
				return data;
			}

		public static Core.Cost ToTransferObject(this Data.Model.Cost data) { 
		 var core = new Core.Cost();
		
		core.UNITID = data.Unitid 			;
		core.NPT4_PUB		= data.Npt4Pub ; 
		core.NPT4_PRIV		=	data.Npt4Priv  ;
		core.NPT4_PROG		=	data.Npt4Prog  ;
		core.NPT4_OTHER		=	data.Npt4Other  ; 
		core.NPT41_PUB	    =	data.Npt41Pub  ;
		core.NPT42_PUB		=	data.Npt42Pub  ;
		core.NPT43_PUB		=	data.Npt43Pub  ;
		core.NPT44_PUB		=	data.Npt44Pub  ;
		core.NPT45_PUB		=	data.Npt45Pub  ;
		core.NPT41_PRIV		=	data.Npt41Priv  ;
		core.NPT42_PRIV		=	data.Npt42Priv  ;
		core.NPT43_PRIV		=	data.Npt43Priv  ;
		core.NPT44_PRIV		=	data.Npt44Priv  ;
		core.NPT45_PRIV		=	data.Npt45Priv  ;
		core.NPT41_PROG		=	data.Npt41Prog  ;
		core.NPT42_PROG		=	data.Npt42Prog  ;
		core.NPT43_PROG		=	data.Npt43Prog  ;
		core.NPT44_PROG		=	data.Npt44Prog  ;
		core.NPT45_PROG		=	data.Npt45Prog  ;
		core.NPT41_OTHER	=		data.Npt41Other ;
		core.NPT42_OTHER	=		data.Npt42Other ;
		core.NPT43_OTHER	=		data.Npt43Other ;
		core.NPT44_OTHER	=		data.Npt44Other ;
		core.NPT45_OTHER	=		data.Npt45Other ;
		core.NPT4_048_PUB	=	data.Npt4048Pub 	;
		core.NPT4_048_PRIV	=	data.Npt4048Priv 	;
		core.NPT4_048_PROG	=	data.Npt4048Prog 	;
		core.NPT4_048_OTHER	=	data.Npt4048Other 	;	
		core.NPT4_3075_PUB	=	data.Npt43075Pub 	;
		core.NPT4_3075_PRIV	=	data.Npt43075Priv 	;	
		core.NPT4_75UP_PUB	=	data.Npt475upPub 	;
		core.NPT4_75UP_PRIV	=	data.Npt475upPriv 	;	
		core.NPT4_3075_PRIV	=	data.Npt43075Prog 	;	
		core.NPT4_3075_OTHER	=	data.Npt43075Other 	;
		core.NPT4_75UP_PROG	=	data.Npt475upProg 	;	
		core.NPT4_75UP_OTHER	=	data.Npt475upOther 	;	
		core.NUM4_PUB		= data.Num4Pub 		;
		core.NUM4_PRIV		=	data.Num4Priv 		 ;
		core.NUM4_PROG		=	data.Num4Prog 		 ;
		core.NUM4_OTHER		=	data.Num4Other 		 ;
		core.NUM41_PUB		=	data.Num41Pub 		 ;
		core.NUM42_PUB		=	data.Num42Pub 		 ;
		core.NUM43_PUB		=	data.Num43Pub 		 ;
		core.NUM44_PUB		=	data.Num44Pub 		 ;
		core.NUM45_PUB		=	data.Num45Pub 		 ;
		core.NUM41_PRIV		=	data.Num41Priv 		 ;
		core.NUM42_PRIV		=	data.Num42Priv 		 ;
		core.NUM43_PRIV		=	data.Num43Priv 		 ;
		core.NUM44_PRIV		=	data.Num44Priv 		 ;
		core.NUM45_PRIV		=	data.Num45Priv 		 ;
		core.NUM41_PROG		=	data.Num41Prog 		 ;
		core.NUM42_PROG		=	data.Num42Prog 		 ;
		core.NUM43_PROG		=	data.Num43Prog 		 ;
		core.NUM44_PROG		=	data.Num44Prog 		 ;
		core.NUM45_PROG		=	data.Num45Prog 		 ;
		core.NUM41_OTHER	=		data.Num41Other 	;
		core.NUM42_OTHER	=		data.Num42Other 	;
		core.NUM43_OTHER	=		data.Num43Other 	;
		core.NUM44_OTHER	=		data.Num44Other 	;
		core.NUM45_OTHER	=		data.Num45Other 	;
		core.COSTT4_A		=		data.Costt4A 		;
		core.COSTT4_P		=		data.Costt4P 		;
		core.TUITIONFEE_IN	=	data.TuitionfeeIn 		;
		core.TUITIONFEE_OUT	=	data.TuitionfeeOut 		;
		core.TUITIONFEE_PROG	=	data.TuitionfeeProg;

			return core;
		}
	}
}