create database assessment7MySQL; 
use assessment7MySQL; 

/*Create a persons table*/ 
create table if not exists persons2 
(
	person_id int(2) not null unique primary key, 
    first_name varchar(30) not null,
    last_name varchar(30) not null, 
    city varchar(30), 
    leader_id int(2),
    check (leader_id = person_id or leader_id = null)
    
);

insert into persons2 (person_id,first_name, last_name, city, leader_id)
values(1, 'rile', 'shirk', 'ann arbor', 5); 
select * from persons2; 

insert into persons2 (person_id,first_name, last_name, city, leader_id)
values(2, 'tia', 'kansas', 'detroit', 5); 
insert into persons2 (person_id,first_name, last_name, city, leader_id)
values(4, 'hemory', 'phifer', 'detroit', 5); 
insert into persons2 (person_id,first_name, last_name)
values(5, 'russ', 'thomas'); 
insert into persons2 (person_id,first_name, last_name, city)
values(6, 'montana', 'greyerbiehl', 'new york'); 
select * from persons2; 


create table roles 
(
	role_id int(2), 
    role_title varchar(100) not null

);
insert into roles(role_id, role_title)
values(1, 'senior business program manager'); 
insert into roles(role_id, role_title)
values(2, 'associate business program manager'); 
insert into roles(role_id, role_title)
values(3, 'team leader'); 
insert into roles(role_id, role_title)
values(4, 'director'); 

select * from roles; 
select * from persons2; 
/*1. Update the spelling of tia's name*/ 
update persons2
set first_name = 'Tiia'
where first_name = 'tia'; 

/*2.*/
alter table persons2
add column role_id int(2) not null;



update persons2 
set role_id = 2
where first_name = 'tiia'; 
select * from persons2; 
update persons2 
set role_id = 2
where first_name = 'rile'; 

update persons2 
set role_id = 1
where first_name = 'hemory'; 

update persons2 
set role_id = 3
where first_name = 'russ'; 
update persons2 
set role_id = 4
where first_name = 'montana'; 

select * from persons2; 

alter table persons2
add constraint check_role_id check (role_id= 1 or role_id = 2 or role_id = 3 or role_id = 4); 
/*
insert into persons2(person_id, first_name, last_name, city, leader_id, role_id)
values(7, 'paul', 'johnson', 'houston', 5, 0); 
Make sure the check constraint works. The role id has to be 1-4
*/

/*3. create a view for all the distinct cities eliminating null entries*/ 
create view view_cities as 
select distinct city from persons2 where city is not null; 

select * from view_cities; 


/*4. Create a viewe_titles that retrieves the full name of each team member along with their title */
create view  view_titles as
select persons2.first_name, persons2.last_name, roles.role_title
from persons2
join roles on persons2.role_id = roles.role_id; 

/*5. Add yourself!*/
insert into persons2(person_id, first_name, last_name, city, leader_id, role_id)
values(7, 'lonnie', 'johnson', 'houston', 5, 2); 

select * from view_titles; 

/*Testing constraint from the persons2 table*/ 
insert into persons2(person_id, first_name, last_name, city, leader_id, role_id)
values(7, 'lonnie', 'johnson', 'houston', 3, 2); 
/*The test worked. Cool beans*/ 

alter table persons2
add constraint adding_foreignkey
foreign key (role_id) references roles(role_id);

alter table roles
add constraint roles_key primary key (role_id); 

desc persons2; 
desc roles; 

select * from persons2; 
select * from roles; 