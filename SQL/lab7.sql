--Lab 7
--1
select round(max(salary)) as max, round(min(salary)) as min, round(sum(salary)) as sum, round(avg(salary)) as avg
from employees;

--2
select count(*) from employees;

--3
select job_id, max(salary),  min(salary), sum(salary), avg(salary)
from employees 
group by job_id;

--4
select job_id , count(*) from employees
group by job_id;

--5
select count(*) from employees
where job_id = '&jobID';

--6
select count(distinct(manager_id))
from employees;

--7
select (max(salary) - min(salary)) as diff
from employees;

--8
select department_id, count(employee_id)
from employees
group by department_id;

--9
select department_id, count(employee_id)
from employees
group by department_id
having count(employee_id)>7;

--10
select manager_id, min(salary)
from employees
group by manager_id;

--11
select manager_id, min(salary)
from employees
where manager_id is not null
group by manager_id;

--12
select manager_id, min(salary) from employees
where manager_id is not null
group by manager_id having min(salary)>6000
order by 2;

--Extra
--1
--select count(*) as total, sum(decode(to_char(hire_date,'YYYY'), '2005', count(hire_date) 
--                                                            ,'2006', count(hire_date) 
--                                                            ,'2007', count(hire_date) 
--                                                            ,'2008', count(hire_date)
--                                                            ))
--from employees;

SELECT 
    COUNT(*) AS Total_Employees,
    SUM(DECODE(TO_CHAR(hire_date, 'YYYY'), '2005', 1, 0)) AS Hired_in_2005,
    SUM(DECODE(TO_CHAR(hire_date, 'YYYY'), '2006', 1, 0)) AS Hired_in_2006,
    SUM(DECODE(TO_CHAR(hire_date, 'YYYY'), '2007', 1, 0)) AS Hired_in_2007,
    SUM(DECODE(TO_CHAR(hire_date, 'YYYY'), '2008', 1, 0)) AS Hired_in_2008
FROM 
    employees;
    
    
--Extra 2
select department_id, avg(salary)
from employees
group by department_id;


































