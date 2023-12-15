--Triggers - Special kind of stored procedures that executes automatically in response to DML events
	/*  DML Triggers - fired automatically against DML(Insert, Update & Delete)
					 - Two types :- 
							After triggers (ForTriggers):executes automatically after the dml execution and 
							Instead of Triggers : in case of insert error it will fired the instead of insert trigger so it will not generate error e.g. - In join case
		DDL Triggers -
		Logon Triggers - 

	*/


select * from emp
--Create trigger for insert 

create table tblEmpAudit(id int identity,AuditData nvarchar(100))
create trigger tr_emp_forInsert
on emp
for insert
as 
begin 
		declare @Id int
		select * from inserted

		insert into tblEmpAudit values ('New employee with id = ' + 
											cast(@Id as varchar(5)) +
											' is added at '+
											cast(getdate() as nvarchar(20)))
end

insert into emp values (9, 'Vd', 100000, 21, 'Male', 'CE')

create trigger tr_emp_forUpdate
on emp
for update
as 
begin 
select * from deleted
select * from inserted
end

update emp set emp_name = 'Cd', emp_salary = 80000, emp_age = 23 where emp_id = 8
