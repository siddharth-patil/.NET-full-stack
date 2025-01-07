select last_name, salary
from employees
where employee_id = &empId;
---------------------------------------------
select last_name, salary
from employees 
where last_name = '&lastName';
