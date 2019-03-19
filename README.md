

Development Task was to use the dataset found at : https://collegescorecard.ed.gov/data/ to create an application that parses
through the data and exposes it through an API.

Application was built on .NetCore in Visual Studio 2017. 
The library, TinyCSV was used to parse the csv data. 
EntityfRamework was used as an ORM, supported by Dapper for direct db calls.
CRUD Functionality was exposed through a ASP .Net Web API

Development Process:
CSV file is parsed into 10 objects (determined by the data categories found in the CollegeScoreCardDataDictionary from the data source). These objects made the basis for the database structure, which I left intentionally flat, as the data wasn't really relational, and little to no joins should improves query performances. 

TinyCSV required an upfront setup cost to map csv columns to objects. However, once that was done, it only took a couple minutes to parse the ~60MB files.

Entity Framework was used to rapidly prototype the application's Datalayer. Performance bottlenecks with EF will be replaced with better database functions through direct proc calls through a Gateway.

Parsed data is inserted in bulk, broken into chunks of 100 inserts. 

Each Web Api call has a single dbcontext that is created and destroyed with the controller's request. This allows each API call to act as a single transaction.

Data:
Included in JonasTest.Data is creation scripts used to setup the Sql Server database. Also included is an mdf file of the database.

MERGED files were to large to include in solution, and should be droppg into the JonasTest.Parser/Data folder to parse them.

Missing Features:

A Service layer was skipped for time considerations. 

Domain Objects became DTOs over the course of development, making an anemic api. Since the application is purely data storage/retreival and lacks business logic, I find this acceptable for now.

Error Handling was cut for time. Cutting error handling assited in initial development, since errors put a full stop to the application (making it easy to find runtime errors during development).

