use business; 
select * from employee; 
select * from department; 

select * from employee join department on employee.department = department.id; 

select * from department; 
select distinct department from employee; 
select * from employee where lastname like '%oo%'; 
select * from employee where department = 'IT'; 
select * from employee order by department; 
select * from employee order by firstname; 
select * from employee order by lastname; 

select * from employee; 
select * from employee join department on employee.department = department.id;
delete from employee where id = 26; 
select employee.id, employee.firstname, employee.lastname, department.name as department_name, 
	department.location from employee join department on department.id=employee.department; 
select * from employee; 
update department set location = 'Ferndale' where location = 'Southfield'; 
select * from department; 

/*List all employess but only show their first name, last name, department name */ 
select employee.firstname, employee.lastname, department.name from employee join department on employee.department = department.id; 
select * from employee; 

select firstname, lastname, department from employee where department = 'it' or department = 'acct' order by department; 
select * from employee; 