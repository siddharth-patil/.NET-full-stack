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

--select d.department_name 
--from departments d
--where d.department_id not in (select distinct(department_id)
--                                    from employees);

select d.department_name
from departments d
left join employees e
on e.department_id = d.department_id
where e.employee_id is null;

--10. Retrieve the names of employees who have the same job as their manager.
--    - Tables: `employees` (self-join)

select e1.employee_id
from employees e1
join employees m
on e1.manager_id = m.employee_id
where e1.job_id = m.job_id;

SELECT e.employee_id, e.first_name AS employee_name, e.job_id AS employee_job,
       m.employee_id AS manager_id, m.first_name AS manager_name, m.job_id AS manager_job
FROM employees e
JOIN employees m
ON e.manager_id = m.employee_id
WHERE e.job_id = m.job_id;

--11 Display the total salary paid to employees in each country.
--    - Tables: `employees`, `departments`, `locations`, `countries`
select country_name, sum(salary)
from countries
join locations using (country_id)
join departments using (location_id)
join employees using (department_id)
group by country_name;
            --OR--
SELECT c.country_id, c.country_name, SUM(e.salary) AS total_salary
FROM employees e
JOIN departments d ON e.department_id = d.department_id
JOIN locations l ON d.location_id = l.location_id
JOIN countries c ON l.country_id = c.country_id
GROUP BY c.country_id, c.country_name
ORDER BY total_salary DESC;

--12. List all jobs that do not have any employees assigned to them.
--    - Tables: `jobs`, `employees` (use OUTER JOIN)

select j.job_id
from jobs j
left join employees e
on e.job_id = j.job_id
where e.employee_id is null;

SELECT j.job_id, j.job_title
FROM jobs j
LEFT JOIN employees e
ON j.job_id = e.job_id
WHERE e.employee_id IS NULL;

select distinct job_id from jobs;
select distinct job_id from employees;

--### **Challenge JOIN Questions**

--13. Write a query to retrieve the employees who work in the same department as "Steven King."
--    - Tables: `employees`, `departments`

select e.employee_id, d.department_name
from employees e
join departments d
on e.department_id = d.department_id
where department_name = (select distinct(department_name) from departments d
                          join employees e on e.department_id = d.department_id
                          where e.last_name = 'King' and e.first_name = 'Steven')
                          and e.last_name <> 'King' and e.first_name <> 'Steven';
                          
                          --OR--

SELECT e.employee_id, e.first_name AS employee_name, e.department_id
FROM employees e
JOIN employees s
ON e.department_id = s.department_id
WHERE s.first_name = 'Steven' AND s.last_name = 'King'
  AND e.employee_id != s.employee_id;

--14. Retrieve the department name, city, and the average salary of employees in each department.
--    - Tables: `employees`, `departments`, `locations`






















































