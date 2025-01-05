COLUMN Joining_Date FORMAT A12; --resizing the length of column name
SELECT employee_id,
  last_name,
  job_id,
  hire_date AS Joining_Date
  FROM employees;