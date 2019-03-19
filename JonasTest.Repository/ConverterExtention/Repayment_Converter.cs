using System;
using System.Collections.Generic;

namespace JonasTest.Repository.ConverterExtention
{
    public static class Repayment_Converter
	{

		public static Core.Repayment ToTransferObject(this Data.Model.Repayment data) { 
			var core = new Core.Repayment();
			core.UNITID                         = data.Unitid                  ;
			core.CDR2							 = data.Cdr2                    ;
			core.CDR3							 = data.Cdr3					 ;
			core.RPY_1YR_RT						 = data.Rpy1yrRt				 ;
			core.COMPL_RPY_1YR_RT				 = data.ComplRpy1yrRt			 ;
			core.NONCOM_RPY_1YR_RT				 = data.NoncomRpy1yrRt			 ;
			core.LO_INC_RPY_1YR_RT				 = data.LoIncRpy1yrRt			 ;
			core.MD_INC_RPY_1YR_RT				 = data.MdIncRpy1yrRt			 ;
			core.HI_INC_RPY_1YR_RT				 = data.HiIncRpy1yrRt			 ;
			core.DEP_RPY_1YR_RT					 = data.DepRpy1yrRt			 ;
			core.IND_RPY_1YR_RT					 = data.IndRpy1yrRt			 ;
			core.PELL_RPY_1YR_RT				 = data.PellRpy1yrRt			 ;
			core.NOPELL_RPY_1YR_RT				 = data.NopellRpy1yrRt			 ;
			core.FEMALE_RPY_1YR_RT				 = data.FemaleRpy1yrRt			 ;
			core.MALE_RPY_1YR_RT				 = data.MaleRpy1yrRt			 ;
			core.FIRSTGEN_RPY_1YR_RT			 = data.FirstgenRpy1yrRt		 ;
			core.NOTFIRSTGEN_RPY_1YR_RT		 = data.NotfirstgenRpy1yrRt	 ;
			core.RPY_3YR_RT						 = data.Rpy3yrRt				 ;
			core.COMPL_RPY_3YR_RT				 = data.ComplRpy3yrRt			 ;
			core.NONCOM_RPY_3YR_RT				 = data.NoncomRpy3yrRt			 ;
			core.LO_INC_RPY_3YR_RT				 = data.LoIncRpy3yrRt			 ;
			core.MD_INC_RPY_3YR_RT				 = data.MdIncRpy3yrRt			 ;
			core.HI_INC_RPY_3YR_RT				 = data.HiIncRpy3yrRt			 ;
			core.DEP_RPY_3YR_RT					 = data.DepRpy3yrRt			 ;
			core.IND_RPY_3YR_RT					 = data.IndRpy3yrRt			 ;
			core.PELL_RPY_3YR_RT				 = data.PellRpy3yrRt			 ;
			core.NOPELL_RPY_3YR_RT				 = data.NopellRpy3yrRt			 ;
			core.FEMALE_RPY_3YR_RT				 = data.FemaleRpy3yrRt			 ;
			core.MALE_RPY_3YR_RT				 = data.MaleRpy3yrRt			 ;
			core.FIRSTGEN_RPY_3YR_RT			 = data.FirstgenRpy3yrRt		 ;
			core.NOTFIRSTGEN_RPY_3YR_RT			 = data.NotfirstgenRpy3yrRt	 ;
			core.RPY_5YR_RT						 = data.Rpy5yrRt				 ;
			core.COMPL_RPY_5YR_RT				 = data.ComplRpy5yrRt			 ;
			core.NONCOM_RPY_5YR_RT				 = data.NoncomRpy5yrRt			 ;
			core.LO_INC_RPY_5YR_RT				 = data.LoIncRpy5yrRt			 ;
			core.MD_INC_RPY_5YR_RT				 = data.MdIncRpy5yrRt			 ;
			core.HI_INC_RPY_5YR_RT				 = data.HiIncRpy5yrRt			 ;
			core.DEP_RPY_5YR_RT					 = data.DepRpy5yrRt			 ;
			core.IND_RPY_5YR_RT					 = data.IndRpy5yrRt			 ;
			core.PELL_RPY_5YR_RT				 = data.PellRpy5yrRt			 ;
			core.NOPELL_RPY_5YR_RT				 = data.NopellRpy5yrRt			 ;
			core.FEMALE_RPY_5YR_RT				 = data.FemaleRpy5yrRt			 ;
			core.MALE_RPY_5YR_RT				 = data.MaleRpy5yrRt			 ;
			core.FIRSTGEN_RPY_5YR_RT			 = data.FirstgenRpy5yrRt		 ;
			core.NOTFIRSTGEN_RPY_5YR_RT			 = data.NotfirstgenRpy5yrRt	 ;
			core.RPY_7YR_RT						 = data.Rpy7yrRt				 ;
			core.COMPL_RPY_7YR_RT				 = data.ComplRpy7yrRt			 ;
			core.NONCOM_RPY_7YR_RT				 = data.NoncomRpy7yrRt			 ;
			core.LO_INC_RPY_7YR_RT				 = data.LoIncRpy7yrRt			 ;
			core.MD_INC_RPY_7YR_RT				 = data.MdIncRpy7yrRt			 ;
			core.HI_INC_RPY_7YR_RT				 = data.HiIncRpy7yrRt			 ;
			core.DEP_RPY_7YR_RT					 = data.DepRpy7yrRt			 ;
			core.IND_RPY_7YR_RT					 = data.IndRpy7yrRt			 ;
			core.PELL_RPY_7YR_RT				 = data.PellRpy7yrRt			 ;
			core.NOPELL_RPY_7YR_RT				 = data.NopellRpy7yrRt			 ;
			core.FEMALE_RPY_7YR_RT				 = data.FemaleRpy7yrRt			 ;
			core.MALE_RPY_7YR_RT				 = data.MaleRpy7yrRt			 ;
			core.FIRSTGEN_RPY_7YR_RT			 = data.FirstgenRpy7yrRt		 ;
			core.NOTFIRSTGEN_RPY_7YR_RT			 = data.NotfirstgenRpy7yrRt	 ;
			core.REPAY_DT_MDN					 = data.RepayDtMdn				 ;
			core.REPAY_DT_N						 = data.RepayDtN				 ;
			core.RPY_1YR_N						 = data.Rpy1yrN				 ;
			core.COMPL_RPY_1YR_N				 = data.ComplRpy1yrN			 ;
			core.NONCOM_RPY_1YR_N				 = data.NoncomRpy1yrN			 ;
			core.LO_INC_RPY_1YR_N				 = data.LoIncRpy1yrN			 ;
			core.MD_INC_RPY_1YR_N				 = data.MdIncRpy1yrN			 ;
			core.HI_INC_RPY_1YR_N				 = data.HiIncRpy1yrN			 ;
			core.DEP_RPY_1YR_N					 = data.DepRpy1yrN				 ;
			core.IND_RPY_1YR_N					 = data.IndRpy1yrN				 ;
			core.PELL_RPY_1YR_N					 = data.PellRpy1yrN			 ;
			core.NOPELL_RPY_1YR_N				 = data.NopellRpy1yrN			 ;
			core.FEMALE_RPY_1YR_N				 = data.FemaleRpy1yrN			 ;
			core.MALE_RPY_1YR_N					 = data.MaleRpy1yrN			 ;
			core.FIRSTGEN_RPY_1YR_N				 = data.FirstgenRpy1yrN		 ;
			core.NOTFIRSTGEN_RPY_1YR_N			 = data.NotfirstgenRpy1yrN		 ;
			core.RPY_3YR_N						 = data.Rpy3yrN				 ;
			core.COMPL_RPY_3YR_N				 = data.ComplRpy3yrN			 ;
			core.NONCOM_RPY_3YR_N				 = data.NoncomRpy3yrN			 ;
			core.LO_INC_RPY_3YR_N				 = data.LoIncRpy3yrN			 ;
			core.MD_INC_RPY_3YR_N				 = data.MdIncRpy3yrN			 ;
			core.HI_INC_RPY_3YR_N				 = data.HiIncRpy3yrN			 ;
			core.DEP_RPY_3YR_N					 = data.DepRpy3yrN				 ;
			core.IND_RPY_3YR_N					 = data.IndRpy3yrN				 ;
			core.PELL_RPY_3YR_N					 = data.PellRpy3yrN			 ;
			core.NOPELL_RPY_3YR_N				 = data.NopellRpy3yrN			 ;
			core.FEMALE_RPY_3YR_N				 = data.FemaleRpy3yrN			 ;
			core.MALE_RPY_3YR_N					 = data.MaleRpy3yrN			 ;
			core.FIRSTGEN_RPY_3YR_N				 = data.FirstgenRpy3yrN		 ;
			core.NOTFIRSTGEN_RPY_3YR_N			 = data.NotfirstgenRpy3yrN		 ;
			core.RPY_5YR_N						 = data.Rpy5yrN				 ;
			core.COMPL_RPY_5YR_N				 = data.ComplRpy5yrN			 ;
			core.NONCOM_RPY_5YR_N				 = data.NoncomRpy5yrN			 ;
			core.LO_INC_RPY_5YR_N				 = data.LoIncRpy5yrN			 ;
			core.MD_INC_RPY_5YR_N				 = data.MdIncRpy5yrN			 ;
			core.HI_INC_RPY_5YR_N				 = data.HiIncRpy5yrN			 ;
			core.DEP_RPY_5YR_N					 = data.DepRpy5yrN				 ;
			core.IND_RPY_5YR_N					 = data.IndRpy5yrN				 ;
			core.PELL_RPY_5YR_N					 = data.PellRpy5yrN			 ;
			core.NOPELL_RPY_5YR_N				 = data.NopellRpy5yrN			 ;
			core.FEMALE_RPY_5YR_N				 = data.FemaleRpy5yrN			 ;
			core.MALE_RPY_5YR_N					 = data.MaleRpy5yrN			 ;
			core.FIRSTGEN_RPY_5YR_N				 = data.FirstgenRpy5yrN		 ;
			core.NOTFIRSTGEN_RPY_5YR_N			 = data.NotfirstgenRpy5yrN		 ;
			core.RPY_7YR_N						 = data.Rpy7yrN				 ;
			core.COMPL_RPY_7YR_N				 = data.ComplRpy7yrN			 ;
			core.NONCOM_RPY_7YR_N				 = data.NoncomRpy7yrN			 ;
			core.LO_INC_RPY_7YR_N				 = data.LoIncRpy7yrN			 ;
			core.MD_INC_RPY_7YR_N				 = data.MdIncRpy7yrN			 ;
			core.HI_INC_RPY_7YR_N				 = data.HiIncRpy7yrN			 ;
			core.DEP_RPY_7YR_N					 = data.DepRpy7yrN				 ;
			core.IND_RPY_7YR_N					 = data.IndRpy7yrN				 ;
			core.PELL_RPY_7YR_N					 = data.PellRpy7yrN			 ;
			core.NOPELL_RPY_7YR_N				 = data.NopellRpy7yrN			 ;
			core.FEMALE_RPY_7YR_N				 = data.FemaleRpy7yrN			 ;
			core.MALE_RPY_7YR_N					 = data.MaleRpy7yrN			 ;
			core.FIRSTGEN_RPY_7YR_N				 = data.FirstgenRpy7yrN		 ;
			core.NOTFIRSTGEN_RPY_7YR_N			 = data.NotfirstgenRpy7yrN		 ;
			core.RPY_3YR_RT_SUPP				 = data.Rpy3yrRtSupp			 ;
			core.LO_INC_RPY_3YR_RT_SUPP			 = data.LoIncRpy3yrRtSupp		 ;
			core.MD_INC_RPY_3YR_RT_SUPP			 = data.MdIncRpy3yrRtSupp		 ;
			core.HI_INC_RPY_3YR_RT_SUPP			 = data.HiIncRpy3yrRtSupp		 ;
			core.COMPL_RPY_3YR_RT_SUPP			 = data.ComplRpy3yrRtSupp		 ;
			core.NONCOM_RPY_3YR_RT_SUPP			 = data.NoncomRpy3yrRtSupp		 ;
			core.DEP_RPY_3YR_RT_SUPP			 = data.DepRpy3yrRtSupp		 ;
			core.IND_RPY_3YR_RT_SUPP			 = data.IndRpy3yrRtSupp		 ;
			core.PELL_RPY_3YR_RT_SUPP			 = data.PellRpy3yrRtSupp		 ;
			core.NOPELL_RPY_3YR_RT_SUPP			 = data.NopellRpy3yrRtSupp		 ;
			core.FEMALE_RPY_3YR_RT_SUPP			 = data.FemaleRpy3yrRtSupp		 ;
			core.MALE_RPY_3YR_RT_SUPP			 = data.MaleRpy3yrRtSupp		 ;
			core.FIRSTGEN_RPY_3YR_RT_SUPP		 = data.FirstgenRpy3yrRtSupp	 ;
			core.NOTFIRSTGEN_RPY_3YR_RT_SUPP		 = data.NotfirstgenRpy3yrRtSupp ;
			core.CDR2_DENOM					 = data.Cdr2Denom				 ;
			core.CDR3_DENOM					 = data.Cdr3Denom				 ;

			return core;
		}

		public static Data.Model.Repayment ToDataObject(this Core.Repayment core) {
			var data = new Data.Model.Repayment();

			data.Unitid                   = core.UNITID;
			data.Cdr2                     = core.CDR2 						;
			data.Cdr3					  = core.CDR3						;
			data.Rpy1yrRt				  = core.RPY_1YR_RT					;
			data.ComplRpy1yrRt			  = core.COMPL_RPY_1YR_RT			;
			data.NoncomRpy1yrRt			  = core.NONCOM_RPY_1YR_RT			;
			data.LoIncRpy1yrRt			  = core.LO_INC_RPY_1YR_RT			;
			data.MdIncRpy1yrRt			  = core.MD_INC_RPY_1YR_RT			;
			data.HiIncRpy1yrRt			  = core.HI_INC_RPY_1YR_RT			;
			data.DepRpy1yrRt			  = core.DEP_RPY_1YR_RT				;
			data.IndRpy1yrRt			  = core.IND_RPY_1YR_RT				;
			data.PellRpy1yrRt			  = core.PELL_RPY_1YR_RT			;	
			data.NopellRpy1yrRt			  = core.NOPELL_RPY_1YR_RT			;
			data.FemaleRpy1yrRt			  = core.FEMALE_RPY_1YR_RT			;
			data.MaleRpy1yrRt			  = core.MALE_RPY_1YR_RT			;	
			data.FirstgenRpy1yrRt		  = core.FIRSTGEN_RPY_1YR_RT		;	
			data.NotfirstgenRpy1yrRt		= core.NOTFIRSTGEN_RPY_1YR_RT		;
			data.Rpy3yrRt				  = core.RPY_3YR_RT					;
			data.ComplRpy3yrRt			  = core.COMPL_RPY_3YR_RT			;
			data.NoncomRpy3yrRt			  = core.NONCOM_RPY_3YR_RT			;
			data.LoIncRpy3yrRt			  = core.LO_INC_RPY_3YR_RT			;
			data.MdIncRpy3yrRt			  = core.MD_INC_RPY_3YR_RT			;
			data.HiIncRpy3yrRt			  = core.HI_INC_RPY_3YR_RT			;
			data.DepRpy3yrRt			  = core.DEP_RPY_3YR_RT				;
			data.IndRpy3yrRt			  = core.IND_RPY_3YR_RT				;
			data.PellRpy3yrRt			  = core.PELL_RPY_3YR_RT			;	
			data.NopellRpy3yrRt			  = core.NOPELL_RPY_3YR_RT			;
			data.FemaleRpy3yrRt			  = core.FEMALE_RPY_3YR_RT			;
			data.MaleRpy3yrRt			  = core.MALE_RPY_3YR_RT			;	
			data.FirstgenRpy3yrRt		  = core.FIRSTGEN_RPY_3YR_RT		;	
			data.NotfirstgenRpy3yrRt	  = core.NOTFIRSTGEN_RPY_3YR_RT		;
			data.Rpy5yrRt				  = core.RPY_5YR_RT					;
			data.ComplRpy5yrRt			  = core.COMPL_RPY_5YR_RT			;
			data.NoncomRpy5yrRt			  = core.NONCOM_RPY_5YR_RT			;
			data.LoIncRpy5yrRt			  = core.LO_INC_RPY_5YR_RT			;
			data.MdIncRpy5yrRt			  = core.MD_INC_RPY_5YR_RT			;
			data.HiIncRpy5yrRt			  = core.HI_INC_RPY_5YR_RT			;
			data.DepRpy5yrRt			  = core.DEP_RPY_5YR_RT				;
			data.IndRpy5yrRt			  = core.IND_RPY_5YR_RT				;
			data.PellRpy5yrRt			  = core.PELL_RPY_5YR_RT			;	
			data.NopellRpy5yrRt			  = core.NOPELL_RPY_5YR_RT			;
			data.FemaleRpy5yrRt			  = core.FEMALE_RPY_5YR_RT			;
			data.MaleRpy5yrRt			  = core.MALE_RPY_5YR_RT			;	
			data.FirstgenRpy5yrRt		  = core.FIRSTGEN_RPY_5YR_RT		;	
			data.NotfirstgenRpy5yrRt	  = core.NOTFIRSTGEN_RPY_5YR_RT		;
			data.Rpy7yrRt				  = core.RPY_7YR_RT					;
			data.ComplRpy7yrRt			  = core.COMPL_RPY_7YR_RT			;
			data.NoncomRpy7yrRt			  = core.NONCOM_RPY_7YR_RT			;
			data.LoIncRpy7yrRt			  = core.LO_INC_RPY_7YR_RT			;
			data.MdIncRpy7yrRt			  = core.MD_INC_RPY_7YR_RT			;
			data.HiIncRpy7yrRt			  = core.HI_INC_RPY_7YR_RT			;
			data.DepRpy7yrRt			  = core.DEP_RPY_7YR_RT				;
			data.IndRpy7yrRt			  = core.IND_RPY_7YR_RT				;
			data.PellRpy7yrRt			  = core.PELL_RPY_7YR_RT			;	
			data.NopellRpy7yrRt			  = core.NOPELL_RPY_7YR_RT			;
			data.FemaleRpy7yrRt			  = core.FEMALE_RPY_7YR_RT			;
			data.MaleRpy7yrRt			  = core.MALE_RPY_7YR_RT			;	
			data.FirstgenRpy7yrRt		  = core.FIRSTGEN_RPY_7YR_RT		;	
			data.NotfirstgenRpy7yrRt	  = core.NOTFIRSTGEN_RPY_7YR_RT		;
			data.RepayDtMdn				  = core.REPAY_DT_MDN				;
			data.RepayDtN				  = core. REPAY_DT_N				;	
			data.Rpy1yrN				  = core. RPY_1YR_N					;
			data.ComplRpy1yrN			  = core. COMPL_RPY_1YR_N			;
			data.NoncomRpy1yrN			  = core. NONCOM_RPY_1YR_N			;
			data.LoIncRpy1yrN			  = core. LO_INC_RPY_1YR_N			;
			data.MdIncRpy1yrN			  = core. MD_INC_RPY_1YR_N			;
			data.HiIncRpy1yrN			  = core. HI_INC_RPY_1YR_N			;
			data.DepRpy1yrN				  = core. DEP_RPY_1YR_N				;
			data.IndRpy1yrN				  = core. IND_RPY_1YR_N				;
			data.PellRpy1yrN			  = core. PELL_RPY_1YR_N			;	
			data.NopellRpy1yrN			  = core. NOPELL_RPY_1YR_N			;
			data.FemaleRpy1yrN			  = core. FEMALE_RPY_1YR_N			;
			data.MaleRpy1yrN			  = core. MALE_RPY_1YR_N			;	
			data.FirstgenRpy1yrN		  = core. FIRSTGEN_RPY_1YR_N		;	
			data.NotfirstgenRpy1yrN		  = core. NOTFIRSTGEN_RPY_1YR_N		;
			data.Rpy3yrN				  = core. RPY_3YR_N					;
			data.ComplRpy3yrN			  = core. COMPL_RPY_3YR_N			;
			data.NoncomRpy3yrN			  = core. NONCOM_RPY_3YR_N			;
			data.LoIncRpy3yrN			  = core. LO_INC_RPY_3YR_N			;
			data.MdIncRpy3yrN			  = core. MD_INC_RPY_3YR_N			;
			data.HiIncRpy3yrN			  = core. HI_INC_RPY_3YR_N			;
			data.DepRpy3yrN				  = core. DEP_RPY_3YR_N				;
			data.IndRpy3yrN				  = core. IND_RPY_3YR_N				;
			data.PellRpy3yrN			  = core. PELL_RPY_3YR_N			;	
			data.NopellRpy3yrN			  = core. NOPELL_RPY_3YR_N			;
			data.FemaleRpy3yrN			  = core. FEMALE_RPY_3YR_N			;
			data.MaleRpy3yrN			  = core. MALE_RPY_3YR_N			;	
			data.FirstgenRpy3yrN		  = core. FIRSTGEN_RPY_3YR_N		;	
			data.NotfirstgenRpy3yrN		  = core. NOTFIRSTGEN_RPY_3YR_N		;
			data.Rpy5yrN				  = core. RPY_5YR_N					;
			data.ComplRpy5yrN			  = core. COMPL_RPY_5YR_N			;
			data.NoncomRpy5yrN			  = core. NONCOM_RPY_5YR_N			;
			data.LoIncRpy5yrN			  = core. LO_INC_RPY_5YR_N			;
			data.MdIncRpy5yrN			  = core. MD_INC_RPY_5YR_N			;
			data.HiIncRpy5yrN			  = core. HI_INC_RPY_5YR_N			;
			data.DepRpy5yrN				  = core. DEP_RPY_5YR_N				;
			data.IndRpy5yrN				  = core. IND_RPY_5YR_N				;
			data.PellRpy5yrN			  = core. PELL_RPY_5YR_N			;	
			data.NopellRpy5yrN			  = core. NOPELL_RPY_5YR_N			;
			data.FemaleRpy5yrN			  = core. FEMALE_RPY_5YR_N			;
			data.MaleRpy5yrN			  = core. MALE_RPY_5YR_N			;	
			data.FirstgenRpy5yrN		  = core. FIRSTGEN_RPY_5YR_N		;	
			data.NotfirstgenRpy5yrN		  = core. NOTFIRSTGEN_RPY_5YR_N		;
			data.Rpy7yrN				  = core. RPY_7YR_N					;
			data.ComplRpy7yrN			  = core. COMPL_RPY_7YR_N			;
			data.NoncomRpy7yrN			  = core. NONCOM_RPY_7YR_N			;
			data.LoIncRpy7yrN			  = core. LO_INC_RPY_7YR_N			;
			data.MdIncRpy7yrN			  = core. MD_INC_RPY_7YR_N			;
			data.HiIncRpy7yrN			  = core. HI_INC_RPY_7YR_N			;
			data.DepRpy7yrN				  = core. DEP_RPY_7YR_N				;
			data.IndRpy7yrN				  = core. IND_RPY_7YR_N				;
			data.PellRpy7yrN			  = core. PELL_RPY_7YR_N			;	
			data.NopellRpy7yrN			  = core. NOPELL_RPY_7YR_N			;
			data.FemaleRpy7yrN			  = core. FEMALE_RPY_7YR_N			;
			data.MaleRpy7yrN			  = core. MALE_RPY_7YR_N			;	
			data.FirstgenRpy7yrN		  = core. FIRSTGEN_RPY_7YR_N		;	
			data.NotfirstgenRpy7yrN		  = core. NOTFIRSTGEN_RPY_7YR_N		;
			data.Rpy3yrRtSupp			  = core.RPY_3YR_RT_SUPP			;	
			data.LoIncRpy3yrRtSupp		  = core.LO_INC_RPY_3YR_RT_SUPP		;
			data.MdIncRpy3yrRtSupp		  = core.MD_INC_RPY_3YR_RT_SUPP		;
			data.HiIncRpy3yrRtSupp		  = core.HI_INC_RPY_3YR_RT_SUPP		;
			data.ComplRpy3yrRtSupp		  = core.COMPL_RPY_3YR_RT_SUPP		;
			data.NoncomRpy3yrRtSupp		  = core.NONCOM_RPY_3YR_RT_SUPP		;
			data.DepRpy3yrRtSupp		  = core.DEP_RPY_3YR_RT_SUPP		;	
			data.IndRpy3yrRtSupp		  = core.IND_RPY_3YR_RT_SUPP		;	
			data.PellRpy3yrRtSupp		  = core.PELL_RPY_3YR_RT_SUPP		;
			data.NopellRpy3yrRtSupp		  = core.NOPELL_RPY_3YR_RT_SUPP		;
			data.FemaleRpy3yrRtSupp		  = core.FEMALE_RPY_3YR_RT_SUPP		;
			data.MaleRpy3yrRtSupp		  = core.MALE_RPY_3YR_RT_SUPP		;
			data.FirstgenRpy3yrRtSupp	  = core.FIRSTGEN_RPY_3YR_RT_SUPP	;
			data.NotfirstgenRpy3yrRtSupp  = core.NOTFIRSTGEN_RPY_3YR_RT_SUPP;	
			data.Cdr2Denom				  = core.CDR2_DENOM				;	
			data.Cdr3Denom				  = core.CDR3_DENOM;

			return data;
		}
		 
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
    }
}
