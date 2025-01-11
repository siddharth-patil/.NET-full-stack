SELECT TO_CHAR(TO_DATE('12-JAN-1999'), '"This is" MONTH ' )  
FROM DUAL;
----------------------
SELECT TO_CHAR(TO_DATE('12-JAN-1999'), '"This is" fmMONTH ' )  
FROM DUAL;
----------------------
SELECT TO_CHAR(TO_DATE('01-JAN-01'), 'MONTH, DDth YYYY HH:MI:SS') 
FROM DUAL;
----------------------
SELECT TO_CHAR(TO_DATE('01-JAN-01'), 'MONTH, DDSPth YYYY HH:MI:SS')  
FROM DUAL; 
----------------------
SELECT CURRENT_TIMESTAMP(4) FROM dual; 