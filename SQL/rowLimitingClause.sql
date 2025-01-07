select last_name, salary
from employees
order by salary
fetch first 4 rows only; --display 1st 5 rows
------------------------------------------------
select last_name, salary
from employees
order by salary
offset 5 rows fetch next 4 rows only; --skip 1st 5 rows sand display next 4 rows
---------------------------------------------------
select last_name, salary
from employees 
order by salary
offset 11 rows fetch next 5 rows with ties; -- if last row salary is 10000 and next salary is also 10000 then it will display that also
---------------------------------------------------------------------
select * from (select last_name, salary
                from employees
                order by salary desc)
where rownum<=5;   -- rownum instead of fetch
--------------------------------------------------------------------------
select * from (select last_name, salary
from employees
order by salary)
--offset 5 rows 
where rownum<=4;

---------------------------------------------------------------------

