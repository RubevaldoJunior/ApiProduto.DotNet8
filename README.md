# ApiProduto

Esta é uma API de Produto criada usando C# e PostgreSQL, seguindo os padrões RESTful. A API permite realizar operações CRUD em produtos, além de um dashboard que exibe a quantidade e o preço médio dos produtos, segregados por tipo. A autenticação básica é utilizada para proteger os endpoints.

## Funcionalidades

- Leitura por ID
- Leitura de lista
- Inserção
- Alteração
- Deleção
- Dashboard

## Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- Swagger

## Configuração do Ambiente

### Pré-requisitos

- .NET 8 SDK
- PostgreSQL

### Configuração do Banco de Dados

1. Instale o PostgreSQL.
2. Crie um banco de dados chamado `Produto`.

### Configuração da Aplicação

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/ApiProduto.DotNet8.git
   cd ApiProduto
2. Abra o projeto no visual studio
3. Configure a string de conexão no appsettings.json: 
 ```
   {
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=Produto;Username=seu-usuario;Password=sua-senha"
  }
}
```
4. Abra o projeto no terminal
   ```
   cd ApiProduto
   ´´´
5. Adicione as migrações e atualize o banco de dados:
   ```
   dotnet ef migrations add InitialCreate
   dotnet ef database update
6. Após finalizar a migração, você pode rodar a API pelo console ou visual studio


Perguntas:

1 - Quais princípios SOLID foram usados? Qual foi o motivo da escolha deles?

R: 

Princípio de Responsabilidade Única (SRP). 
Princípio da Inversão de Dependência (DIP).
Foram escolhidos esses princípios devido a sua fácil implementação em um projeto pequeno ou grande. 

2 - Dado um cenário que necessite de alta performance, cite 2 locais possíveis 
de melhorar a performance da API criada e explique como seria a 
implementação desta melhoria.

R: 

1. Otimização do Banco de Dados
O acesso ao banco de dados é geralmente o gargalo de desempenho em aplicações que dependem fortemente de leitura e escrita de dados. Melhorar a performance das consultas e operações no banco de dados pode resultar em ganhos significativos de velocidade.
O que fazer: Revisar as consultas para garantir que são eficientes e retornam apenas os dados necessários. Selecionar apenas as colunas necessárias e filtrar os dados na consulta SQL reduz a quantidade de dados transferidos e processados.
2. Uso de Cache
Utilizar um cache em memória para armazenar dados frequentemente acessados. O cache em memória armazena os dados em memória volátil, o que permite acesso rápido. Dados frequentemente acessados, como listas de produtos, podem ser armazenados em cache para evitar consultas repetidas ao banco de dados.
