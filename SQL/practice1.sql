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

desc dept;

alter table dept
add (mgr_id number(3) primary key references employees(employee_id));

insert into dept (dept_id, depat_name, mgr_id)
select department_id, department_name, manager_id from departments
where department_id is not null;

alter table dept
modify (depat_name varchar2(30));

insert into dept (dept_id, depat_name, mgr_id)
select department_id, department_name, manager_id from departments
where department_id is not null;

desc departments;

insert into dept
values (&id, '&name', &mgr);

alter table dept 
drop (dept_id);

select * from dept;





















