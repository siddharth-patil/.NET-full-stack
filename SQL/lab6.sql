--lab6

desc employees;
-------------------
select last_name || ' earns monthly ' || salary || ' but excepts ' || 2*salary || 
       ' after appraisal.' as "Appraised Salary"
from employees;       

-----------------------------------------------------------------------
SELECT 
    LAST_NAME,
    TO_CHAR(HIRE_DATE, 'Day, "the" DDth "of" Month, YYYY') AS HIRE_DATE,
    TO_CHAR(
        NEXT_DAY(ADD_MONTHS(HIRE_DATE, 5), 'MONDAY'),
        'Day, "the" DDth "of" Month, YYYY'
    ) AS REVIEW
FROM 
    EMPLOYEES;
---------------------------------------------------------------------------

select last_name, nvl(to_char(commission_pct * salary), 'No commision') as comm
from employees;
-----------------------------------------------------------------------------
select hire_date, to_char(hire_date,'day') as day
from employees
where last_name = 'Davies';
