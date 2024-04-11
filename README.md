# CalculatorApi
#### Calculadora api simples para treinar o padrão rest.

Para executar a aplicação é bem simples. 
1. Primeiro faça o clone do projeto e abra no Vs studio ou Code;
2. Agora vc vai ter que criar o banco de dados usando ou Sql server ou o Object explorer Sql Server do Vs Studio;
3. Mudar a connectionString no arquivo appsettings;
4. Efetuar as migrations com Entityframework via terminal, os comandos são respectivamente: 'dotnet ef migrations add nomeDaMigration' e 'dotnet ef database update';
5. Banco e migration criados, agora é só dar um 'dotnet run' e passar os parâmetros via endpoint.
