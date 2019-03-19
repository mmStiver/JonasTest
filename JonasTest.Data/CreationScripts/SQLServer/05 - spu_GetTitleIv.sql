USE [ScoreCard]
GO

/****** Object:  StoredProcedure [cscData].[usp_InsertTitleIV]    Script Date: 2019-03-18 8:25:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [cscData].[usp_GetTitleIV] 
(
	@UNITID [int]
)
AS

	SET NOCOUNT ON;  

BEGIN TRY
	BEGIN TRAN
	
	SELECT
           [UNITID]
           ,[DEATH_YR2_RT]
           ,[COMP_ORIG_YR2_RT]
           ,[COMP_4YR_TRANS_YR2_RT]
           ,[COMP_2YR_TRANS_YR2_RT]
           ,[WDRAW_ORIG_YR2_RT]
           ,[WDRAW_4YR_TRANS_YR2_RT]
           ,[WDRAW_2YR_TRANS_YR2_RT]
           ,[ENRL_ORIG_YR2_RT]
           ,[ENRL_4YR_TRANS_YR2_RT]
           ,[ENRL_2YR_TRANS_YR2_RT]
           ,[UNKN_ORIG_YR2_RT]
           ,[UNKN_4YR_TRANS_YR2_RT]
           ,[UNKN_2YR_TRANS_YR2_RT]
           ,[LO_INC_DEATH_YR2_RT]
           ,[LO_INC_COMP_ORIG_YR2_RT]
           ,[LO_INC_COMP_4YR_TRANS_YR2_RT]
           ,[LO_INC_COMP_2YR_TRANS_YR2_RT]
           ,[LO_INC_WDRAW_ORIG_YR2_RT]
           ,[LO_INC_WDRAW_4YR_TRANS_YR2_RT]
           ,[LO_INC_WDRAW_2YR_TRANS_YR2_RT]
           ,[LO_INC_ENRL_ORIG_YR2_RT]
           ,[LO_INC_ENRL_4YR_TRANS_YR2_RT]
           ,[LO_INC_ENRL_2YR_TRANS_YR2_RT]
           ,[LO_INC_UNKN_ORIG_YR2_RT]
           ,[LO_INC_UNKN_4YR_TRANS_YR2_RT]
           ,[LO_INC_UNKN_2YR_TRANS_YR2_RT]
           ,[MD_INC_DEATH_YR2_RT]
           ,[MD_INC_COMP_ORIG_YR2_RT]
           ,[MD_INC_COMP_4YR_TRANS_YR2_RT]
           ,[MD_INC_COMP_2YR_TRANS_YR2_RT]
           ,[MD_INC_WDRAW_ORIG_YR2_RT]
           ,[MD_INC_WDRAW_4YR_TRANS_YR2_RT]
           ,[MD_INC_WDRAW_2YR_TRANS_YR2_RT]
           ,[MD_INC_ENRL_ORIG_YR2_RT]
           ,[MD_INC_ENRL_4YR_TRANS_YR2_RT]
           ,[MD_INC_ENRL_2YR_TRANS_YR2_RT]
           ,[MD_INC_UNKN_ORIG_YR2_RT]
           ,[MD_INC_UNKN_4YR_TRANS_YR2_RT]
           ,[MD_INC_UNKN_2YR_TRANS_YR2_RT]
           ,[HI_INC_DEATH_YR2_RT]
           ,[HI_INC_COMP_ORIG_YR2_RT]
           ,[HI_INC_COMP_4YR_TRANS_YR2_RT]
           ,[HI_INC_COMP_2YR_TRANS_YR2_RT]
           ,[HI_INC_WDRAW_ORIG_YR2_RT]
           ,[HI_INC_WDRAW_4YR_TRANS_YR2_RT]
           ,[HI_INC_WDRAW_2YR_TRANS_YR2_RT]
           ,[HI_INC_ENRL_ORIG_YR2_RT]
           ,[HI_INC_ENRL_4YR_TRANS_YR2_RT]
           ,[HI_INC_ENRL_2YR_TRANS_YR2_RT]
           ,[HI_INC_UNKN_ORIG_YR2_RT]
           ,[HI_INC_UNKN_4YR_TRANS_YR2_RT]
           ,[HI_INC_UNKN_2YR_TRANS_YR2_RT]
           ,[DEP_DEATH_YR2_RT]
           ,[DEP_COMP_ORIG_YR2_RT]
           ,[DEP_COMP_4YR_TRANS_YR2_RT]
           ,[DEP_COMP_2YR_TRANS_YR2_RT]
           ,[DEP_WDRAW_ORIG_YR2_RT]
           ,[DEP_WDRAW_4YR_TRANS_YR2_RT]
           ,[DEP_WDRAW_2YR_TRANS_YR2_RT]
           ,[DEP_ENRL_ORIG_YR2_RT]
           ,[DEP_ENRL_4YR_TRANS_YR2_RT]
           ,[DEP_ENRL_2YR_TRANS_YR2_RT]
           ,[DEP_UNKN_ORIG_YR2_RT]
           ,[DEP_UNKN_4YR_TRANS_YR2_RT]
           ,[DEP_UNKN_2YR_TRANS_YR2_RT]
           ,[IND_DEATH_YR2_RT]
           ,[IND_COMP_ORIG_YR2_RT]
           ,[IND_COMP_4YR_TRANS_YR2_RT]
           ,[IND_COMP_2YR_TRANS_YR2_RT]
           ,[IND_WDRAW_ORIG_YR2_RT]
           ,[IND_WDRAW_4YR_TRANS_YR2_RT]
           ,[IND_WDRAW_2YR_TRANS_YR2_RT]
           ,[IND_ENRL_ORIG_YR2_RT]
           ,[IND_ENRL_4YR_TRANS_YR2_RT]
           ,[IND_ENRL_2YR_TRANS_YR2_RT]
           ,[IND_UNKN_ORIG_YR2_RT]
           ,[IND_UNKN_4YR_TRANS_YR2_RT]
           ,[IND_UNKN_2YR_TRANS_YR2_RT]
           ,[FEMALE_DEATH_YR2_RT]
           ,[FEMALE_COMP_ORIG_YR2_RT]
           ,[FEMALE_COMP_4YR_TRANS_YR2_RT]
           ,[FEMALE_COMP_2YR_TRANS_YR2_RT]
           ,[FEMALE_WDRAW_ORIG_YR2_RT]
           ,[FEMALE_WDRAW_4YR_TRANS_YR2_RT]
           ,[FEMALE_WDRAW_2YR_TRANS_YR2_RT]
           ,[FEMALE_ENRL_ORIG_YR2_RT]
           ,[FEMALE_ENRL_4YR_TRANS_YR2_RT]
           ,[FEMALE_ENRL_2YR_TRANS_YR2_RT]
           ,[FEMALE_UNKN_ORIG_YR2_RT]
           ,[FEMALE_UNKN_4YR_TRANS_YR2_RT]
           ,[FEMALE_UNKN_2YR_TRANS_YR2_RT]
           ,[MALE_DEATH_YR2_RT]
           ,[MALE_COMP_ORIG_YR2_RT]
           ,[MALE_COMP_4YR_TRANS_YR2_RT]
           ,[MALE_COMP_2YR_TRANS_YR2_RT]
           ,[MALE_WDRAW_ORIG_YR2_RT]
           ,[MALE_WDRAW_4YR_TRANS_YR2_RT]
           ,[MALE_WDRAW_2YR_TRANS_YR2_RT]
           ,[MALE_ENRL_ORIG_YR2_RT]
           ,[MALE_ENRL_4YR_TRANS_YR2_RT]
           ,[MALE_ENRL_2YR_TRANS_YR2_RT]
           ,[MALE_UNKN_ORIG_YR2_RT]
           ,[MALE_UNKN_4YR_TRANS_YR2_RT]
           ,[MALE_UNKN_2YR_TRANS_YR2_RT]
           ,[PELL_DEATH_YR2_RT]
           ,[PELL_COMP_ORIG_YR2_RT]
           ,[PELL_COMP_4YR_TRANS_YR2_RT]
           ,[PELL_COMP_2YR_TRANS_YR2_RT]
           ,[PELL_WDRAW_ORIG_YR2_RT]
           ,[PELL_WDRAW_4YR_TRANS_YR2_RT]
           ,[PELL_WDRAW_2YR_TRANS_YR2_RT]
           ,[PELL_ENRL_ORIG_YR2_RT]
           ,[PELL_ENRL_4YR_TRANS_YR2_RT]
           ,[PELL_ENRL_2YR_TRANS_YR2_RT]
           ,[PELL_UNKN_ORIG_YR2_RT]
           ,[PELL_UNKN_4YR_TRANS_YR2_RT]
           ,[PELL_UNKN_2YR_TRANS_YR2_RT]
           ,[NOPELL_DEATH_YR2_RT]
           ,[NOPELL_COMP_ORIG_YR2_RT]
           ,[NOPELL_COMP_4YR_TRANS_YR2_RT]
           ,[NOPELL_COMP_2YR_TRANS_YR2_RT]
           ,[NOPELL_WDRAW_ORIG_YR2_RT]
           ,[NOPELL_WDRAW_4YR_TRANS_YR2_RT]
           ,[NOPELL_WDRAW_2YR_TRANS_YR2_RT]
           ,[NOPELL_ENRL_ORIG_YR2_RT]
           ,[NOPELL_ENRL_4YR_TRANS_YR2_RT]
           ,[NOPELL_ENRL_2YR_TRANS_YR2_RT]
           ,[NOPELL_UNKN_ORIG_YR2_RT]
           ,[NOPELL_UNKN_4YR_TRANS_YR2_RT]
           ,[NOPELL_UNKN_2YR_TRANS_YR2_RT]
           ,[LOAN_DEATH_YR2_RT]
           ,[LOAN_COMP_ORIG_YR2_RT]
           ,[LOAN_COMP_4YR_TRANS_YR2_RT]
           ,[LOAN_COMP_2YR_TRANS_YR2_RT]
           ,[LOAN_WDRAW_ORIG_YR2_RT]
           ,[LOAN_WDRAW_4YR_TRANS_YR2_RT]
           ,[LOAN_WDRAW_2YR_TRANS_YR2_RT]
           ,[LOAN_ENRL_ORIG_YR2_RT]
           ,[LOAN_ENRL_4YR_TRANS_YR2_RT]
           ,[LOAN_ENRL_2YR_TRANS_YR2_RT]
           ,[LOAN_UNKN_ORIG_YR2_RT]
           ,[LOAN_UNKN_4YR_TRANS_YR2_RT]
           ,[LOAN_UNKN_2YR_TRANS_YR2_RT]
           ,[NOLOAN_DEATH_YR2_RT]
           ,[NOLOAN_COMP_ORIG_YR2_RT]
           ,[NOLOAN_COMP_4YR_TRANS_YR2_RT]
           ,[NOLOAN_COMP_2YR_TRANS_YR2_RT]
           ,[NOLOAN_WDRAW_ORIG_YR2_RT]
           ,[NOLOAN_WDRAW_4YR_TRANS_YR2_RT]
           ,[NOLOAN_WDRAW_2YR_TRANS_YR2_RT]
           ,[NOLOAN_ENRL_ORIG_YR2_RT]
           ,[NOLOAN_ENRL_4YR_TRANS_YR2_RT]
           ,[NOLOAN_ENRL_2YR_TRANS_YR2_RT]
           ,[NOLOAN_UNKN_ORIG_YR2_RT]
           ,[NOLOAN_UNKN_4YR_TRANS_YR2_RT]
           ,[NOLOAN_UNKN_2YR_TRANS_YR2_RT]
           ,[FIRSTGEN_DEATH_YR2_RT]
           ,[FIRSTGEN_COMP_ORIG_YR2_RT]
           ,[FIRSTGEN_COMP_4YR_TRANS_YR2_RT]
           ,[FIRSTGEN_COMP_2YR_TRANS_YR2_RT]
           ,[FIRSTGEN_WDRAW_ORIG_YR2_RT]
           ,[FIRSTGEN_WDRAW_4YR_TRANS_YR2_RT]
           ,[FIRSTGEN_WDRAW_2YR_TRANS_YR2_RT]
           ,[FIRSTGEN_ENRL_ORIG_YR2_RT]
           ,[FIRSTGEN_ENRL_4YR_TRANS_YR2_RT]
           ,[FIRSTGEN_ENRL_2YR_TRANS_YR2_RT]
           ,[FIRSTGEN_UNKN_ORIG_YR2_RT]
           ,[FIRSTGEN_UNKN_4YR_TRANS_YR2_RT]
           ,[FIRSTGEN_UNKN_2YR_TRANS_YR2_RT]
           ,[NOT1STGEN_DEATH_YR2_RT]
           ,[NOT1STGEN_COMP_ORIG_YR2_RT]
           ,[NOT1STGEN_COMP_4YR_TRANS_YR2_RT]
           ,[NOT1STGEN_COMP_2YR_TRANS_YR2_RT]
           ,[NOT1STGEN_WDRAW_ORIG_YR2_RT]
           ,[NOT1STGEN_WDRAW_4YR_TRANS_YR2_RT]
           ,[NOT1STGEN_WDRAW_2YR_TRANS_YR2_RT]
           ,[NOT1STGEN_ENRL_ORIG_YR2_RT]
           ,[NOT1STGEN_ENRL_4YR_TRANS_YR2_RT]
           ,[NOT1STGEN_ENRL_2YR_TRANS_YR2_RT]
           ,[NOT1STGEN_UNKN_ORIG_YR2_RT]
           ,[NOT1STGEN_UNKN_4YR_TRANS_YR2_RT]
           ,[NOT1STGEN_UNKN_2YR_TRANS_YR2_RT]
           ,[DEATH_YR3_RT]
           ,[COMP_ORIG_YR3_RT]
           ,[COMP_4YR_TRANS_YR3_RT]
           ,[COMP_2YR_TRANS_YR3_RT]
           ,[WDRAW_ORIG_YR3_RT]
           ,[WDRAW_4YR_TRANS_YR3_RT]
           ,[WDRAW_2YR_TRANS_YR3_RT]
           ,[ENRL_ORIG_YR3_RT]
           ,[ENRL_4YR_TRANS_YR3_RT]
           ,[ENRL_2YR_TRANS_YR3_RT]
           ,[UNKN_ORIG_YR3_RT]
           ,[UNKN_4YR_TRANS_YR3_RT]
           ,[UNKN_2YR_TRANS_YR3_RT]
           ,[LO_INC_DEATH_YR3_RT]
           ,[LO_INC_COMP_ORIG_YR3_RT]
           ,[LO_INC_COMP_4YR_TRANS_YR3_RT]
           ,[LO_INC_COMP_2YR_TRANS_YR3_RT]
           ,[LO_INC_WDRAW_ORIG_YR3_RT]
           ,[LO_INC_WDRAW_4YR_TRANS_YR3_RT]
           ,[LO_INC_WDRAW_2YR_TRANS_YR3_RT]
           ,[LO_INC_ENRL_ORIG_YR3_RT]
           ,[LO_INC_ENRL_4YR_TRANS_YR3_RT]
           ,[LO_INC_ENRL_2YR_TRANS_YR3_RT]
           ,[LO_INC_UNKN_ORIG_YR3_RT]
           ,[LO_INC_UNKN_4YR_TRANS_YR3_RT]
           ,[LO_INC_UNKN_2YR_TRANS_YR3_RT]
           ,[MD_INC_DEATH_YR3_RT]
           ,[MD_INC_COMP_ORIG_YR3_RT]
           ,[MD_INC_COMP_4YR_TRANS_YR3_RT]
           ,[MD_INC_COMP_2YR_TRANS_YR3_RT]
           ,[MD_INC_WDRAW_ORIG_YR3_RT]
           ,[MD_INC_WDRAW_4YR_TRANS_YR3_RT]
           ,[MD_INC_WDRAW_2YR_TRANS_YR3_RT]
           ,[MD_INC_ENRL_ORIG_YR3_RT]
           ,[MD_INC_ENRL_4YR_TRANS_YR3_RT]
           ,[MD_INC_ENRL_2YR_TRANS_YR3_RT]
           ,[MD_INC_UNKN_ORIG_YR3_RT]
           ,[MD_INC_UNKN_4YR_TRANS_YR3_RT]
           ,[MD_INC_UNKN_2YR_TRANS_YR3_RT]
           ,[HI_INC_DEATH_YR3_RT]
           ,[HI_INC_COMP_ORIG_YR3_RT]
           ,[HI_INC_COMP_4YR_TRANS_YR3_RT]
           ,[HI_INC_COMP_2YR_TRANS_YR3_RT]
           ,[HI_INC_WDRAW_ORIG_YR3_RT]
           ,[HI_INC_WDRAW_4YR_TRANS_YR3_RT]
           ,[HI_INC_WDRAW_2YR_TRANS_YR3_RT]
           ,[HI_INC_ENRL_ORIG_YR3_RT]
           ,[HI_INC_ENRL_4YR_TRANS_YR3_RT]
           ,[HI_INC_ENRL_2YR_TRANS_YR3_RT]
           ,[HI_INC_UNKN_ORIG_YR3_RT]
           ,[HI_INC_UNKN_4YR_TRANS_YR3_RT]
           ,[HI_INC_UNKN_2YR_TRANS_YR3_RT]
           ,[DEP_DEATH_YR3_RT]
           ,[DEP_COMP_ORIG_YR3_RT]
           ,[DEP_COMP_4YR_TRANS_YR3_RT]
           ,[DEP_COMP_2YR_TRANS_YR3_RT]
           ,[DEP_WDRAW_ORIG_YR3_RT]
           ,[DEP_WDRAW_4YR_TRANS_YR3_RT]
           ,[DEP_WDRAW_2YR_TRANS_YR3_RT]
           ,[DEP_ENRL_ORIG_YR3_RT]
           ,[DEP_ENRL_4YR_TRANS_YR3_RT]
           ,[DEP_ENRL_2YR_TRANS_YR3_RT]
           ,[DEP_UNKN_ORIG_YR3_RT]
           ,[DEP_UNKN_4YR_TRANS_YR3_RT]
           ,[DEP_UNKN_2YR_TRANS_YR3_RT]
           ,[IND_DEATH_YR3_RT]
           ,[IND_COMP_ORIG_YR3_RT]
           ,[IND_COMP_4YR_TRANS_YR3_RT]
           ,[IND_COMP_2YR_TRANS_YR3_RT]
           ,[IND_WDRAW_ORIG_YR3_RT]
           ,[IND_WDRAW_4YR_TRANS_YR3_RT]
           ,[IND_WDRAW_2YR_TRANS_YR3_RT]
           ,[IND_ENRL_ORIG_YR3_RT]
           ,[IND_ENRL_4YR_TRANS_YR3_RT]
           ,[IND_ENRL_2YR_TRANS_YR3_RT]
           ,[IND_UNKN_ORIG_YR3_RT]
           ,[IND_UNKN_4YR_TRANS_YR3_RT]
           ,[IND_UNKN_2YR_TRANS_YR3_RT]
           ,[FEMALE_DEATH_YR3_RT]
           ,[FEMALE_COMP_ORIG_YR3_RT]
           ,[FEMALE_COMP_4YR_TRANS_YR3_RT]
           ,[FEMALE_COMP_2YR_TRANS_YR3_RT]
           ,[FEMALE_WDRAW_ORIG_YR3_RT]
           ,[FEMALE_WDRAW_4YR_TRANS_YR3_RT]
           ,[FEMALE_WDRAW_2YR_TRANS_YR3_RT]
           ,[FEMALE_ENRL_ORIG_YR3_RT]
           ,[FEMALE_ENRL_4YR_TRANS_YR3_RT]
           ,[FEMALE_ENRL_2YR_TRANS_YR3_RT]
           ,[FEMALE_UNKN_ORIG_YR3_RT]
           ,[FEMALE_UNKN_4YR_TRANS_YR3_RT]
           ,[FEMALE_UNKN_2YR_TRANS_YR3_RT]
           ,[MALE_DEATH_YR3_RT]
           ,[MALE_COMP_ORIG_YR3_RT]
           ,[MALE_COMP_4YR_TRANS_YR3_RT]
           ,[MALE_COMP_2YR_TRANS_YR3_RT]
           ,[MALE_WDRAW_ORIG_YR3_RT]
           ,[MALE_WDRAW_4YR_TRANS_YR3_RT]
           ,[MALE_WDRAW_2YR_TRANS_YR3_RT]
           ,[MALE_ENRL_ORIG_YR3_RT]
           ,[MALE_ENRL_4YR_TRANS_YR3_RT]
           ,[MALE_ENRL_2YR_TRANS_YR3_RT]
           ,[MALE_UNKN_ORIG_YR3_RT]
           ,[MALE_UNKN_4YR_TRANS_YR3_RT]
           ,[MALE_UNKN_2YR_TRANS_YR3_RT]
           ,[PELL_DEATH_YR3_RT]
           ,[PELL_COMP_ORIG_YR3_RT]
           ,[PELL_COMP_4YR_TRANS_YR3_RT]
           ,[PELL_COMP_2YR_TRANS_YR3_RT]
           ,[PELL_WDRAW_ORIG_YR3_RT]
           ,[PELL_WDRAW_4YR_TRANS_YR3_RT]
           ,[PELL_WDRAW_2YR_TRANS_YR3_RT]
           ,[PELL_ENRL_ORIG_YR3_RT]
           ,[PELL_ENRL_4YR_TRANS_YR3_RT]
           ,[PELL_ENRL_2YR_TRANS_YR3_RT]
           ,[PELL_UNKN_ORIG_YR3_RT]
           ,[PELL_UNKN_4YR_TRANS_YR3_RT]
           ,[PELL_UNKN_2YR_TRANS_YR3_RT]
           ,[NOPELL_DEATH_YR3_RT]
           ,[NOPELL_COMP_ORIG_YR3_RT]
           ,[NOPELL_COMP_4YR_TRANS_YR3_RT]
           ,[NOPELL_COMP_2YR_TRANS_YR3_RT]
           ,[NOPELL_WDRAW_ORIG_YR3_RT]
           ,[NOPELL_WDRAW_4YR_TRANS_YR3_RT]
           ,[NOPELL_WDRAW_2YR_TRANS_YR3_RT]
           ,[NOPELL_ENRL_ORIG_YR3_RT]
           ,[NOPELL_ENRL_4YR_TRANS_YR3_RT]
           ,[NOPELL_ENRL_2YR_TRANS_YR3_RT]
           ,[NOPELL_UNKN_ORIG_YR3_RT]
           ,[NOPELL_UNKN_4YR_TRANS_YR3_RT]
           ,[NOPELL_UNKN_2YR_TRANS_YR3_RT]
           ,[LOAN_DEATH_YR3_RT]
           ,[LOAN_COMP_ORIG_YR3_RT]
           ,[LOAN_COMP_4YR_TRANS_YR3_RT]
           ,[LOAN_COMP_2YR_TRANS_YR3_RT]
           ,[LOAN_WDRAW_ORIG_YR3_RT]
           ,[LOAN_WDRAW_4YR_TRANS_YR3_RT]
           ,[LOAN_WDRAW_2YR_TRANS_YR3_RT]
           ,[LOAN_ENRL_ORIG_YR3_RT]
           ,[LOAN_ENRL_4YR_TRANS_YR3_RT]
           ,[LOAN_ENRL_2YR_TRANS_YR3_RT]
           ,[LOAN_UNKN_ORIG_YR3_RT]
           ,[LOAN_UNKN_4YR_TRANS_YR3_RT]
           ,[LOAN_UNKN_2YR_TRANS_YR3_RT]
           ,[NOLOAN_DEATH_YR3_RT]
           ,[NOLOAN_COMP_ORIG_YR3_RT]
           ,[NOLOAN_COMP_4YR_TRANS_YR3_RT]
           ,[NOLOAN_COMP_2YR_TRANS_YR3_RT]
           ,[NOLOAN_WDRAW_ORIG_YR3_RT]
           ,[NOLOAN_WDRAW_4YR_TRANS_YR3_RT]
           ,[NOLOAN_WDRAW_2YR_TRANS_YR3_RT]
           ,[NOLOAN_ENRL_ORIG_YR3_RT]
           ,[NOLOAN_ENRL_4YR_TRANS_YR3_RT]
           ,[NOLOAN_ENRL_2YR_TRANS_YR3_RT]
           ,[NOLOAN_UNKN_ORIG_YR3_RT]
           ,[NOLOAN_UNKN_4YR_TRANS_YR3_RT]
           ,[NOLOAN_UNKN_2YR_TRANS_YR3_RT]
           ,[FIRSTGEN_DEATH_YR3_RT]
           ,[FIRSTGEN_COMP_ORIG_YR3_RT]
           ,[FIRSTGEN_COMP_4YR_TRANS_YR3_RT]
           ,[FIRSTGEN_COMP_2YR_TRANS_YR3_RT]
           ,[FIRSTGEN_WDRAW_ORIG_YR3_RT]
           ,[FIRSTGEN_WDRAW_4YR_TRANS_YR3_RT]
           ,[FIRSTGEN_WDRAW_2YR_TRANS_YR3_RT]
           ,[FIRSTGEN_ENRL_ORIG_YR3_RT]
           ,[FIRSTGEN_ENRL_4YR_TRANS_YR3_RT]
           ,[FIRSTGEN_ENRL_2YR_TRANS_YR3_RT]
           ,[FIRSTGEN_UNKN_ORIG_YR3_RT]
           ,[FIRSTGEN_UNKN_4YR_TRANS_YR3_RT]
           ,[FIRSTGEN_UNKN_2YR_TRANS_YR3_RT]
           ,[NOT1STGEN_DEATH_YR3_RT]
           ,[NOT1STGEN_COMP_ORIG_YR3_RT]
           ,[NOT1STGEN_COMP_4YR_TRANS_YR3_RT]
           ,[NOT1STGEN_COMP_2YR_TRANS_YR3_RT]
           ,[NOT1STGEN_WDRAW_ORIG_YR3_RT]
           ,[NOT1STGEN_WDRAW_4YR_TRANS_YR3_RT]
           ,[NOT1STGEN_WDRAW_2YR_TRANS_YR3_RT]
           ,[NOT1STGEN_ENRL_ORIG_YR3_RT]
           ,[NOT1STGEN_ENRL_4YR_TRANS_YR3_RT]
           ,[NOT1STGEN_ENRL_2YR_TRANS_YR3_RT]
           ,[NOT1STGEN_UNKN_ORIG_YR3_RT]
           ,[NOT1STGEN_UNKN_4YR_TRANS_YR3_RT]
           ,[NOT1STGEN_UNKN_2YR_TRANS_YR3_RT]
           ,[DEATH_YR4_RT]
           ,[COMP_ORIG_YR4_RT]
           ,[COMP_4YR_TRANS_YR4_RT]
           ,[COMP_2YR_TRANS_YR4_RT]
           ,[WDRAW_ORIG_YR4_RT]
           ,[WDRAW_4YR_TRANS_YR4_RT]
           ,[WDRAW_2YR_TRANS_YR4_RT]
           ,[ENRL_ORIG_YR4_RT]
           ,[ENRL_4YR_TRANS_YR4_RT]
           ,[ENRL_2YR_TRANS_YR4_RT]
           ,[UNKN_ORIG_YR4_RT]
           ,[UNKN_4YR_TRANS_YR4_RT]
           ,[UNKN_2YR_TRANS_YR4_RT]
           ,[LO_INC_DEATH_YR4_RT]
           ,[LO_INC_COMP_ORIG_YR4_RT]
           ,[LO_INC_COMP_4YR_TRANS_YR4_RT]
           ,[LO_INC_COMP_2YR_TRANS_YR4_RT]
           ,[LO_INC_WDRAW_ORIG_YR4_RT]
           ,[LO_INC_WDRAW_4YR_TRANS_YR4_RT]
           ,[LO_INC_WDRAW_2YR_TRANS_YR4_RT]
           ,[LO_INC_ENRL_ORIG_YR4_RT]
           ,[LO_INC_ENRL_4YR_TRANS_YR4_RT]
           ,[LO_INC_ENRL_2YR_TRANS_YR4_RT]
           ,[LO_INC_UNKN_ORIG_YR4_RT]
           ,[LO_INC_UNKN_4YR_TRANS_YR4_RT]
           ,[LO_INC_UNKN_2YR_TRANS_YR4_RT]
           ,[MD_INC_DEATH_YR4_RT]
           ,[MD_INC_COMP_ORIG_YR4_RT]
           ,[MD_INC_COMP_4YR_TRANS_YR4_RT]
           ,[MD_INC_COMP_2YR_TRANS_YR4_RT]
           ,[MD_INC_WDRAW_ORIG_YR4_RT]
           ,[MD_INC_WDRAW_4YR_TRANS_YR4_RT]
           ,[MD_INC_WDRAW_2YR_TRANS_YR4_RT]
           ,[MD_INC_ENRL_ORIG_YR4_RT]
           ,[MD_INC_ENRL_4YR_TRANS_YR4_RT]
           ,[MD_INC_ENRL_2YR_TRANS_YR4_RT]
           ,[MD_INC_UNKN_ORIG_YR4_RT]
           ,[MD_INC_UNKN_4YR_TRANS_YR4_RT]
           ,[MD_INC_UNKN_2YR_TRANS_YR4_RT]
           ,[HI_INC_DEATH_YR4_RT]
           ,[HI_INC_COMP_ORIG_YR4_RT]
           ,[HI_INC_COMP_4YR_TRANS_YR4_RT]
           ,[HI_INC_COMP_2YR_TRANS_YR4_RT]
           ,[HI_INC_WDRAW_ORIG_YR4_RT]
           ,[HI_INC_WDRAW_4YR_TRANS_YR4_RT]
           ,[HI_INC_WDRAW_2YR_TRANS_YR4_RT]
           ,[HI_INC_ENRL_ORIG_YR4_RT]
           ,[HI_INC_ENRL_4YR_TRANS_YR4_RT]
           ,[HI_INC_ENRL_2YR_TRANS_YR4_RT]
           ,[HI_INC_UNKN_ORIG_YR4_RT]
           ,[HI_INC_UNKN_4YR_TRANS_YR4_RT]
           ,[HI_INC_UNKN_2YR_TRANS_YR4_RT]
           ,[DEP_DEATH_YR4_RT]
           ,[DEP_COMP_ORIG_YR4_RT]
           ,[DEP_COMP_4YR_TRANS_YR4_RT]
           ,[DEP_COMP_2YR_TRANS_YR4_RT]
           ,[DEP_WDRAW_ORIG_YR4_RT]
           ,[DEP_WDRAW_4YR_TRANS_YR4_RT]
           ,[DEP_WDRAW_2YR_TRANS_YR4_RT]
           ,[DEP_ENRL_ORIG_YR4_RT]
           ,[DEP_ENRL_4YR_TRANS_YR4_RT]
           ,[DEP_ENRL_2YR_TRANS_YR4_RT]
           ,[DEP_UNKN_ORIG_YR4_RT]
           ,[DEP_UNKN_4YR_TRANS_YR4_RT]
           ,[DEP_UNKN_2YR_TRANS_YR4_RT]
           ,[IND_DEATH_YR4_RT]
           ,[IND_COMP_ORIG_YR4_RT]
           ,[IND_COMP_4YR_TRANS_YR4_RT]
           ,[IND_COMP_2YR_TRANS_YR4_RT]
           ,[IND_WDRAW_ORIG_YR4_RT]
           ,[IND_WDRAW_4YR_TRANS_YR4_RT]
           ,[IND_WDRAW_2YR_TRANS_YR4_RT]
           ,[IND_ENRL_ORIG_YR4_RT]
           ,[IND_ENRL_4YR_TRANS_YR4_RT]
           ,[IND_ENRL_2YR_TRANS_YR4_RT]
           ,[IND_UNKN_ORIG_YR4_RT]
           ,[IND_UNKN_4YR_TRANS_YR4_RT]
           ,[IND_UNKN_2YR_TRANS_YR4_RT]
           ,[FEMALE_DEATH_YR4_RT]
           ,[FEMALE_COMP_ORIG_YR4_RT]
           ,[FEMALE_COMP_4YR_TRANS_YR4_RT]
           ,[FEMALE_COMP_2YR_TRANS_YR4_RT]
           ,[FEMALE_WDRAW_ORIG_YR4_RT]
           ,[FEMALE_WDRAW_4YR_TRANS_YR4_RT]
           ,[FEMALE_WDRAW_2YR_TRANS_YR4_RT]
           ,[FEMALE_ENRL_ORIG_YR4_RT]
           ,[FEMALE_ENRL_4YR_TRANS_YR4_RT]
           ,[FEMALE_ENRL_2YR_TRANS_YR4_RT]
           ,[FEMALE_UNKN_ORIG_YR4_RT]
           ,[FEMALE_UNKN_4YR_TRANS_YR4_RT]
           ,[FEMALE_UNKN_2YR_TRANS_YR4_RT]
           ,[MALE_DEATH_YR4_RT]
           ,[MALE_COMP_ORIG_YR4_RT]
           ,[MALE_COMP_4YR_TRANS_YR4_RT]
           ,[MALE_COMP_2YR_TRANS_YR4_RT]
           ,[MALE_WDRAW_ORIG_YR4_RT]
           ,[MALE_WDRAW_4YR_TRANS_YR4_RT]
           ,[MALE_WDRAW_2YR_TRANS_YR4_RT]
           ,[MALE_ENRL_ORIG_YR4_RT]
           ,[MALE_ENRL_4YR_TRANS_YR4_RT]
           ,[MALE_ENRL_2YR_TRANS_YR4_RT]
           ,[MALE_UNKN_ORIG_YR4_RT]
           ,[MALE_UNKN_4YR_TRANS_YR4_RT]
           ,[MALE_UNKN_2YR_TRANS_YR4_RT]
           ,[PELL_DEATH_YR4_RT]
           ,[PELL_COMP_ORIG_YR4_RT]
           ,[PELL_COMP_4YR_TRANS_YR4_RT]
           ,[PELL_COMP_2YR_TRANS_YR4_RT]
           ,[PELL_WDRAW_ORIG_YR4_RT]
           ,[PELL_WDRAW_4YR_TRANS_YR4_RT]
           ,[PELL_WDRAW_2YR_TRANS_YR4_RT]
           ,[PELL_ENRL_ORIG_YR4_RT]
           ,[PELL_ENRL_4YR_TRANS_YR4_RT]
           ,[PELL_ENRL_2YR_TRANS_YR4_RT]
           ,[PELL_UNKN_ORIG_YR4_RT]
           ,[PELL_UNKN_4YR_TRANS_YR4_RT]
           ,[PELL_UNKN_2YR_TRANS_YR4_RT]
           ,[NOPELL_DEATH_YR4_RT]
           ,[NOPELL_COMP_ORIG_YR4_RT]
           ,[NOPELL_COMP_4YR_TRANS_YR4_RT]
           ,[NOPELL_COMP_2YR_TRANS_YR4_RT]
           ,[NOPELL_WDRAW_ORIG_YR4_RT]
           ,[NOPELL_WDRAW_4YR_TRANS_YR4_RT]
           ,[NOPELL_WDRAW_2YR_TRANS_YR4_RT]
           ,[NOPELL_ENRL_ORIG_YR4_RT]
           ,[NOPELL_ENRL_4YR_TRANS_YR4_RT]
           ,[NOPELL_ENRL_2YR_TRANS_YR4_RT]
           ,[NOPELL_UNKN_ORIG_YR4_RT]
           ,[NOPELL_UNKN_4YR_TRANS_YR4_RT]
           ,[NOPELL_UNKN_2YR_TRANS_YR4_RT]
           ,[LOAN_DEATH_YR4_RT]
           ,[LOAN_COMP_ORIG_YR4_RT]
           ,[LOAN_COMP_4YR_TRANS_YR4_RT]
           ,[LOAN_COMP_2YR_TRANS_YR4_RT]
           ,[LOAN_WDRAW_ORIG_YR4_RT]
           ,[LOAN_WDRAW_4YR_TRANS_YR4_RT]
           ,[LOAN_WDRAW_2YR_TRANS_YR4_RT]
           ,[LOAN_ENRL_ORIG_YR4_RT]
           ,[LOAN_ENRL_4YR_TRANS_YR4_RT]
           ,[LOAN_ENRL_2YR_TRANS_YR4_RT]
           ,[LOAN_UNKN_ORIG_YR4_RT]
           ,[LOAN_UNKN_4YR_TRANS_YR4_RT]
           ,[LOAN_UNKN_2YR_TRANS_YR4_RT]
           ,[NOLOAN_DEATH_YR4_RT]
           ,[NOLOAN_COMP_ORIG_YR4_RT]
           ,[NOLOAN_COMP_4YR_TRANS_YR4_RT]
           ,[NOLOAN_COMP_2YR_TRANS_YR4_RT]
           ,[NOLOAN_WDRAW_ORIG_YR4_RT]
           ,[NOLOAN_WDRAW_4YR_TRANS_YR4_RT]
           ,[NOLOAN_WDRAW_2YR_TRANS_YR4_RT]
           ,[NOLOAN_ENRL_ORIG_YR4_RT]
           ,[NOLOAN_ENRL_4YR_TRANS_YR4_RT]
           ,[NOLOAN_ENRL_2YR_TRANS_YR4_RT]
           ,[NOLOAN_UNKN_ORIG_YR4_RT]
           ,[NOLOAN_UNKN_4YR_TRANS_YR4_RT]
           ,[NOLOAN_UNKN_2YR_TRANS_YR4_RT]
           ,[FIRSTGEN_DEATH_YR4_RT]
           ,[FIRSTGEN_COMP_ORIG_YR4_RT]
           ,[FIRSTGEN_COMP_4YR_TRANS_YR4_RT]
           ,[FIRSTGEN_COMP_2YR_TRANS_YR4_RT]
           ,[FIRSTGEN_WDRAW_ORIG_YR4_RT]
           ,[FIRSTGEN_WDRAW_4YR_TRANS_YR4_RT]
           ,[FIRSTGEN_WDRAW_2YR_TRANS_YR4_RT]
           ,[FIRSTGEN_ENRL_ORIG_YR4_RT]
           ,[FIRSTGEN_ENRL_4YR_TRANS_YR4_RT]
           ,[FIRSTGEN_ENRL_2YR_TRANS_YR4_RT]
           ,[FIRSTGEN_UNKN_ORIG_YR4_RT]
           ,[FIRSTGEN_UNKN_4YR_TRANS_YR4_RT]
           ,[FIRSTGEN_UNKN_2YR_TRANS_YR4_RT]
           ,[NOT1STGEN_DEATH_YR4_RT]
           ,[NOT1STGEN_COMP_ORIG_YR4_RT]
           ,[NOT1STGEN_COMP_4YR_TRANS_YR4_RT]
           ,[NOT1STGEN_COMP_2YR_TRANS_YR4_RT]
           ,[NOT1STGEN_WDRAW_ORIG_YR4_RT]
           ,[NOT1STGEN_WDRAW_4YR_TRANS_YR4_RT]
           ,[NOT1STGEN_WDRAW_2YR_TRANS_YR4_RT]
           ,[NOT1STGEN_ENRL_ORIG_YR4_RT]
           ,[NOT1STGEN_ENRL_4YR_TRANS_YR4_RT]
           ,[NOT1STGEN_ENRL_2YR_TRANS_YR4_RT]
           ,[NOT1STGEN_UNKN_ORIG_YR4_RT]
           ,[NOT1STGEN_UNKN_4YR_TRANS_YR4_RT]
           ,[NOT1STGEN_UNKN_2YR_TRANS_YR4_RT]
           ,[DEATH_YR6_RT]
           ,[COMP_ORIG_YR6_RT]
           ,[COMP_4YR_TRANS_YR6_RT]
           ,[COMP_2YR_TRANS_YR6_RT]
           ,[WDRAW_ORIG_YR6_RT]
           ,[WDRAW_4YR_TRANS_YR6_RT]
           ,[WDRAW_2YR_TRANS_YR6_RT]
           ,[ENRL_ORIG_YR6_RT]
           ,[ENRL_4YR_TRANS_YR6_RT]
           ,[ENRL_2YR_TRANS_YR6_RT]
           ,[UNKN_ORIG_YR6_RT]
           ,[UNKN_4YR_TRANS_YR6_RT]
           ,[UNKN_2YR_TRANS_YR6_RT]
           ,[LO_INC_DEATH_YR6_RT]
           ,[LO_INC_COMP_ORIG_YR6_RT]
           ,[LO_INC_COMP_4YR_TRANS_YR6_RT]
           ,[LO_INC_COMP_2YR_TRANS_YR6_RT]
           ,[LO_INC_WDRAW_ORIG_YR6_RT]
           ,[LO_INC_WDRAW_4YR_TRANS_YR6_RT]
           ,[LO_INC_WDRAW_2YR_TRANS_YR6_RT]
           ,[LO_INC_ENRL_ORIG_YR6_RT]
           ,[LO_INC_ENRL_4YR_TRANS_YR6_RT]
           ,[LO_INC_ENRL_2YR_TRANS_YR6_RT]
           ,[LO_INC_UNKN_ORIG_YR6_RT]
           ,[LO_INC_UNKN_4YR_TRANS_YR6_RT]
           ,[LO_INC_UNKN_2YR_TRANS_YR6_RT]
           ,[MD_INC_DEATH_YR6_RT]
           ,[MD_INC_COMP_ORIG_YR6_RT]
           ,[MD_INC_COMP_4YR_TRANS_YR6_RT]
           ,[MD_INC_COMP_2YR_TRANS_YR6_RT]
           ,[MD_INC_WDRAW_ORIG_YR6_RT]
           ,[MD_INC_WDRAW_4YR_TRANS_YR6_RT]
           ,[MD_INC_WDRAW_2YR_TRANS_YR6_RT]
           ,[MD_INC_ENRL_ORIG_YR6_RT]
           ,[MD_INC_ENRL_4YR_TRANS_YR6_RT]
           ,[MD_INC_ENRL_2YR_TRANS_YR6_RT]
           ,[MD_INC_UNKN_ORIG_YR6_RT]
           ,[MD_INC_UNKN_4YR_TRANS_YR6_RT]
           ,[MD_INC_UNKN_2YR_TRANS_YR6_RT]
           ,[HI_INC_DEATH_YR6_RT]
           ,[HI_INC_COMP_ORIG_YR6_RT]
           ,[HI_INC_COMP_4YR_TRANS_YR6_RT]
           ,[HI_INC_COMP_2YR_TRANS_YR6_RT]
           ,[HI_INC_WDRAW_ORIG_YR6_RT]
           ,[HI_INC_WDRAW_4YR_TRANS_YR6_RT]
           ,[HI_INC_WDRAW_2YR_TRANS_YR6_RT]
           ,[HI_INC_ENRL_ORIG_YR6_RT]
           ,[HI_INC_ENRL_4YR_TRANS_YR6_RT]
           ,[HI_INC_ENRL_2YR_TRANS_YR6_RT]
           ,[HI_INC_UNKN_ORIG_YR6_RT]
           ,[HI_INC_UNKN_4YR_TRANS_YR6_RT]
           ,[HI_INC_UNKN_2YR_TRANS_YR6_RT]
           ,[DEP_DEATH_YR6_RT]
           ,[DEP_COMP_ORIG_YR6_RT]
           ,[DEP_COMP_4YR_TRANS_YR6_RT]
           ,[DEP_COMP_2YR_TRANS_YR6_RT]
           ,[DEP_WDRAW_ORIG_YR6_RT]
           ,[DEP_WDRAW_4YR_TRANS_YR6_RT]
           ,[DEP_WDRAW_2YR_TRANS_YR6_RT]
           ,[DEP_ENRL_ORIG_YR6_RT]
           ,[DEP_ENRL_4YR_TRANS_YR6_RT]
           ,[DEP_ENRL_2YR_TRANS_YR6_RT]
           ,[DEP_UNKN_ORIG_YR6_RT]
           ,[DEP_UNKN_4YR_TRANS_YR6_RT]
           ,[DEP_UNKN_2YR_TRANS_YR6_RT]
           ,[IND_DEATH_YR6_RT]
           ,[IND_COMP_ORIG_YR6_RT]
           ,[IND_COMP_4YR_TRANS_YR6_RT]
           ,[IND_COMP_2YR_TRANS_YR6_RT]
           ,[IND_WDRAW_ORIG_YR6_RT]
           ,[IND_WDRAW_4YR_TRANS_YR6_RT]
           ,[IND_WDRAW_2YR_TRANS_YR6_RT]
           ,[IND_ENRL_ORIG_YR6_RT]
           ,[IND_ENRL_4YR_TRANS_YR6_RT]
           ,[IND_ENRL_2YR_TRANS_YR6_RT]
           ,[IND_UNKN_ORIG_YR6_RT]
           ,[IND_UNKN_4YR_TRANS_YR6_RT]
           ,[IND_UNKN_2YR_TRANS_YR6_RT]
           ,[FEMALE_DEATH_YR6_RT]
           ,[FEMALE_COMP_ORIG_YR6_RT]
           ,[FEMALE_COMP_4YR_TRANS_YR6_RT]
           ,[FEMALE_COMP_2YR_TRANS_YR6_RT]
           ,[FEMALE_WDRAW_ORIG_YR6_RT]
           ,[FEMALE_WDRAW_4YR_TRANS_YR6_RT]
           ,[FEMALE_WDRAW_2YR_TRANS_YR6_RT]
           ,[FEMALE_ENRL_ORIG_YR6_RT]
           ,[FEMALE_ENRL_4YR_TRANS_YR6_RT]
           ,[FEMALE_ENRL_2YR_TRANS_YR6_RT]
           ,[FEMALE_UNKN_ORIG_YR6_RT]
           ,[FEMALE_UNKN_4YR_TRANS_YR6_RT]
           ,[FEMALE_UNKN_2YR_TRANS_YR6_RT]
           ,[MALE_DEATH_YR6_RT]
           ,[MALE_COMP_ORIG_YR6_RT]
           ,[MALE_COMP_4YR_TRANS_YR6_RT]
           ,[MALE_COMP_2YR_TRANS_YR6_RT]
           ,[MALE_WDRAW_ORIG_YR6_RT]
           ,[MALE_WDRAW_4YR_TRANS_YR6_RT]
           ,[MALE_WDRAW_2YR_TRANS_YR6_RT]
           ,[MALE_ENRL_ORIG_YR6_RT]
           ,[MALE_ENRL_4YR_TRANS_YR6_RT]
           ,[MALE_ENRL_2YR_TRANS_YR6_RT]
           ,[MALE_UNKN_ORIG_YR6_RT]
           ,[MALE_UNKN_4YR_TRANS_YR6_RT]
           ,[MALE_UNKN_2YR_TRANS_YR6_RT]
           ,[PELL_DEATH_YR6_RT]
           ,[PELL_COMP_ORIG_YR6_RT]
           ,[PELL_COMP_4YR_TRANS_YR6_RT]
           ,[PELL_COMP_2YR_TRANS_YR6_RT]
           ,[PELL_WDRAW_ORIG_YR6_RT]
           ,[PELL_WDRAW_4YR_TRANS_YR6_RT]
           ,[PELL_WDRAW_2YR_TRANS_YR6_RT]
           ,[PELL_ENRL_ORIG_YR6_RT]
           ,[PELL_ENRL_4YR_TRANS_YR6_RT]
           ,[PELL_ENRL_2YR_TRANS_YR6_RT]
           ,[PELL_UNKN_ORIG_YR6_RT]
           ,[PELL_UNKN_4YR_TRANS_YR6_RT]
           ,[PELL_UNKN_2YR_TRANS_YR6_RT]
           ,[NOPELL_DEATH_YR6_RT]
           ,[NOPELL_COMP_ORIG_YR6_RT]
           ,[NOPELL_COMP_4YR_TRANS_YR6_RT]
           ,[NOPELL_COMP_2YR_TRANS_YR6_RT]
           ,[NOPELL_WDRAW_ORIG_YR6_RT]
           ,[NOPELL_WDRAW_4YR_TRANS_YR6_RT]
           ,[NOPELL_WDRAW_2YR_TRANS_YR6_RT]
           ,[NOPELL_ENRL_ORIG_YR6_RT]
           ,[NOPELL_ENRL_4YR_TRANS_YR6_RT]
           ,[NOPELL_ENRL_2YR_TRANS_YR6_RT]
           ,[NOPELL_UNKN_ORIG_YR6_RT]
           ,[NOPELL_UNKN_4YR_TRANS_YR6_RT]
           ,[NOPELL_UNKN_2YR_TRANS_YR6_RT]
           ,[LOAN_DEATH_YR6_RT]
           ,[LOAN_COMP_ORIG_YR6_RT]
           ,[LOAN_COMP_4YR_TRANS_YR6_RT]
           ,[LOAN_COMP_2YR_TRANS_YR6_RT]
           ,[LOAN_WDRAW_ORIG_YR6_RT]
           ,[LOAN_WDRAW_4YR_TRANS_YR6_RT]
           ,[LOAN_WDRAW_2YR_TRANS_YR6_RT]
           ,[LOAN_ENRL_ORIG_YR6_RT]
           ,[LOAN_ENRL_4YR_TRANS_YR6_RT]
           ,[LOAN_ENRL_2YR_TRANS_YR6_RT]
           ,[LOAN_UNKN_ORIG_YR6_RT]
           ,[LOAN_UNKN_4YR_TRANS_YR6_RT]
           ,[LOAN_UNKN_2YR_TRANS_YR6_RT]
           ,[NOLOAN_DEATH_YR6_RT]
           ,[NOLOAN_COMP_ORIG_YR6_RT]
           ,[NOLOAN_COMP_4YR_TRANS_YR6_RT]
           ,[NOLOAN_COMP_2YR_TRANS_YR6_RT]
           ,[NOLOAN_WDRAW_ORIG_YR6_RT]
           ,[NOLOAN_WDRAW_4YR_TRANS_YR6_RT]
           ,[NOLOAN_WDRAW_2YR_TRANS_YR6_RT]
           ,[NOLOAN_ENRL_ORIG_YR6_RT]
           ,[NOLOAN_ENRL_4YR_TRANS_YR6_RT]
           ,[NOLOAN_ENRL_2YR_TRANS_YR6_RT]
           ,[NOLOAN_UNKN_ORIG_YR6_RT]
           ,[NOLOAN_UNKN_4YR_TRANS_YR6_RT]
           ,[NOLOAN_UNKN_2YR_TRANS_YR6_RT]
           ,[FIRSTGEN_DEATH_YR6_RT]
           ,[FIRSTGEN_COMP_ORIG_YR6_RT]
           ,[FIRSTGEN_COMP_4YR_TRANS_YR6_RT]
           ,[FIRSTGEN_COMP_2YR_TRANS_YR6_RT]
           ,[FIRSTGEN_WDRAW_ORIG_YR6_RT]
           ,[FIRSTGEN_WDRAW_4YR_TRANS_YR6_RT]
           ,[FIRSTGEN_WDRAW_2YR_TRANS_YR6_RT]
           ,[FIRSTGEN_ENRL_ORIG_YR6_RT]
           ,[FIRSTGEN_ENRL_4YR_TRANS_YR6_RT]
           ,[FIRSTGEN_ENRL_2YR_TRANS_YR6_RT]
           ,[FIRSTGEN_UNKN_ORIG_YR6_RT]
           ,[FIRSTGEN_UNKN_4YR_TRANS_YR6_RT]
           ,[FIRSTGEN_UNKN_2YR_TRANS_YR6_RT]
           ,[NOT1STGEN_DEATH_YR6_RT]
           ,[NOT1STGEN_COMP_ORIG_YR6_RT]
           ,[NOT1STGEN_COMP_4YR_TRANS_YR6_RT]
           ,[NOT1STGEN_COMP_2YR_TRANS_YR6_RT]
           ,[NOT1STGEN_WDRAW_ORIG_YR6_RT]
           ,[NOT1STGEN_WDRAW_4YR_TRANS_YR6_RT]
           ,[NOT1STGEN_WDRAW_2YR_TRANS_YR6_RT]
           ,[NOT1STGEN_ENRL_ORIG_YR6_RT]
           ,[NOT1STGEN_ENRL_4YR_TRANS_YR6_RT]
           ,[NOT1STGEN_ENRL_2YR_TRANS_YR6_RT]
           ,[NOT1STGEN_UNKN_ORIG_YR6_RT]
           ,[NOT1STGEN_UNKN_4YR_TRANS_YR6_RT]
           ,[NOT1STGEN_UNKN_2YR_TRANS_YR6_RT]
           ,[DEATH_YR8_RT]
           ,[COMP_ORIG_YR8_RT]
           ,[COMP_4YR_TRANS_YR8_RT]
           ,[COMP_2YR_TRANS_YR8_RT]
           ,[WDRAW_ORIG_YR8_RT]
           ,[WDRAW_4YR_TRANS_YR8_RT]
           ,[WDRAW_2YR_TRANS_YR8_RT]
           ,[ENRL_ORIG_YR8_RT]
           ,[ENRL_4YR_TRANS_YR8_RT]
           ,[ENRL_2YR_TRANS_YR8_RT]
           ,[UNKN_ORIG_YR8_RT]
           ,[UNKN_4YR_TRANS_YR8_RT]
           ,[UNKN_2YR_TRANS_YR8_RT]
           ,[LO_INC_DEATH_YR8_RT]
           ,[LO_INC_COMP_ORIG_YR8_RT]
           ,[LO_INC_COMP_4YR_TRANS_YR8_RT]
           ,[LO_INC_COMP_2YR_TRANS_YR8_RT]
           ,[LO_INC_WDRAW_ORIG_YR8_RT]
           ,[LO_INC_WDRAW_4YR_TRANS_YR8_RT]
           ,[LO_INC_WDRAW_2YR_TRANS_YR8_RT]
           ,[LO_INC_ENRL_ORIG_YR8_RT]
           ,[LO_INC_ENRL_4YR_TRANS_YR8_RT]
           ,[LO_INC_ENRL_2YR_TRANS_YR8_RT]
           ,[LO_INC_UNKN_ORIG_YR8_RT]
           ,[LO_INC_UNKN_4YR_TRANS_YR8_RT]
           ,[LO_INC_UNKN_2YR_TRANS_YR8_RT]
           ,[MD_INC_DEATH_YR8_RT]
           ,[MD_INC_COMP_ORIG_YR8_RT]
           ,[MD_INC_COMP_4YR_TRANS_YR8_RT]
           ,[MD_INC_COMP_2YR_TRANS_YR8_RT]
           ,[MD_INC_WDRAW_ORIG_YR8_RT]
           ,[MD_INC_WDRAW_4YR_TRANS_YR8_RT]
           ,[MD_INC_WDRAW_2YR_TRANS_YR8_RT]
           ,[MD_INC_ENRL_ORIG_YR8_RT]
           ,[MD_INC_ENRL_4YR_TRANS_YR8_RT]
           ,[MD_INC_ENRL_2YR_TRANS_YR8_RT]
           ,[MD_INC_UNKN_ORIG_YR8_RT]
           ,[MD_INC_UNKN_4YR_TRANS_YR8_RT]
           ,[MD_INC_UNKN_2YR_TRANS_YR8_RT]
           ,[HI_INC_DEATH_YR8_RT]
           ,[HI_INC_COMP_ORIG_YR8_RT]
           ,[HI_INC_COMP_4YR_TRANS_YR8_RT]
           ,[HI_INC_COMP_2YR_TRANS_YR8_RT]
           ,[HI_INC_WDRAW_ORIG_YR8_RT]
           ,[HI_INC_WDRAW_4YR_TRANS_YR8_RT]
           ,[HI_INC_WDRAW_2YR_TRANS_YR8_RT]
           ,[HI_INC_ENRL_ORIG_YR8_RT]
           ,[HI_INC_ENRL_4YR_TRANS_YR8_RT]
           ,[HI_INC_ENRL_2YR_TRANS_YR8_RT]
           ,[HI_INC_UNKN_ORIG_YR8_RT]
           ,[HI_INC_UNKN_4YR_TRANS_YR8_RT]
           ,[HI_INC_UNKN_2YR_TRANS_YR8_RT]
           ,[DEP_DEATH_YR8_RT]
           ,[DEP_COMP_ORIG_YR8_RT]
           ,[DEP_COMP_4YR_TRANS_YR8_RT]
           ,[DEP_COMP_2YR_TRANS_YR8_RT]
           ,[DEP_WDRAW_ORIG_YR8_RT]
           ,[DEP_WDRAW_4YR_TRANS_YR8_RT]
           ,[DEP_WDRAW_2YR_TRANS_YR8_RT]
           ,[DEP_ENRL_ORIG_YR8_RT]
           ,[DEP_ENRL_4YR_TRANS_YR8_RT]
           ,[DEP_ENRL_2YR_TRANS_YR8_RT]
           ,[DEP_UNKN_ORIG_YR8_RT]
           ,[DEP_UNKN_4YR_TRANS_YR8_RT]
           ,[DEP_UNKN_2YR_TRANS_YR8_RT]
           ,[IND_DEATH_YR8_RT]
           ,[IND_COMP_ORIG_YR8_RT]
           ,[IND_COMP_4YR_TRANS_YR8_RT]
           ,[IND_COMP_2YR_TRANS_YR8_RT]
           ,[IND_WDRAW_ORIG_YR8_RT]
           ,[IND_WDRAW_4YR_TRANS_YR8_RT]
           ,[IND_WDRAW_2YR_TRANS_YR8_RT]
           ,[IND_ENRL_ORIG_YR8_RT]
           ,[IND_ENRL_4YR_TRANS_YR8_RT]
           ,[IND_ENRL_2YR_TRANS_YR8_RT]
           ,[IND_UNKN_ORIG_YR8_RT]
           ,[IND_UNKN_4YR_TRANS_YR8_RT]
           ,[IND_UNKN_2YR_TRANS_YR8_RT]
           ,[FEMALE_DEATH_YR8_RT]
           ,[FEMALE_COMP_ORIG_YR8_RT]
           ,[FEMALE_COMP_4YR_TRANS_YR8_RT]
           ,[FEMALE_COMP_2YR_TRANS_YR8_RT]
           ,[FEMALE_WDRAW_ORIG_YR8_RT]
           ,[FEMALE_WDRAW_4YR_TRANS_YR8_RT]
           ,[FEMALE_WDRAW_2YR_TRANS_YR8_RT]
           ,[FEMALE_ENRL_ORIG_YR8_RT]
           ,[FEMALE_ENRL_4YR_TRANS_YR8_RT]
           ,[FEMALE_ENRL_2YR_TRANS_YR8_RT]
           ,[FEMALE_UNKN_ORIG_YR8_RT]
           ,[FEMALE_UNKN_4YR_TRANS_YR8_RT]
           ,[FEMALE_UNKN_2YR_TRANS_YR8_RT]
           ,[MALE_DEATH_YR8_RT]
           ,[MALE_COMP_ORIG_YR8_RT]
           ,[MALE_COMP_4YR_TRANS_YR8_RT]
           ,[MALE_COMP_2YR_TRANS_YR8_RT]
           ,[MALE_WDRAW_ORIG_YR8_RT]
           ,[MALE_WDRAW_4YR_TRANS_YR8_RT]
           ,[MALE_WDRAW_2YR_TRANS_YR8_RT]
           ,[MALE_ENRL_ORIG_YR8_RT]
           ,[MALE_ENRL_4YR_TRANS_YR8_RT]
           ,[MALE_ENRL_2YR_TRANS_YR8_RT]
           ,[MALE_UNKN_ORIG_YR8_RT]
           ,[MALE_UNKN_4YR_TRANS_YR8_RT]
           ,[MALE_UNKN_2YR_TRANS_YR8_RT]
           ,[PELL_DEATH_YR8_RT]
           ,[PELL_COMP_ORIG_YR8_RT]
           ,[PELL_COMP_4YR_TRANS_YR8_RT]
           ,[PELL_COMP_2YR_TRANS_YR8_RT]
           ,[PELL_WDRAW_ORIG_YR8_RT]
           ,[PELL_WDRAW_4YR_TRANS_YR8_RT]
           ,[PELL_WDRAW_2YR_TRANS_YR8_RT]
           ,[PELL_ENRL_ORIG_YR8_RT]
           ,[PELL_ENRL_4YR_TRANS_YR8_RT]
           ,[PELL_ENRL_2YR_TRANS_YR8_RT]
           ,[PELL_UNKN_ORIG_YR8_RT]
           ,[PELL_UNKN_4YR_TRANS_YR8_RT]
           ,[PELL_UNKN_2YR_TRANS_YR8_RT]
           ,[NOPELL_DEATH_YR8_RT]
           ,[NOPELL_COMP_ORIG_YR8_RT]
           ,[NOPELL_COMP_4YR_TRANS_YR8_RT]
           ,[NOPELL_COMP_2YR_TRANS_YR8_RT]
           ,[NOPELL_WDRAW_ORIG_YR8_RT]
           ,[NOPELL_WDRAW_4YR_TRANS_YR8_RT]
           ,[NOPELL_WDRAW_2YR_TRANS_YR8_RT]
           ,[NOPELL_ENRL_ORIG_YR8_RT]
           ,[NOPELL_ENRL_4YR_TRANS_YR8_RT]
           ,[NOPELL_ENRL_2YR_TRANS_YR8_RT]
           ,[NOPELL_UNKN_ORIG_YR8_RT]
           ,[NOPELL_UNKN_4YR_TRANS_YR8_RT]
           ,[NOPELL_UNKN_2YR_TRANS_YR8_RT]
           ,[LOAN_DEATH_YR8_RT]
           ,[LOAN_COMP_ORIG_YR8_RT]
           ,[LOAN_COMP_4YR_TRANS_YR8_RT]
           ,[LOAN_COMP_2YR_TRANS_YR8_RT]
           ,[LOAN_WDRAW_ORIG_YR8_RT]
           ,[LOAN_WDRAW_4YR_TRANS_YR8_RT]
           ,[LOAN_WDRAW_2YR_TRANS_YR8_RT]
           ,[LOAN_ENRL_ORIG_YR8_RT]
           ,[LOAN_ENRL_4YR_TRANS_YR8_RT]
           ,[LOAN_ENRL_2YR_TRANS_YR8_RT]
           ,[LOAN_UNKN_ORIG_YR8_RT]
           ,[LOAN_UNKN_4YR_TRANS_YR8_RT]
           ,[LOAN_UNKN_2YR_TRANS_YR8_RT]
           ,[NOLOAN_DEATH_YR8_RT]
           ,[NOLOAN_COMP_ORIG_YR8_RT]
           ,[NOLOAN_COMP_4YR_TRANS_YR8_RT]
           ,[NOLOAN_COMP_2YR_TRANS_YR8_RT]
           ,[NOLOAN_WDRAW_ORIG_YR8_RT]
           ,[NOLOAN_WDRAW_4YR_TRANS_YR8_RT]
           ,[NOLOAN_WDRAW_2YR_TRANS_YR8_RT]
           ,[NOLOAN_ENRL_ORIG_YR8_RT]
           ,[NOLOAN_ENRL_4YR_TRANS_YR8_RT]
           ,[NOLOAN_ENRL_2YR_TRANS_YR8_RT]
           ,[NOLOAN_UNKN_ORIG_YR8_RT]
           ,[NOLOAN_UNKN_4YR_TRANS_YR8_RT]
           ,[NOLOAN_UNKN_2YR_TRANS_YR8_RT]
           ,[FIRSTGEN_DEATH_YR8_RT]
           ,[FIRSTGEN_COMP_ORIG_YR8_RT]
           ,[FIRSTGEN_COMP_4YR_TRANS_YR8_RT]
           ,[FIRSTGEN_COMP_2YR_TRANS_YR8_RT]
           ,[FIRSTGEN_WDRAW_ORIG_YR8_RT]
           ,[FIRSTGEN_WDRAW_4YR_TRANS_YR8_RT]
           ,[FIRSTGEN_WDRAW_2YR_TRANS_YR8_RT]
           ,[FIRSTGEN_ENRL_ORIG_YR8_RT]
           ,[FIRSTGEN_ENRL_4YR_TRANS_YR8_RT]
           ,[FIRSTGEN_ENRL_2YR_TRANS_YR8_RT]
           ,[FIRSTGEN_UNKN_ORIG_YR8_RT]
           ,[FIRSTGEN_UNKN_4YR_TRANS_YR8_RT]
           ,[FIRSTGEN_UNKN_2YR_TRANS_YR8_RT]
           ,[NOT1STGEN_DEATH_YR8_RT]
           ,[NOT1STGEN_COMP_ORIG_YR8_RT]
           ,[NOT1STGEN_COMP_4YR_TRANS_YR8_RT]
           ,[NOT1STGEN_COMP_2YR_TRANS_YR8_RT]
           ,[NOT1STGEN_WDRAW_ORIG_YR8_RT]
           ,[NOT1STGEN_WDRAW_4YR_TRANS_YR8_RT]
           ,[NOT1STGEN_WDRAW_2YR_TRANS_YR8_RT]
           ,[NOT1STGEN_ENRL_ORIG_YR8_RT]
           ,[NOT1STGEN_ENRL_4YR_TRANS_YR8_RT]
           ,[NOT1STGEN_ENRL_2YR_TRANS_YR8_RT]
           ,[NOT1STGEN_UNKN_ORIG_YR8_RT]
           ,[NOT1STGEN_UNKN_4YR_TRANS_YR8_RT]
           ,[NOT1STGEN_UNKN_2YR_TRANS_YR8_RT]

			FROM [cscData].[TitleIV]
			WHERE UNITID = @UNITID


	COMMIT TRAN

	RETURN 1
END TRY
BEGIN CATCH
	ROLLBACK TRAN

	
	INSERT INTO [dbo].[ApplicationLog]
           ([Logged]
           ,[Message]
           ,[Callsite]
           ,[Exception])
     VALUES
           (
           GETUTCDATE()
           ,ERROR_LINE() + ' ' +ERROR_MESSAGE()
           ,ERROR_PROCEDURE()
           ,ERROR_NUMBER() 
		   )
	RETURN -1
END CATCH


GO

