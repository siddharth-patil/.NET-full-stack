--chatGPT 2 
select * from departments;
--2. List the names and hire dates of employees who were hired in the year 2000.
--   - Table: `employees`

select last_name, hire_date
from employees
where hire_date between '1-jan-00' and '31-dec-00';

--6. Retrieve the names of employees who work in the "IT" department.
--   - Tables: `employees`, `departments`
select e.last_name, d.department_name
from employees e
join departments d
on e.department_id = d.department_id
where d.department_name = 'IT';

--8. List the first names of employees along with their manager's first name.
--   - Table: `employees` (self-join)

select e.first_name as "empName", m.first_name as "mgrName"
from employees e
join employees m
on e.manager_id = m.employee_id;

--9. Display the names of employees who work in the same country as "Steven King."
--   - Tables: `employees`, `departments`, `locations`, `countries`

select e.employee_id, e.last_name, c.country_name
from employees e
join departments d
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id
join countries c
on l.country_id = c.country_id
where c.country_name = (select c.country_name
                        from employees e
                        join departments d
                        on e.department_id = d.department_id
                        join locations l
                        on d.location_id = l.location_id
                        join countries c
                        on l.country_id = c.country_id
                        where last_name = 'King' and first_name='Steven');












































































