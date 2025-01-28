--display avg salary of every department along with department_name city country name  regionname 
desc regions;
desc locations;
desc countries;

select d.department_name, l.city, c.country_name, r.region_name, round(avg(e.salary))
from employees e
join departments d 
on e.department_id = d.department_id
join locations l
on d.location_id = l.location_id
join countries c
on l.country_id = c.country_id
join regions r
on c.region_id = r.region_id
group by d.department_name, l.city, c.country_name, r.region_name;


select department_name from
(select department_id, avg(salary)
from employees
group by department_id);


SELECT *
FROM (
    SELECT e.*, ROW_NUMBER() OVER (ORDER BY salary DESC) AS rnk
    FROM employees e
) 
WHERE rnk = N;


select *
from employees e
where &N = (select count(e.salary) from employees e2
                    where salary > (select max(e.salary) from employees e2));

select * 
from (
    select e.*, rownum as rnk
    from (
        select * 
        from employees 
        order by salary desc
    ) e
    where rownum <= 2
)
where rnk = 2;


select *
from employees e
where &N = (select count(distinct e.salary) from employees e2
                    where e2.salary>e.salary);

Select Salary 
From  Employees e1 
Where (&n-1) = (Select count(Distinct e2.Salary) 
From Employees e2 
Where e2.Salary > e1.Salary);




















