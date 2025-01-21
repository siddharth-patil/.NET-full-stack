--lab 9
select * from employees; --where department_id = 60;
select * from departments;
--1
select last_name, salary from employees
where department_id = (select department_id from employees
                        where lower(last_name) = &&lName)
and last_name <> &lName;
undef lName;

--2
select last_name, employee_id, salary from employees
where salary > (select avg(salary) from employees);

--3
select employee_id, last_name
from employees
where last_name in (select last_name from employees
                        where last_name like '%u%');
                        
--4

select last_name, department_id, job_id
from employees
where department_id = (select department_id from locations
where location_id = 1700);

--5
select last_name, department_id, job_id
from employees
where department_id = (select department_id from locations
where location_id = &l_id);

--6
select last_name, salary,manager_id from employees
where manager_id in (select employee_id from employees
                        where last_name = 'King');
                        
--7
select department_id, last_name, job_id
from employees
where department_id = (select department_id from departments
                            where lower(department_name) = 'finance');

--8
select last_name, salary 
from employees
where salary > any(select salary from employees 
                where department_id = 60);

--9

--10
SELECT last_name
FROM (
    SELECT last_name, RANK() OVER (ORDER BY salary DESC) AS Rank
    FROM employees
) RankedSalaries
WHERE Rank = 1;
      --OR--
select last_name from employees
where salary = (select max(salary) from employees);

--11

select max(salary) from employees
where salary < (select max(salary) from employees);
  --OR
  SELECT Salary
FROM (
    SELECT Salary, RANK() OVER (ORDER BY Salary DESC) AS Rank
    FROM Employees
) RankedSalaries
WHERE Rank = 2;





















