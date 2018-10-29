create database travel
use travel

create table users (usern varchar(10) PRIMARY KEY,pass varchar(10),age int,city varchar(15),mob int,userc varchar(10))
select * from users
insert into users values ('poop','123')

drop table users