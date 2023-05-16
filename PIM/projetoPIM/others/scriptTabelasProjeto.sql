create database ac3Rafael;
use ac3Rafael;
 create table Games(
 idGame int primary key auto_increment,
 nome varchar(40),
 categoria varchar(30)
 );
 insert into Games value 
 (null, 'Apex', 'multiplayer'),
 (null, 'Rainbow', 'fps'),
 (null, 'Cuphead', 'casual');
 
 create table plataforma(
 idPlataforma int primary key auto_increment,
 marca varchar(30), 
 modelo varchar(30)
 )auto_increment = 100;
 insert into plataforma values
 (null, 'microsoft', 'xbox one'),
 (null, 'playstation', 'ps4'),
 (null, 'playstation', 'ps5'),
 (null, 'microsoft', 'computador'),
 (null, 'microsoft', 'xbox series');
 
 create table usuario (
 idUsuario int primary key auto_increment,
 nome varchar(40),
 email varchar(45),
 fkPlataforma int,
 foreign key (fkPlataforma) references plataforma(idPlataforma)
 )auto_increment = 1000;
 insert into usuario values 
 (null, 'Rafael Faria', 'rafa.gomes@gmail.com', 103),
 (null, 'Bruno Ribeiro', 'ribeiro.bruno@gmail.com', 100),
 (null, 'Fernanado Zuppo', 'fernanado.zuppo@gmail.com', 101),
 (null, 'José Alcantara', 'jose.alcantara@gmail.com', 102),
 (null, 'Rodrigo Itf', 'rodrigo.itf@gmail.com', 104),
 (null, 'Ana Rodrigues', 'ana.ro@gmail.com', 101);
 
 create table associativa(
 fkGame int, 
 fkUsuario int,
 precoPago decimal(5,2),
 primary  key (fkGame, fkUsuario),
 foreign key (fkGame) references games(idGame),
 foreign key (fkUsuario) references usuario(idUsuario)
 );
 insert into associativa values 
 (1, 1000, 00.00),
 (1, 1001, 50.00),
 (1, 1004, 80.00),
 (1, 1002, 20.00),
 (2, 1000, 30.00),
 (2, 1001, 60.00),
 (3, 1000, 00.00),
 (3, 1001, 50.00),
 (3, 1003, 50.00);
 
 select * from games;
 select * from plataforma;
 select * from usuario;
 select * from associativa;
 select * from usuario inner join plataforma on fkplataforma = idplataforma;
 select * from usuario join associativa on idUsuario = fkUsuario join games on fkGame = idGame;
 select * from associativa join usuario on fkUsuario = idUsuario;
 select games.nome, associativa.precopago from games join associativa on idgame = fkgame;
 select avg(precopago) as 'média de preços', sum(precopago) as 'soma dos precos' from associativa group by fkUsuario;
 select usuario.*, associativa.fkgame, associativa.precopago  from usuario left join associativa 
 on idUsuario = fkUsuario;
 delete from associativa where fkUsuario = '1002';