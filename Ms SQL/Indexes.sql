--Index - The index stores salary of each employee, in the asc order 

--Clusterd - Primary key automatically create if it doesn't have any index
	--determines the physical order of data in the table
	--table can have only one clustered index
--Non clustered - Separate index and separate data like in a book
	-- data and index are stored in different places
	-- Table can have more than one non-clustered index
--Unique - Unique index is used to enforce uniqueness of key values in the index
	-- by default, PK creates a unique clustered index
--Filtered - 
--XML - 
--FullText - 
--Spatial - 
--Columnstore - 
--Inidex with included columns - 
--Index on computed columns - 

select * from emp

create index IX_emp_salary on emp(emp_salary asc)

--Composite clustered index - takes two columns for key
create clustered index IX_emp_gender_salary on emp(emp_gender desc, emp_salary asc);

drop index emp.PK__emp__1299A8611B380227

--Non clustered index
create nonclustered index IX_emp_gender_salary on emp(emp_gender desc, emp_salary asc);

select * from emp

select emp_salary, count(emp_salary) as Total from emp group by emp_salary

 

