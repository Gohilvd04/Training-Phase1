-- Table variable

select * from employee


insert into department values (1, 'IT', 'Rajkot'),(2, 'Payroll', 'Us'),(3, 'HR', 'Ahmedabad'),(4, 'Admin', 'Bhavnagar');

declare @tblEmployeeCount table (dept_name varchar(20), deptId int, TotalEmployee int)
insert @tblEmployeeCount
select dept_name, dept_id  count(*) as TotalEmployees
from employee
join department
on employee.emp_id = department.dept_id
group by dept_name, dept_id


--derived table 

select dept_name, TotalEmployees
from 
	(
		select dept_name, deptId, count(*) as TotalEmployees
		from employee
		join department
		on employee.emp_id = department.dept_id
		group by dept_name, deptId
	)
as EmployeeCount


