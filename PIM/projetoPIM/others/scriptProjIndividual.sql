create database projIndividual;
use projIndividual;

create table usuario (
idUsuario int primary key auto_increment,
email varchar(40),
apelido varchar(30),
senha varchar(20) 
);
select * from usuario;