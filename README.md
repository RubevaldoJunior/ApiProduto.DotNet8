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

- .NET 6 SDK
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
4. 
