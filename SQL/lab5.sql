--Lab5
select sysdate from dual;
-----------------------------
select employee_id, last_name, salary, (salary+salary*0.16) as "Updated Salary"
from employees;
------------------------------------------------------------------------------------------
select employee_id, last_name, salary, round((salary+salary*0.16),0) as "Updated Salary"
from employees;
------------------------------------------------------------------------------------------
select employee_id, last_name, salary, (salary+salary*0.16) as "Updated Salary",
        ((salary+salary*0.16) - salary) as "Increament"
from employees;
---------------------------------------------------------------------------------------------
select initcap(last_name), length(last_name)
from employees;
-----------------------------------------------------------------------------------
select initcap(last_name), length(last_name)
from employees
where last_name like 'J%' or last_name like 'M%';
-----------------------------------------------------------------------------------
select initcap(last_name), length(last_name)
from employees
where last_name like '&firstLetter%';
-----------------------------------------------------
select initcap(last_name), length(last_name)
from employees
where last_name like Upper('&firstLetter%');
-------------------------------------------------------------
select last_name, hire_date, trunc((sysdate - hire_date)/30) as duration
from employees
order by duration;
-------------------------------------------------------------------------
select last_name,salary, lpad(' ',trunc((salary/1000)+1),'*')
from employees
order by salary;
------------------------------------------------------------------------
select last_name, trunc((sysdate-hire_date)/7) as "Weeks Worked"
from employees 
where department_id = 90
order by "Weeks Worked" desc;
------------------------------------------------------
select last_name, lpad(salary, 12, '$') as "SALARY"
from employees;














