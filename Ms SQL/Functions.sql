--User Defined Functions- UDF 
-- Scalar functions - it returns single value

use practice
create table tblEmp(
Id int,
Name varchar(20),
DateOfBirth datetime,
Gender varchar(10),
DeptId int
primary key(Id));

insert into tblEmp values (1, 'Sam', 'Male',1,'1980-12-30 00:00:00.000'),(2, 'Pam', 'Female',2,'1982-09-01 12:02:36.260');
insert into tblEmp values (3, 'John', 'Male',1,'1985-08-22 12:03:30.370')

alter table tblEmp drop column DateOfBirth

alter table tblEmp add  DateOfBirth datetime;

select * from tblEmp

--Scalar function

create function fn_CalculateAge(@DOB date)
returns int
as
begin 
declare @Age int
set @Age= datediff(year,@DOB,getdate())
return @Age
end

select Name,DateOfBirth, dbo.fn_CalculateAge(DateOfBirth) as Age from tblEmp
where dbo.fn_CalculateAge(DateOfBirth)>40;


--Inline tavle valued function that returns the entire table and we can access the record from it like table 
create function fn_EmpByGender(@Gender varchar(10))
returns table
as
return(select * from tblEmp where Gender = @Gender);

select * from dbo.fn_EmpByGender('Male') 


--Multi-Statement table valued

create function fn_MSTVF_GetEmp()
returns @Table Table (Id int, Name varchar(20), DOB date)
as
begin 
Insert into @Table
select Id,Name, Cast(DateOfBirth as Date) from tblEmp

Return
end

--Deterministic functions
--always return same results any they are called with specific set of input values and given the same state of the databases
--all aggregate functions , sqrt, power etc

--Non Deterministic functions
-- My return different results each time they are called with specific set of input values event if the databased state that they access remains same
--getdate and current_timestamp , random..

select Floor(Rand()*100) as Random

