-- Views in sql server
	-- A saved SQL query
	-- can be considered as Virtual table

use practice

select * from department

use happy

select * from emp

create view vwEmpByDept as 
select emp_id, emp_name, emp_salary,emp_gender,emp_dept
from emp
join department 
on emp.emp_dept = department.dept_name

-- view Provides row and column level security 
create view vwEmpByDeptIT as 
select emp_id, emp_name, emp_salary,emp_gender,emp_dept
from emp
join department 
on emp.emp_dept = department.dept_name
where dept_name = 'IT'

select * from vwEmpByDept

--Is it possible to update, insert & delete from table through view?
--Yes


--What is Indexed view? - the view gets materialized it means the view is now capable of storing data

use practice

create table ProductDetails(ProductId int , Name varchar(30), UnitPrice int)
insert into ProductDetails values (1, 'Books', 20),(2,'Pens', 14),(3, 'Pencils', 11),(4, 'Clips', 10);

create table Sales(ProductId int, QuantitySold int)
insert into Sales values (1,10),(3,23),(4,21),(2,12),
						 (1,13),(3,12),(4,13),(1,11),
						 (2, 12),(1,11)

select * from Sales
select * from ProductDetails


create view vwTotalSalesByProduct
with schemaBinding
as
select Name, sum(isnull((QuantitySold * UnitPrice), 0)) as TotalSales, 
count_big(*) as TotalTransactions
from dbo.ProductSales
join dbo.ProductDetails
on ProductDetails.ProductId = ProductSales.ProductId
group by Name

select * from vwTotalSalesByProduct

--Limitations of View
	--cannot pass parameters
	--Rules and defaults cannot be associated with view
	--it cannot be based on temporary tables