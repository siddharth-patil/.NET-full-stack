select initcap(first_name), initcap(last_name), lower(job_id)
from employees;
-------------------------------------------------------------
select concat(substr(last_name,1,8),'_US')
from employees
where department_id=60;
-------------------------------------------------------------
select first_name, last_name, lpad(salary, 7, '*') as salaray
from employees;
-------------------------------------------------------------
select upper(concat(substr(last_name,1,8),'_US')) as LNAME
from employees
where department_id=60;
-------------------------------------------------------------
select power(7,4) as power 
from dual;
-------------------------------------------------------------
select salary, mod(salary, 5000) as Remainder
from employees
where job_id = 'SA_REP';