# Project Test

## Status do projeto
O projeto está em desenvolvimento. Para finalizar o projeto restam apenas 2 'tasks' não concluídas.
 
1. A adição automática do CEP.

2. A não permissão de duplicação de dados.


## Pré-requisitos

Antes de começar você precisa ter instalado na sua maquina as seguintes ferramentas: 
[VS Code](https://code.visualstudio.com/), [NodeJs](https://nodejs.org/en/), [Angular](https://angular.io/), [SQlite](https://sqlitebrowser.org/), [.Net 5.0.15](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

Para rodar a aplicação, separe o terminal interno do 'VS code' em dois, em um rode o comando "cd TestAngular" e em seguida o comando "npm i" para instalar as dependências e "ng server" ou "npm start" para iniciar. No segundo terminal rode o comando "cd TestWebAPI" e em seguida o comando "dotnet run".

Para acessar o aplicação integrada, copie e cole o link a seguir em seu browser: http://localhost:4200/

### Banco de dados alternativo

Para utilizar o banco de dados SQLServer, exclua o diretório "Migrations" e o arquivo "Test.db", após isso altere o banco de dados no Arquivo "Startup.cs" e instale o pacote "Microsoft.EntityFrameworkCore.SqlServer" na versão 5.0.15.
Feito isto, exclua o pacote "Microsoft.EntityFrameworkCore.Sqlite", rode os comandos "cd TestWebAPI", "dotnet ef migrations add initial" e "Dotnet ef database update".


## Técnologias utilizadas

[NodeJs](https://nodejs.org/en/), [Angular](https://angular.io/), [.Net 5.0.15](https://dotnet.microsoft.com/en-us/download/dotnet/5.0), [NGX-Bootstrap](https://valor-software.com/ngx-bootstrap/#/), [Entity Framework]

