use vizucafe;

create table cafe (
	id INT primary key auto_increment,
	nome varchar(30),
	sabor varchar(30),
	valor decimal(10,2),
	descricao tinytext
);

select * from cafe;
