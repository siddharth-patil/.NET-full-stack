--lab 11
--1
insert into myemp
values (123, 'lsName11', 'fsName11', 2252745, 99);
insert into myemp
values (126, 'lsName12', 'fsName12', 4522657,100);

--2
select * from myemp;

--3
savepoint s1;

--4
delete myemp;

--5
select * from myemp;

--6
rollback to SAVEPOINT s1;

--7
select * from myemp;

--8
commit;


































