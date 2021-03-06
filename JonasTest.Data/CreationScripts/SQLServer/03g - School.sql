use ScoreCard


CREATE TABLE [cscData].[School](
UNITID	INT NOT NULL
,INSTNM	NVARCHAR(100)
,CITY	NVARCHAR(20)
,STABBR	NVARCHAR(20)
,ZIP	NVARCHAR(20)
,ACCREDAGENCY	NVARCHAR(20)
,INSTURL	NVARCHAR(20)
,NPCURL	NVARCHAR(20)
,SCH_DEG	INT
,HCM2	INT
,MAIN	INT
,NUMBRANCH	INT
,PREDDEG	INT
,HIGHDEG	INT
,CONTROL	INT
,ST_FIPS	INT
,REGION	INT
,LOCALE	INT
,LOCALE2	INT
,CCBASIC	INT
,CCUGPROF	INT
,CCSIZSET	INT
,HBCU	INT
,PBI	INT
,ANNHI	INT
,TRIBAL	INT
,AANAPII	INT
,HSI	INT
,NANTI	INT
,MENONLY	INT
,WOMENONLY	INT
,RELAFFIL	INT
,DISTANCEONLY	INT
,CURROPER	INT
,TUITFTE	INT
,INEXPFTE	INT
,AVGFACSAL	INT
,PFTFAC	DECIMAL(5,2)
,ALIAS	NVARCHAR(20)
,ICLEVEL	INT
,OPENADMP	INT
,ACCREDCODE	NVARCHAR(20)
,T4APPROVALDATE	NVARCHAR(20)

	,CONSTRAINT PK_School_UNITID PRIMARY KEY CLUSTERED (UNITID) 
	,CONSTRAINT FK_School_Root_UNITID FOREIGN KEY (UNITID) REFERENCES [cscData].[Root]( UNITID)
)
