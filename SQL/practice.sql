select job_id, department_id 
from employees
group by job_id, department_id;

select job_id, department_id 
from employees
group by department_id, job_id;

select first_name
from employees
where salary = (select max(salary) from employees);