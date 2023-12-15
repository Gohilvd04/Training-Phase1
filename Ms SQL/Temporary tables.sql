--Temporary tables 
-- Tempory tables are very similar to the permanent tables .
--Permanent tables created in the database and remain permanently until you delete or drop the table 
--Temporary tables get created in the TempDB and are automatically deleted, when the are no longer used
-- Local temp tables 
	--created only for the connection. if connection is closed then table is dropped
	--If temp table created inside the stored procedure, it get's dropped automatically upon the completion of the stored procedure exection

--Global temp tables
	--prefix with ##
	--visible to all connections 
	-- dropped only when last connection referencing the table is closed
	--global temp table name has to be unique
--prefix with # to create temp tables

create table #PersonDetails(Id int, Name varchar(20)) 

insert into #PersonDetails values (1,'Vishal'),(2, 'Deep'), (3,'Raavi')

select * from #PersonDetails