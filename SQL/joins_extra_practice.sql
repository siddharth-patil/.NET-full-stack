select * from employees;
--1.1
select department_name, first_name 
from departments
join employees
on departments.manager_id = employees.manager_id;

--1.2
select emp.first_name as empName, mgr.first_name as mgrName
from employees emp
join employees mgr
on emp.manager_id = mgr.employee_id;
--on emp.employee_id = mgr.manager_id;

--1.3
select emp.first_name, d.department_name
from employees emp
join departments d
on emp.department_id = d.department_id
where department_name in('Sales', 'Accounting');

--1.4
select * from jobs;

select * from employees
where job_id like 'PU_CLERK' or job_id like 'ST_CLERK' or job_id like 'SH_CLERK';

--1.5
select first_name, employee_id, job_title from employees 
join jobs 
using(job_id)
where job_title not in ('President','Administration Vice President');

--1.6
select * from employees 
where manager_id is not null;

-----
--2
select e.employee_id, e.last_name,l.city from employees e
join departments d
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id;

--3
--3.1
select 'The employee ' || e.last_name || 'with employee Id ' || e.employee_id || 'worked in ' || d.department_name || 'with designation of ' || j.job_title ||
        'from ' || jh.start_date  || 'to ' || jh.end_date
from employees e
join departments d
on e.department_id = d.department_id
join jobs j
on e.job_id = j.job_id
join job_history jh
on e.employee_id = jh.employee_id;

--4
select * from departments;

select e.employee_id, e.last_name, j.job_title "empDesignation", d.department_name, e2.employee_id as "ManagerEmpId", e2.last_name "ManagerLastName",
        j2.job_title "MgrDesignation", d2.department_name "MgrDept", e2.salary as "MgrSalary"
        from employees e
join jobs j
on e.job_id = j.job_id
join departments d
on e.department_id = d.department_id
join employees e2
on e.manager_id = e2.employee_id
join jobs j2
on  e2.job_id = j2.job_id
join departments d2
on e2.department_id = d2.department_id;

--8
select * from locations;
select * from regions;

select e.employee_id, e.first_name, e.salary, d.department_name
from employees e 
join departments d
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id
where l.city in ('New York','Dallas') 
and
months_between(sysdate, e.hire_date)/12 > 7
and
e.commission_pct is null
order by l.city;

--9
select e.employee_id, e.last_name, e.salary, d.department_name, d.location_id, d.department_id, j.job_title
from employees e
join departments d
on e.department_id = d.department_id
join jobs j 
on e.job_id = j.job_id
join locations l
on d.location_id = l.location_id
where l.city = 'Chicago' or (d.department_name = 'Accounting' and (e.salary*12) >28000);

--10

--11
select employee_id, salary, min_salary, max_salary
from employees 
join jobs
using (job_id)
where salary not between min_salary and max_salary;

--12
select e.last_name, e.salary, mgr.last_name as mgr, mgr.salary as mgrSal
from employees e
join employees mgr
on e.manager_id = mgr.employee_id;

--13
select * from job_history;

select distinct(employees.employee_id), last_name, salary, department_name, job_title, hire_date, start_date
from employees 
join departments
on employees.department_id = departments.department_id
join job_history
on employees.employee_id = job_history.employee_id
and start_date<>hire_date
join jobs
on employees.job_id = jobs.job_id;








































