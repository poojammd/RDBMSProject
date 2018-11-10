create database travel
use travel

create table users (usern varchar(10) PRIMARY KEY,pass varchar(10),name varchar(25), age int,city varchar(15),mob int)
select * from users
insert into users values ('poop','123','Poop',10,'mn',123)
insert into users values ('a','1','Poop',10,'mn',123)
drop table users

create table packages( pid  varchar(20) PRIMARY KEY , pname varchar(20) , price int,city varchar(20), noofdays int)
drop table packages
insert into  packages values('P01','Package1',5000,'Delhi',7)
insert into  packages values('P02','Package2',10000,'Mangalore',3)
insert into  packages values('P03','Package3',20000,'Bangalore',3)
insert into  packages values('P04','Package4',6000,'Kolkata',5)
insert into  packages values('P05','Package5',6500,'Rajasthan',3)
insert into  packages values('P06','Package6',7500,'Allepey',2)
insert into  packages values('P07','Package7',8000,'Amritsar',4)
select * from packages 

create table bookings (usern varchar(10), pid varchar(20), pname varchar(20), page varchar(20), porigin varchar(15), pmob varchar(10), city varchar(15), startdate varchar(20), PRIMARY KEY(usern,pid,startdate))
select * from bookings
drop table bookings
p
select distinct price from packages order by price
select city from packages where price = 5000

drop table users

select distinct noofdays as days from packages order by days