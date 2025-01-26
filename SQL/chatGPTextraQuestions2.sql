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

--10. Retrieve the job title and the total salary paid for each job.
--    - Tables: `employees`, `jobs`
select * from jobs;

select job_title, sum(salary)
from jobs j
join employees e
on e.job_id = j.job_id
group by job_title;

--11. Display the department ID and the total salary for each department.
--    - Tables: `employees`
select department_id, sum(salary)
from employees 
group by department_id;

--13. Retrieve the department name and the number of employees in each department.
--    - Tables: `employees`, `departments`

select d.department_name, count(e.employee_id) --count(*) also works
from departments d
join employees e
on d.department_id = e.department_id
group by d.department_name;

--14. Find the city where the highest-paid employee works.
--    - Tables: `employees`, `departments`, `locations`
select e.last_name, e.salary, l.city
from employees e
join departments d
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id
where e.salary = (select max(salary) from employees);

--15. List the department names that have more than 5 employees.
--    - Tables: `employees`, `departments`
select d.department_name, count(e.employee_id) as noOfEmp
from departments d
join employees e
on d.department_id = e.department_id
group by d.department_name
having  count(e.employee_id) > 5;

--16. Retrieve the employees who earn more than the average salary of their department.
--    - Table: `employees`
select e1.employee_id, e1.department_id, e1.salary
from employees e1 
where salary > (select avg(salary) 
                    from employees e2
                    where e2.department_id = e1.department_id);

--17. Find the name and job title of the highest-paid employee in each department.
--    - Tables: `employees`, `jobs`, `departments`
select e.last_name, j.job_title
from employees e
join jobs j
on e.job_id = j.job_id
where e.salary = (select max(salary) 
                    from employees e2
                    where e2.department_id = e.department_id
                    );

--18. Display the employee details of those who work in the same department as "Neena Kochhar."
--    - Tables: `employees`, `departments`
select first_name, last_name, employee_id, department_id
from employees 
where department_id = (select department_id from employees where last_name ='Kochhar' and first_name = 'Neena')
and (last_name <>'Kochhar' and first_name <> 'Neena');

--19. Show the job title and department name of the employee earning the highest salary.
--    - Tables: `employees`, `jobs`, `departments`
select e.employee_id, e.last_name, j.job_title, d.department_name
from employees e
join jobs j on e.job_id = j.job_id
join departments d on e.department_id = d.department_id
where e.salary = (select max(salary) from employees);

--20. List the employees whose salary is higher than the average salary of all employees.
--    - Table: `employees`
 select employee_id , last_name
 from employees 
 where salary > (select avg(salary) from employees);
 
--25. List all departments that do not have any employees.
--    - Tables: `departments`, `employees`
select d.department_name, e.employee_id from departments d
left join employees e
on d.department_id = e.department_id
where e.employee_id is null;

--26. Write a query to display the total salary for each country.
--    - Tables: `employees`, `departments`, `locations`, `countries`
select distinct(country_name) from countries;

select c.country_name, sum(e.salary) "Total Country Salary"
from employees e
join departments d
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id
join countries c
on l.country_id = c.country_id
group by c.country_name;

--27. Find all employees who are earning less than the highest-paid employee in the "IT" department.
--    - Tables: `employees`, `departments`
select e.employee_id, e.department_id, d.department_name, e.salary
from employees e
left join departments d
on e.department_id = d.department_id
where salary < (select max(salary) from employees e1 
                    join departments d1 on e1.department_id = d1.department_id
                    where d1.department_name = 'IT')
order by e.employee_id;
                --OR--
SELECT e.employee_id, e.first_name, e.last_name, e.salary, e.department_id
FROM employees e
WHERE e.salary < (
    SELECT MAX(e2.salary)
    FROM employees e2
    JOIN departments d ON e2.department_id = d.department_id
    WHERE d.department_name = 'IT'
)
order by e.employee_id;

--28. Show the department name and the average salary of employees, sorted by the average salary in descending order.
--    - Tables: `employees`, `departments`
select d.department_name, round(avg(e.salary))
from departments d
join employees e
on d.department_id = e.department_id
group by d.department_name
order by round(avg(e.salary));

--29. Retrieve the employees whose hire date is the earliest in their department.
--    - Tables: `employees`, `departments`
select e.employee_id, e.hire_date
from employees e
where e.hire_date = (select min(hire_date) from employees e1
                        where e.department_id = e1.department_id );

           --OR--
SELECT e.employee_id, e.first_name, e.last_name, e.hire_date, d.department_name
FROM employees e
JOIN departments d ON e.department_id = d.department_id
WHERE e.hire_date = (
    SELECT MIN(e2.hire_date)
    FROM employees e2
    WHERE e2.department_id = e.department_id
);

--30. Find the names of employees who have been with the company for more than 10 years.
--    - Table: `employees`
select last_name, hire_date
from employees
where (sysdate-hire_date)>10;
            --OR--
SELECT employee_id, first_name, last_name, hire_date
FROM employees
WHERE ADD_MONTHS(hire_date, 120) <= SYSDATE;


































