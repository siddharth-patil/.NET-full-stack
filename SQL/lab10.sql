--lab 10
--1
create table MyEmp (employee_id number(9), last_name varchar2(30),first_name varchar2(30), salary number(9,2), department_no number(9));

--2
desc MyEmp;

--3
insert into myemp
values (123, 'lsName', 'fsName', 3523234, 98);

--4
insert into myemp (employee_id, last_name,first_name, salary, department_no)
values (124, 'lsName2', 'fsName2', 3525889, 99);

--5
select * from myemp;

--6
insert into myemp
values (&emp_id, '&lastName', '&firstName', &salary, &deptNumber);

--7
select * from myemp;

--8
commit;

--9
update myemp
set last_name = 'updatedLastName'
where employee_id = 125;

--10
update myemp
set salary = 4000000
where salary < 4000000;

--11
select * from myemp;

--12
delete myemp
where employee_id=123;

--13
select * from myemp;

--14
commit;






























