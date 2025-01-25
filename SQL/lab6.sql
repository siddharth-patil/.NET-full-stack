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
------------------------------------------------------------------------------

select employee_id ,job_id,  (case WHEN job_id = 'AD_PRESS' THEN 'A'
                        WHEN job_id = 'ST_MAN' THEN 'A'
                        WHEN job_id = 'IT_PROG' THEN 'A'
                        WHEN job_id = 'SA_REP' THEN 'A'
                        WHEN job_id = 'ST_CLERK' THEN 'A'
                        ELSE '0'
                        end) as grade
FROM EMPLOYEES;    
--------------------------------------------------------------------------------
select employee_id ,job_id,  (case job_id WHEN 'AD_PRESS' THEN 'A'
                        WHEN 'ST_MAN' THEN 'A'
                        WHEN 'IT_PROG' THEN 'A'
                        WHEN 'SA_REP' THEN 'A'
                        WHEN 'ST_CLERK' THEN 'A'
                        ELSE '0'
                        end) as grade
FROM EMPLOYEES; 
-------------------------------------------------------------------------------
select employee_id ,job_id,  DECODE(job_id , 'AD_PRESS' , 'A'
                        , 'ST_MAN' , 'A'
                        , 'IT_PROG' , 'A'
                        , 'SA_REP' , 'A'
                        , 'ST_CLERK' , 'A'
                        , '0') as grade
FROM EMPLOYEES;

















































