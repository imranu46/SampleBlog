create table users(
id int identity(1,1) primary key,
username varchar(128),
email varchar(256),
password_hash varchar(128)
)

insert into users values('imran', 'imran@gmail.com', 'asfasff');
insert into users values('nouman', 'nauman@gmail.com', 'qwrqwre');
insert into users values('rizwan', 'rizwan@gmail.com', 'xczvzxv');
insert into users values('rehman', 'rehman@gmail.com', 'ljljkjljlj');
insert into users values('admin', 'abc@admin.com', '12345');

select * from users