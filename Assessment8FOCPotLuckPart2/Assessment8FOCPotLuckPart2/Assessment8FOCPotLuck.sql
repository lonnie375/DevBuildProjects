create database FOCPotLuck; 
use focpotluck; 
create table teammember (
	id int primary key auto_increment, 
    firstname varchar(50), 
    lastname varchar(50), 
    emailaddress varchar(50), 
    attendancedate datetime, 
    guestname varchar(50)
);

create table dish (
	id int primary key auto_increment, 
    tmname varchar(50), 
    phonenumber varchar(25), 
    dishname varchar(50), 
    dishdescription varchar(100), 
    category varchar(25)
);
use focpotluck; 
select * from teammember; 
select * from dish; 
