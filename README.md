# Controle-de-estacionamento

Script de criação da tabela:

CREATE table IF NOT EXISTS cadestacionamento  (
  BDPLACA varchar(8) Primary key,
  BDDATA date,
  BDHORAENTRADA time,
  BDHORASAIDA time,
  BDDURACAO time,
  BDTEMPOCOBRADO float,
  BDPRECO float,
  BDVALORPAGAR float
);

Para alterar os parâmetros de conexão com o banco acessar a classe "Conexao"

