select * from departments;

create table dept (dept_id number(3), depat_name varchar2(15));

insert into dept 
values (100, 'd1');

select * from dept;

update dept
set depat_name = 'd-1'
where dept_id = 100;

insert into dept 
values (&deptID, '&deptName');

delete dept 
where depat_name = 'd-7';

insert into dept (dept_id, depat_name)
select department_id, department_name from departments
where department_id between 110 and 150;









































