use ScoreCard


CREATE TABLE [cscData].[Academics](
	 UNITID	INT NOT NULL

	,PCIP01	DECIMAL(5,2)
	,PCIP03	DECIMAL(5,2)
	,PCIP04	DECIMAL(5,2)
	,PCIP05	DECIMAL(5,2)
	,PCIP09	DECIMAL(5,2)
	,PCIP10	DECIMAL(5,2)
	,PCIP11	DECIMAL(5,2)
	,PCIP12	DECIMAL(5,2)
	,PCIP13	DECIMAL(5,2)
	,PCIP14	DECIMAL(5,2)
	,PCIP15	DECIMAL(5,2)
	,PCIP16	DECIMAL(5,2)
	,PCIP19	DECIMAL(5,2)
	,PCIP22	DECIMAL(5,2)
	,PCIP23	DECIMAL(5,2)
	,PCIP24	DECIMAL(5,2)
	,PCIP25	DECIMAL(5,2)
	,PCIP26	DECIMAL(5,2)
	,PCIP27	DECIMAL(5,2)
	,PCIP29	DECIMAL(5,2)
	,PCIP30	DECIMAL(5,2)
	,PCIP31	DECIMAL(5,2)
	,PCIP38	DECIMAL(5,2)
	,PCIP39	DECIMAL(5,2)
	,PCIP40	DECIMAL(5,2)
	,PCIP41	DECIMAL(5,2)
	,PCIP42	DECIMAL(5,2)
	,PCIP43	DECIMAL(5,2)
	,PCIP44	DECIMAL(5,2)
	,PCIP45	DECIMAL(5,2)
	,PCIP46	DECIMAL(5,2)
	,PCIP47	DECIMAL(5,2)
	,PCIP48	DECIMAL(5,2)
	,PCIP49	DECIMAL(5,2)
	,PCIP50	DECIMAL(5,2)
	,PCIP51	DECIMAL(5,2)
	,PCIP52	DECIMAL(5,2)
	,PCIP54	DECIMAL(5,2)
	,CIP01CERT1	INT
	,CIP01CERT2	INT
	,CIP01ASSOC	INT
	,CIP01CERT4	INT
	,CIP01BACHL	INT
	,CIP03CERT1	INT
	,CIP03CERT2	INT
	,CIP03ASSOC	INT
	,CIP03CERT4	INT
	,CIP03BACHL	INT
	,CIP04CERT1	INT
	,CIP04CERT2	INT
	,CIP04ASSOC	INT
	,CIP04CERT4	INT
	,CIP04BACHL	INT
	,CIP05CERT1	INT
	,CIP05CERT2	INT
	,CIP05ASSOC	INT
	,CIP05CERT4	INT
	,CIP05BACHL	INT
	,CIP09CERT1	INT
	,CIP09CERT2	INT
	,CIP09ASSOC	INT
	,CIP09CERT4	INT
	,CIP09BACHL	INT
	,CIP10CERT1	INT
	,CIP10CERT2	INT
	,CIP10ASSOC	INT
	,CIP10CERT4	INT
	,CIP10BACHL	INT
	,CIP11CERT1	INT
	,CIP11CERT2	INT
	,CIP11ASSOC	INT
	,CIP11CERT4	INT
	,CIP11BACHL	INT
	,CIP12CERT1	INT
	,CIP12CERT2	INT
	,CIP12ASSOC	INT
	,CIP12CERT4	INT
	,CIP12BACHL	INT
	,CIP13CERT1	INT
	,CIP13CERT2	INT
	,CIP13ASSOC	INT
	,CIP13CERT4	INT
	,CIP13BACHL	INT
	,CIP14CERT1	INT
	,CIP14CERT2	INT
	,CIP14ASSOC	INT
	,CIP14CERT4	INT
	,CIP14BACHL	INT
	,CIP15CERT1	INT
	,CIP15CERT2	INT
	,CIP15ASSOC	INT
	,CIP15CERT4	INT
	,CIP15BACHL	INT
	,CIP16CERT1	INT
	,CIP16CERT2	INT
	,CIP16ASSOC	INT
	,CIP16CERT4	INT
	,CIP16BACHL	INT
	,CIP19CERT1	INT
	,CIP19CERT2	INT
	,CIP19ASSOC	INT
	,CIP19CERT4	INT
	,CIP19BACHL	INT
	,CIP22CERT1	INT
	,CIP22CERT2	INT
	,CIP22ASSOC	INT
	,CIP22CERT4	INT
	,CIP22BACHL	INT
	,CIP23CERT1	INT
	,CIP23CERT2	INT
	,CIP23ASSOC	INT
	,CIP23CERT4	INT
	,CIP23BACHL	INT
	,CIP24CERT1	INT
	,CIP24CERT2	INT
	,CIP24ASSOC	INT
	,CIP24CERT4	INT
	,CIP24BACHL	INT
	,CIP25CERT1	INT
	,CIP25CERT2	INT
	,CIP25ASSOC	INT
	,CIP25CERT4	INT
	,CIP25BACHL	INT
	,CIP26CERT1	INT
	,CIP26CERT2	INT
	,CIP26ASSOC	INT
	,CIP26CERT4	INT
	,CIP26BACHL	INT
	,CIP27CERT1	INT
	,CIP27CERT2	INT
	,CIP27ASSOC	INT
	,CIP27CERT4	INT
	,CIP27BACHL	INT
	,CIP29CERT1	INT
	,CIP29CERT2	INT
	,CIP29ASSOC	INT
	,CIP29CERT4	INT
	,CIP29BACHL	INT
	,CIP30CERT1	INT
	,CIP30CERT2	INT
	,CIP30ASSOC	INT
	,CIP30CERT4	INT
	,CIP30BACHL	INT
	,CIP31CERT1	INT
	,CIP31CERT2	INT
	,CIP31ASSOC	INT
	,CIP31CERT4	INT
	,CIP31BACHL	INT
	,CIP38CERT1	INT
	,CIP38CERT2	INT
	,CIP38ASSOC	INT
	,CIP38CERT4	INT
	,CIP38BACHL	INT
	,CIP39CERT1	INT
	,CIP39CERT2	INT
	,CIP39ASSOC	INT
	,CIP39CERT4	INT
	,CIP39BACHL	INT
	,CIP40CERT1	INT
	,CIP40CERT2	INT
	,CIP40ASSOC	INT
	,CIP40CERT4	INT
	,CIP40BACHL	INT
	,CIP41CERT1	INT
	,CIP41CERT2	INT
	,CIP41ASSOC	INT
	,CIP41CERT4	INT
	,CIP41BACHL	INT
	,CIP42CERT1	INT
	,CIP42CERT2	INT
	,CIP42ASSOC	INT
	,CIP42CERT4	INT
	,CIP42BACHL	INT
	,CIP43CERT1	INT
	,CIP43CERT2	INT
	,CIP43ASSOC	INT
	,CIP43CERT4	INT
	,CIP43BACHL	INT
	,CIP44CERT1	INT
	,CIP44CERT2	INT
	,CIP44ASSOC	INT
	,CIP44CERT4	INT
	,CIP44BACHL	INT
	,CIP45CERT1	INT
	,CIP45CERT2	INT
	,CIP45ASSOC	INT
	,CIP45CERT4	INT
	,CIP45BACHL	INT
	,CIP46CERT1	INT
	,CIP46CERT2	INT
	,CIP46ASSOC	INT
	,CIP46CERT4	INT
	,CIP46BACHL	INT
	,CIP47CERT1	INT
	,CIP47CERT2	INT
	,CIP47ASSOC	INT
	,CIP47CERT4	INT
	,CIP47BACHL	INT
	,CIP48CERT1	INT
	,CIP48CERT2	INT
	,CIP48ASSOC	INT
	,CIP48CERT4	INT
	,CIP48BACHL	INT
	,CIP49CERT1	INT
	,CIP49CERT2	INT
	,CIP49ASSOC	INT
	,CIP49CERT4	INT
	,CIP49BACHL	INT
	,CIP50CERT1	INT
	,CIP50CERT2	INT
	,CIP50ASSOC	INT
	,CIP50CERT4	INT
	,CIP50BACHL	INT
	,CIP51CERT1	INT
	,CIP51CERT2	INT
	,CIP51ASSOC	INT
	,CIP51CERT4	INT
	,CIP51BACHL	INT
	,CIP52CERT1	INT
	,CIP52CERT2	INT
	,CIP52ASSOC	INT
	,CIP52CERT4	INT
	,CIP52BACHL	INT
	,CIP54CERT1	INT
	,CIP54CERT2	INT
	,CIP54ASSOC	INT
	,CIP54CERT4	INT
	,CIP54BACHL	INT

	,CONSTRAINT PK_Academics_UNITID PRIMARY KEY CLUSTERED (UNITID) 
	,CONSTRAINT FK_UNITID FOREIGN KEY (UNITID) REFERENCES [cscData].[Root]( UNITID)
)