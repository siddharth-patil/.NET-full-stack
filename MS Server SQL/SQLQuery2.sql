select * from person.Person
where PersonType= 'SC';
-----------------------------------
select * from person.Person
where BusinessEntityID between 1 and 5;
-------------------------------------------

select * from Person.Person
where BusinessEntityID in(1,2,7);
--------------------------------------

select distinct PersonType 
from Person.Person
----------------------------------------
--Ascending order 
select FirstName, MiddleName, LastName
from Person.Person 
order by FirstName
--Descendig order 
select FirstName, MiddleName, LastName
from Person.Person 
order by FirstName desc

-----------------------------------------------
-----------------------------------------------
--Group By
select * from Production.ProductInventory;
----
select Shelf, sum(Quantity) as QuaNtity, sum(Bin) Bin
from Production.ProductInventory
group by Shelf order by Shelf;
-----------------------------------------
----------------------------------------
--Having clause
select Shelf, sum(quantity) as Qty, sum(bin) bin
from Production.ProductInventory
--where Shelf='A'
--group by Shelf 
group by Shelf having Shelf='A';