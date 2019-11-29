use bd_musicas;

create table tabela_dados(
cd_dados int auto_increment,
usuario varchar(30)not null,
senha varchar(30)not null,
rptsenha varchar(30)not null,
email varchar(30)not null,
primary key(cd_dados)

);

select * from tabela_dados;

create table tabela_eventos(
id_eventos integer Primary Key auto_increment,
artistas varchar(30)not null,
dia_Mes date,
localizacao varchar(30)not null,
valor float,
cd_dados integer,
constraint fk_eventos foreign key (cd_dados) references tabela_dados (cd_dados)

);

select * from tabela_eventos;

create table tabela_artista(
id_artista integer primary key auto_increment,
artista varchar(30)not null,
genero varchar(30)not null,
album varchar(30)not null,
cd_dados integer,
constraint fk_artista foreign key (cd_dados) references tabela_dados (cd_dados)

);

select * from tabela_artista;

delete from tabela_artista where id_artista ;

delete from tabela_eventos where id_eventos ;





