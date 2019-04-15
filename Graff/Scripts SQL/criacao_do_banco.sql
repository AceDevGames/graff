create database graffleilao;

use graffleilao;

create table Pessoa(
id int primary key auto_increment ,
nome varchar(50) not null,
idade int not null
);

create table Produto (
id int primary key auto_increment ,
nome varchar(50) not null,
valor decimal(6,2) not null
);

create table Leilao(
id int primary key auto_increment ,
idProduto int not null,
constraint fk_leilao_produto FOREIGN KEY (idProduto)
  REFERENCES produto (id)
);

create table LancesLeilao(
id int primary key auto_increment,
idLeilao int not null,
idPessoa int not null,
valor double(6,2) not null,
constraint fk_lancesleilao_leilao
FOREIGN KEY (idLeilao)
REFERENCES leilao (id),
constraint fk_lancesleilao_pessoa
FOREIGN KEY (idPessoa)
REFERENCES pessoa (id)
);

select * from LancesLeilao 
where idPessoa;

select Produto.nome,
 Produto.valor, 
 Pessoa.nome, 
 lancesleilao.valor
 from
 lancesleilao 
inner join Leilao on Leilao.id = lancesleilao.idLeilao
inner join Produto on Leilao.ProdutoId = produto.id
inner join Pessoa on lancesleilao.idPessoa = pessoa.id
where Pessoaid