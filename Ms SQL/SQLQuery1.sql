create table emp(
emp_id int not null,
emp_name varchar(20),
emp_salary int,
emp_age int,
emp_gender varchar(20),
emp_dept varchar(20)
primary key(emp_id));

insert into emp values(1,'Vishal', 50000, 20, 'Male', 'IT');
insert into emp values(2,'Raavi', 40000, 20, 'Female', 'Nursing');
insert into emp values(3,'Ankit', 20000, 19, 'Male', 'Defence');
insert into emp values(4,'Raju', 70000, 24, 'Male', 'Defence');
insert into emp values(5,'Chirag', 30000, 23, 'Male', 'Diamond');
insert into emp values(6,'Deep', 60000, 20, 'Male', 'IT');

select * from emp; 

select emp_name,emp_salary from emp where emp_salary >= 50000;

SELECT * FROM emp;

SELECT * FROM emp WHERE emp_age BETWEEN 21 AND 30;

SELECT MIN(emp_age) AS MINIMUM FROM emp;

SELECT COUNT(emp_gender) AS NUMBER_OF_MALE_emp FROM emp WHERE emp_gender = 'MALE';

SELECT LOWER('VISHAL');

SELECT * FROM emp ORDER BY emp_age DESC;

SELECT TOP 3 * FROM emp ORDER BY emp_salary DESC;

SELECT AVG(emp_salary), emp_gender FROM emp GROUP BY emp_gender;

SELECT AVG(emp_salary) AS AVG_SALARY, emp_dept FROM emp GROUP BY emp_dept ORDER BY AVG_SALARY DESC;

SELECT AVG(emp_salary) AS AVG_SALARY, emp_dept FROM emp GROUP BY emp_dept HAVING AVG(emp_salary) > 50000;

UPDATE emp SET emp_dept = 'Medical' where emp_gender='female';

INSERT INTO emp VALUES(7,'CD',300000,30,'MALE','IT');

DELETE FROM emp WHERE emp_id = 7;

SELECT * FROM emp;

CREATE TABLE department(
dept_id INT not null,
dept_name VARCHAR(20),
dept_location VARCHAR(20),
PRIMARY KEY(dept_id)
);

INSERT INTO department VALUES(1, 'IT', 'Rajkot');
INSERT INTO department VALUES(2, 'Defence', 'Nasik');
INSERT INTO department VALUES(3, 'Diamond', 'Bhavnagar');
INSERT INTO department VALUES(4, 'Medical', 'Ahmedabad');
INSERT INTO department VALUES(5, 'Mechanical', 'Shihor');


select * from department;

SELECT * FROM emp INNER JOIN department ON emp_dept = department.dept_name; 

SELECT emp.emp_name, emp.emp_salary, department.dept_name,department.dept_location 
from department 
left join emp 
on emp.emp_dept = department.dept_name;

SELECT emp.emp_name, emp.emp_salary, department.dept_name,department.dept_location 
from department 
right join emp 
on emp.emp_dept = department.dept_name;

SELECT *
from department 
full join emp 
on emp.emp_dept = department.dept_name;





 

 



















