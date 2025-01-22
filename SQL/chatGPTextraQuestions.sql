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

--5. Find all employees who work in the location with the city "Seattle."
--   - Tables: `employees`, `departments`, `locations`

select e.employee_id, e.last_name, e.department_id, l.city
from employees e
join departments d on e.department_id = d.department_id
join locations l on d.location_id = l.location_id;

--6. Display the name of the employee, their job title, and the department name.
--   - Tables: `employees`, `jobs`, `departments`

select e.last_name, j.job_title, d.department_name
from employees e
join jobs j
on e.job_id = j.job_id
join departments d
on e.department_id = d.department_id;

--7. Retrieve the details of employees along with their country names.
--   - Tables: `employees`, `departments`, `locations`, `countries`

select e.employee_id, e.last_name, c.country_name
from employees e
join departments d
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id
join countries c
on l.country_id = c.country_id;

--8. Show the department names that have employees earning more than $10,000.
--   - Tables: `employees`, `departments`

select distinct(department_name)
from departments 
join employees
using (department_id)
where salary>10000;


--9. List all departments that do not have any employees.
--   - Tables: `departments`, `employees` (use OUTER JOIN)
select * from departments;







































































