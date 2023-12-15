create table employee1(
EmployeeID int,
EmployeeName nvarchar(20),
ManagerID int
primary key(EmployeeID));


insert into employee1 
values (1, 'Mike', 3),
	   (2, 'Rob', 1),
	   (3, 'Todd', null),
	   (4, 'Ben', 1),
	   (5, 'Sam', 1);


select E.EmployeeName as Employee, isnull(M.EmployeeName,'No Manager') as Manager
from employee1 E
left join employee1 M
on E.ManagerID = M.EmployeeID;

select E.EmployeeName as Employee, coalesce(M.EmployeeName,'No Manager') as Manager
from employee1 E
left join employee1 M
on E.ManagerID = M.EmployeeID;

select E.EmployeeName as Employee, 
(case 
	when M.EmployeeName is null 
	then 'No Manager' 
	else M.EmployeeName 
end) as Manager
from employee1 E
left join employee1 M
on E.ManagerID = M.EmployeeID;


create table IndianCustomer
( 
Id int not null,
CName varchar(20),
Email varchar(50),
primary key(Id)
);

insert into IndianCustomer values (1, 'Vishal','vd@vd.com'),
								  (2, 'Raavi','rv@rv.com');

create table UsCustomer (
Id int  not null, 
CName varchar(20),
Email varchar(50),
primary key(Id));

insert into UsCustomer values(1, 'Chirag','cd@cd.com'),(2,'Ankit', 'aa@aa.com');

insert into UsCustomer values (3, 'Raavi','rv@rv.com');

select * from IndianCustomer union all select * from UsCustomer;


select * from employee;

alter table employee drop column emp_salary;

EXEC sp_rename 'employee.emp_dept','dept_id', int;

select * from employee;

alter table employee drop column emp_age;

alter table employee add dept_id int;

insert into employee values (1,'Sam','Male', 1),
							(2,'Ram','Male', 1),
							(3,'Sara','Female', 3),
							(4,'Todd','male', 2),
							(5,'John','male', 3),
							(6,'Sana','male', 2),
							(7,'James','male', 1),
							(8,'Rob','male', 2),
							(9,'Steve','male', 1),
							(10,'Pam','male', 2);

select * from department;

update employee set emp_gender = 'Female' where emp_id in (3,6,10);

-- Create stored procedure
--CREATE PROCEDURE spGetEmployees 
--AS 
--BEGIN
	select emp_name, emp_gender from employee;
--END

-- call stored procedure
--spGetEmployees; 

-- Create & Alter procedure 
alter proc spGetEmpWithGenderAndDept
@Gender varchar(20),
@DepartmentId int
as
begin
select emp_name, emp_gender from employee where dept_id = @DepartmentId and emp_gender = @Gender order by emp_name;
end

spGetEmpWithGenderAndDept @DepartmentId=1, @Gender = 'male'

--Create procedure with Output
create proc spGetCountByGender
@Gender varchar(20),
@Count int output
as
begin
select @Count = count(emp_id) from employee where emp_gender = @Gender;
end

--Call store procedure with output
declare @Total int
exec spGetCountByGender 'male', @Total output
print @Total

--Created procedure with return 
create proc spGetCountByGenderUsingReturn
@Gender varchar(20)
as
begin
 return (select count(emp_id) from employee where emp_gender = @Gender);
end

declare @Total int
exec @Total = spGetCountByGenderUsingReturn 'male'
print @Total

-- Create procedure that takes input as Id and return the name of employee
-- It will generate an error because return keyword only return integers 
-- use return keyword only for returning integer values

create proc spGetEmployeeUsingId
@Id int
as
begin
return (select emp_name from employee where emp_id = @Id);
end

declare @Name varchar(20)
execute @Name = spGetEmployeeUsingId 1
print 'Name of the Employee ' + @Name

select * from employee;

-- Can use output or out keyword to return any values it can return string and integer also

