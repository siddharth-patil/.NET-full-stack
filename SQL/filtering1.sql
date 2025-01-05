select last_name, salary
from employees
where salary > 12000;
----------------------------
select * from employees 
where employee_id=175;
----------------------------
select last_name, salary
from employees
where salary between 5000 and 12000;
----------not between
select last_name, salary
from employees
where salary not between 5000 and 12000;
---------------------------------------------------------------------
--Lab 4.6
select last_name surname, salary as sal, department_id as dep_id
from employees
where salary between 5000 and 12000 
--and department_id=10 or department_id = 20;
and department_id in(10, 20);
----------------------------------------------------------------------
select last_name, hire_date
from employees 
where hire_date between '01-jan-2006' and '31-dec-2006';
----------------------------------------------------------------------
select last_name, job_id
from employees 
where manager_id <> null;
--where manager_id != null;
----------------------------------------------------------------------
select employee_id, last_name
from employees
where last_name like '__a%';
----------------------------------------
select last_name
from employees
where last_name like '%a%' and last_name like '%i%';



















