CREATE DATABASE PROJECTTODOLIST;
DROP DATABASE PROJECTTODOLIST;

USE PROJECTTODOLIST;

CREATE TABLE Persons(
	id int(3) primary key not null auto_increment,
    username varchar(150) not null,
    email varchar(150) not null,
    password varchar(16) not null
);

CREATE TABLE Projects(
	id int(3) primary key not null auto_increment,
    title varchar(100) not null,
    about varchar(300) not null,
    deadline datetime default now(),
    completed boolean default false,
    created_at datetime default now(),
    updated_at datetime default now(),
    deleted_at datetime,
    user_id int(3) not null,
    foreign key (user_id) REFERENCES Persons(id)
);

CREATE TABLE Tasks(
	id int(3) primary key not null auto_increment,
    title varchar(100) not null,
    deadline datetime default now(),
    completed boolean default false,
    created_at datetime default now(),
    updated_at datetime default now(),
    project_id int(3) not null,
    foreign key (project_id) REFERENCES Projects(id)
);
