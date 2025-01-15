select * from employees;
--1
select department_name, first_name 
from departments
join employees
on departments.manager_id = employees.manager_id;

--2
select emp.first_name as empName, mgr.first_name as mgrName
from employees emp
join employees mgr
on emp.manager_id = mgr.employee_id;
--on emp.employee_id = mgr.manager_id;











































