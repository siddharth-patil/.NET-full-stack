--lab4 chapter 3 - ordering and sorting
select * from  employees;
select last_name, salary
from employees where salary>12000;
-----
select * from employees where employee_id = 175;
------------
select last_name, salary from employees 
where salary between 5000 and 12000;
---
select last_name, salary from employees 
where salary not between 5000 and 12000;
-------------------------------
select last_name, job_id, hire_date from employees 
where last_name in('Taylor', 'Vargas')
order by hire_date;
------------------------------
select last_name, department_id from employees 
where department_id in(20,70)
order by last_name;
------------------------------
select last_name as "LName", salary as sal
from employees
--where (salary between 5000 and 12000) and department_id in (10,20);
where salary between 5000 and 12000 and department_id in (10,20);
----------------------------------
select last_name, hire_date from employees
where hire_date between '1-JAN-2006' and '31-dec-2006';
--where hire_date >= '1-JAN-2006' and hire_date <= '31-dec-2006';

---------------------------------------------
select last_name , job_id, manager_id from employees
where manager_id is  null;
--where manager_id is not null;
-----------------------------------------

select last_name , salary, commission_pct from employees 
where commission_pct is not null
order by commission_pct desc;
----------------------------------
select last_name , salary from employees
where salary > &sal; --used substitution variable
-------------------------------------------------
select last_name, first_name, manager_id from employees 
where manager_id = &manID
order by &colName;
----------------------------------------------
select last_name from employees
where last_name like '__a%';
----
select last_name from employees
where last_name like '%a%' and last_name like '%i%';
-----------------------------------------------------
--Extra
select last_name, job_id, salary from employees
where job_id in('SA_REP','ST_CLERK') and salary not in (2500, 3500, 7000);
----------------
select concat(last_name, concat(' - ',job_id)) as "Employee-Job"
from employees
where department_id=10;














































