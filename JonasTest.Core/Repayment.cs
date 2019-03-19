﻿using System;

namespace JonasTest.Core
{
	[Serializable]
	public class Repayment
	{
		public int UNITID { get; set; }
		public decimal? CDR2 						{ get; set; }
		public decimal? CDR3							{ get; set; }
		public decimal? RPY_1YR_RT					{ get; set; }
		public decimal? COMPL_RPY_1YR_RT				{ get; set; }
		public decimal? NONCOM_RPY_1YR_RT			{ get; set; }
		public decimal? LO_INC_RPY_1YR_RT			{ get; set; }
		public decimal? MD_INC_RPY_1YR_RT			{ get; set; }
		public decimal? HI_INC_RPY_1YR_RT			{ get; set; }
		public decimal? DEP_RPY_1YR_RT				{ get; set; }
		public decimal? IND_RPY_1YR_RT				{ get; set; }
		public decimal? PELL_RPY_1YR_RT				{ get; set; }
		public decimal? NOPELL_RPY_1YR_RT			{ get; set; }
		public decimal? FEMALE_RPY_1YR_RT			{ get; set; }
		public decimal? MALE_RPY_1YR_RT				{ get; set; }
		public decimal? FIRSTGEN_RPY_1YR_RT			{ get; set; }
		public decimal? NOTFIRSTGEN_RPY_1YR_RT		{ get; set; }
		public decimal? RPY_3YR_RT					{ get; set; }
		public decimal? COMPL_RPY_3YR_RT				{ get; set; }
		public decimal? NONCOM_RPY_3YR_RT			{ get; set; }
		public decimal? LO_INC_RPY_3YR_RT			{ get; set; }
		public decimal? MD_INC_RPY_3YR_RT			{ get; set; }
		public decimal? HI_INC_RPY_3YR_RT			{ get; set; }
		public decimal? DEP_RPY_3YR_RT				{ get; set; }
		public decimal? IND_RPY_3YR_RT				{ get; set; }
		public decimal? PELL_RPY_3YR_RT				{ get; set; }
		public decimal? NOPELL_RPY_3YR_RT			{ get; set; }
		public decimal? FEMALE_RPY_3YR_RT			{ get; set; }
		public decimal? MALE_RPY_3YR_RT				{ get; set; }
		public decimal? FIRSTGEN_RPY_3YR_RT			{ get; set; }
		public decimal? NOTFIRSTGEN_RPY_3YR_RT		{ get; set; }
		public decimal? RPY_5YR_RT					{ get; set; }
		public decimal? COMPL_RPY_5YR_RT				{ get; set; }
		public decimal? NONCOM_RPY_5YR_RT			{ get; set; }
		public decimal? LO_INC_RPY_5YR_RT			{ get; set; }
		public decimal? MD_INC_RPY_5YR_RT			{ get; set; }
		public decimal? HI_INC_RPY_5YR_RT			{ get; set; }
		public decimal? DEP_RPY_5YR_RT				{ get; set; }
		public decimal? IND_RPY_5YR_RT				{ get; set; }
		public decimal? PELL_RPY_5YR_RT				{ get; set; }
		public decimal? NOPELL_RPY_5YR_RT			{ get; set; }
		public decimal? FEMALE_RPY_5YR_RT			{ get; set; }
		public decimal? MALE_RPY_5YR_RT				{ get; set; }
		public decimal? FIRSTGEN_RPY_5YR_RT			{ get; set; }
		public decimal? NOTFIRSTGEN_RPY_5YR_RT		{ get; set; }
		public decimal? RPY_7YR_RT					{ get; set; }
		public decimal? COMPL_RPY_7YR_RT				{ get; set; }
		public decimal? NONCOM_RPY_7YR_RT			{ get; set; }
		public decimal? LO_INC_RPY_7YR_RT			{ get; set; }
		public decimal? MD_INC_RPY_7YR_RT			{ get; set; }
		public decimal? HI_INC_RPY_7YR_RT			{ get; set; }
		public decimal? DEP_RPY_7YR_RT				{ get; set; }
		public decimal? IND_RPY_7YR_RT				{ get; set; }
		public decimal? PELL_RPY_7YR_RT				{ get; set; }
		public decimal? NOPELL_RPY_7YR_RT			{ get; set; }
		public decimal? FEMALE_RPY_7YR_RT			{ get; set; }
		public decimal? MALE_RPY_7YR_RT				{ get; set; }
		public decimal? FIRSTGEN_RPY_7YR_RT			{ get; set; }
		public decimal? NOTFIRSTGEN_RPY_7YR_RT		{ get; set; }
		public string	REPAY_DT_MDN					{ get; set; }
		public int?		 REPAY_DT_N						{ get; set; }
		public int?		 RPY_1YR_N						{ get; set; }
		public int?		 COMPL_RPY_1YR_N					{ get; set; }
		public int?		 NONCOM_RPY_1YR_N					{ get; set; }
		public int?		 LO_INC_RPY_1YR_N					{ get; set; }
		public int?		 MD_INC_RPY_1YR_N					{ get; set; }
		public int?		 HI_INC_RPY_1YR_N					{ get; set; }
		public int?		 DEP_RPY_1YR_N					{ get; set; }
		public int?		 IND_RPY_1YR_N					{ get; set; }
		public int?		 PELL_RPY_1YR_N					{ get; set; }
		public int?		 NOPELL_RPY_1YR_N					{ get; set; }
		public int?		 FEMALE_RPY_1YR_N					{ get; set; }
		public int?		 MALE_RPY_1YR_N					{ get; set; }
		public int?		 FIRSTGEN_RPY_1YR_N				{ get; set; }
		public int?		 NOTFIRSTGEN_RPY_1YR_N			{ get; set; }
		public int?		 RPY_3YR_N						{ get; set; }
		public int?		 COMPL_RPY_3YR_N					{ get; set; }
		public int?		 NONCOM_RPY_3YR_N					{ get; set; }
		public int?		 LO_INC_RPY_3YR_N					{ get; set; }
		public int?		 MD_INC_RPY_3YR_N					{ get; set; }
		public int?		 HI_INC_RPY_3YR_N					{ get; set; }
		public int?		 DEP_RPY_3YR_N					{ get; set; }
		public int?		 IND_RPY_3YR_N					{ get; set; }
		public int?		 PELL_RPY_3YR_N					{ get; set; }
		public int?		 NOPELL_RPY_3YR_N					{ get; set; }
		public int?		 FEMALE_RPY_3YR_N					{ get; set; }
		public int?		 MALE_RPY_3YR_N					{ get; set; }
		public int?		 FIRSTGEN_RPY_3YR_N				{ get; set; }
		public int?		 NOTFIRSTGEN_RPY_3YR_N			{ get; set; }
		public int?		 RPY_5YR_N						{ get; set; }
		public int?		 COMPL_RPY_5YR_N					{ get; set; }
		public int?		 NONCOM_RPY_5YR_N					{ get; set; }
		public int?		 LO_INC_RPY_5YR_N					{ get; set; }
		public int?		 MD_INC_RPY_5YR_N					{ get; set; }
		public int?		 HI_INC_RPY_5YR_N					{ get; set; }
		public int?		 DEP_RPY_5YR_N					{ get; set; }
		public int?		 IND_RPY_5YR_N					{ get; set; }
		public int?		 PELL_RPY_5YR_N					{ get; set; }
		public int?		 NOPELL_RPY_5YR_N					{ get; set; }
		public int?		 FEMALE_RPY_5YR_N					{ get; set; }
		public int?		 MALE_RPY_5YR_N					{ get; set; }
		public int?		 FIRSTGEN_RPY_5YR_N				{ get; set; }
		public int?		 NOTFIRSTGEN_RPY_5YR_N			{ get; set; }
		public int?		 RPY_7YR_N						{ get; set; }
		public int?		 COMPL_RPY_7YR_N					{ get; set; }
		public int?		 NONCOM_RPY_7YR_N					{ get; set; }
		public int?		 LO_INC_RPY_7YR_N					{ get; set; }
		public int?		 MD_INC_RPY_7YR_N					{ get; set; }
		public int?		 HI_INC_RPY_7YR_N					{ get; set; }
		public int?		 DEP_RPY_7YR_N					{ get; set; }
		public int?		 IND_RPY_7YR_N					{ get; set; }
		public int?		 PELL_RPY_7YR_N					{ get; set; }
		public int?		 NOPELL_RPY_7YR_N					{ get; set; }
		public int?		 FEMALE_RPY_7YR_N					{ get; set; }
		public int?		 MALE_RPY_7YR_N					{ get; set; }
		public int?		 FIRSTGEN_RPY_7YR_N				{ get; set; }
		public int?		 NOTFIRSTGEN_RPY_7YR_N			{ get; set; }
		public decimal? RPY_3YR_RT_SUPP				{ get; set; }
		public decimal? LO_INC_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? MD_INC_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? HI_INC_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? COMPL_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? NONCOM_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? DEP_RPY_3YR_RT_SUPP			{ get; set; }
		public decimal? IND_RPY_3YR_RT_SUPP			{ get; set; }
		public decimal? PELL_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? NOPELL_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? FEMALE_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? MALE_RPY_3YR_RT_SUPP		{ get; set; }
		public decimal? FIRSTGEN_RPY_3YR_RT_SUPP	{ get; set; }
		public decimal? NOTFIRSTGEN_RPY_3YR_RT_SUPP	{ get; set; }
		public int?		CDR2_DENOM						{ get; set; }
		public int?		CDR3_DENOM						{ get; set; }
	}
}
