--1. Write a query to retrieve the names of employees along with the name of the department they belong to.
--   - Tables: `employees`, `departments`

select e.last_name, d.department_name
from employees e
join departments d
on e.department_id = d.department_id;

--2. Display the first name of employees along with their job title.
--   - Tables: `employees`, `jobs`
select e.first_name, j.job_id, j.job_title
from employees e
join jobs j
on e.job_id = j.job_id;

--3. List the department names and the location IDs where they are located.
--   - Tables: `departments`, `locations`
select * from locations;
select * from departments;

select d.department_name, l.city
from departments d
join locations l
using (location_id);

--4. Retrieve the names of employees and their manager names.
--   - Tables: `employees` (self-join)

select * from employees;
select distinct(manager_id) from employees;


select e1.first_name || ' ' || e1.last_name as "EmpName", e2.first_name || ' ' || e2.last_name as "MgrName"
from employees e1
join employees e2
on e1.manager_id = e2.employee_id;









































