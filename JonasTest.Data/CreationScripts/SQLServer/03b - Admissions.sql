use ScoreCard

CREATE TABLE [cscData].[Admissions] (
UNITID	INT NOT NULL
,ADM_RATE	DECIMAL(5,2)
,ADM_RATE_ALL	DECIMAL(5,2)
,SATVR25	DECIMAL(5,2)
,SATVR75	DECIMAL(5,2)
,SATMT25	DECIMAL(5,2)
,SATMT75	DECIMAL(5,2)
,SATWR25	DECIMAL(5,2)
,SATWR75	DECIMAL(5,2)
,SATVRMID	DECIMAL(5,2)
,SATMTMID	DECIMAL(5,2)
,SATWRMID	DECIMAL(5,2)
,ACTCM25	DECIMAL(5,2)
,ACTCM75	DECIMAL(5,2)
,ACTEN25	DECIMAL(5,2)
,ACTEN75	DECIMAL(5,2)
,ACTMT25	DECIMAL(5,2)
,ACTMT75	DECIMAL(5,2)
,ACTWR25	DECIMAL(5,2)
,ACTWR75	DECIMAL(5,2)
,ACTCMMID	DECIMAL(5,2)
,ACTENMID	DECIMAL(5,2)
,ACTMTMID	DECIMAL(5,2)
,ACTWRMID	DECIMAL(5,2)
,SAT_AVG	DECIMAL(5,2)
,SAT_AVG_ALL	DECIMAL(5,2)

	,CONSTRAINT PK_Admissions_UNITID PRIMARY KEY CLUSTERED (UNITID) 
	,CONSTRAINT FK_Admissions_Root_UNITID FOREIGN KEY (UNITID) REFERENCES [cscData].[Root]( UNITID)
)