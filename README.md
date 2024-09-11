# API de Controle de Funcionários

Esta é uma API simples desenvolvida em .NET para o gerenciamento de funcionários. A API suporta operações CRUD (Criar, Ler, Atualizar, Deletar) para a gestão de informações dos funcionários usando um banco de dados MySQL.

## Visão Geral

A API fornece endpoints para realizar operações básicas sobre funcionários, incluindo a criação, leitura, atualização e exclusão de registros. É ideal para aplicações que necessitam de um backend para gerenciar dados de funcionários.

## Requisitos

- **.NET 6.0 ou superior**: Para executar a API.
- **Banco de Dados MySQL**: Para armazenar os dados dos funcionários.
- **Ferramentas**: Ferramentas de desenvolvimento como [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) com [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) e [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) instalados.
- **MySQL Connector/NET**: Para conectar a API ao MySQL.

## Estrutura do Projeto

O projeto é estruturado da seguinte forma:

- **Controllers**: Contém os controladores da API para gerenciar as solicitações HTTP.
- **Models**: Contém as classes de modelo para os dados dos funcionários.
- **Data**: Contém o contexto do banco de dados e configurações.
- **Migrations**: Scripts para a criação e atualização do esquema do banco de dados.

## Instalação

### 1. Clonar o Repositório

Clone o repositório para sua máquina local:

```bash
https://github.com/seu-usuario/EmployeesAPI.git
