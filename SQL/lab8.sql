--lab 8
select * from locations;
--1
select city, department_name
from departments 
join locations
on departments.location_id = locations.location_id;

--2
select e.last_name, e.salary, d.department_id, d.department_name
from employees e
join departments d
on e.department_id = d.department_id;

--3
select e.last_name, e.salary, d.department_id, d.department_name
from employees e
join departments d
on e.department_id = d.department_id
and e.department_id in (20,30);

--4
select e.last_name, e.salary, d.department_id, d.department_name
from employees e
join departments d
on e.department_id = d.department_id
and d.department_name = 'Finance';

--5
select e.last_name, e.job_id, e.department_id, d.department_name, l.city
from employees e
join departments d
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id
where l.city = 'Toronto';

--6
select e.last_name as "empName", e.salary as "empSal", m.last_name as "mgrName", m.salary as "mgrSal"
from employees e
join employees m
on e.manager_id = m.employee_id;

--7
select e.last_name as "empName", e.salary as "empSal", m.last_name as "mgrName", m.salary as "mgrSal"
from employees e
left join employees m
on e.manager_id = m.employee_id; 

--8
select e.last_name
from employees e
where department_id = (select department_id from employees 
                                where last_name = 'Higgins')
and last_name <> 'Higgins';

--9
select e.last_name, e.salary, m.last_name, m.salary
from employees e
join employees m
on e.manager_id = m.employee_id
where e.salary > m.salary;













































