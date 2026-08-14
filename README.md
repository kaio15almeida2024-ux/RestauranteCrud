# 🍽️ CRUD Restaurante — MVC

## 📚 Projeto Acadêmico

Projeto desenvolvido como atividade individual para implementação de um sistema **CRUD de Restaurante**, utilizando o padrão arquitetural **MVC (Model-View-Controller)** e tecnologias do ecossistema Microsoft.

### 👨‍🏫 Professor

**Wallace Oliveira**

### 👨‍🎓 Aluno

**David Kaio**

> **Atividade individual**

---

## 📌 Sobre o Projeto

O projeto consiste no desenvolvimento de um sistema para gerenciamento de informações de um restaurante, permitindo realizar as principais operações de um CRUD:

* **Create** — Cadastrar novos registros;
* **Read** — Consultar e visualizar registros;
* **Update** — Editar registros existentes;
* **Delete** — Excluir registros.

A aplicação foi desenvolvida seguindo o padrão **MVC**, buscando separar as responsabilidades da aplicação entre suas diferentes camadas e facilitar a organização, manutenção e evolução do sistema.

---

## 🎯 Objetivo

O principal objetivo deste projeto é aplicar, na prática, conceitos de desenvolvimento web utilizando tecnologias Microsoft, além de compreender o funcionamento da arquitetura MVC e da integração de uma aplicação com um banco de dados **SQL Server**.

O projeto também busca desenvolver conhecimentos relacionados a:

* Desenvolvimento de aplicações com **.NET Core**;
* Arquitetura **MVC**;
* Criação e manipulação de banco de dados;
* Operações CRUD;
* Integração com **SQL Server**;
* Utilização de ferramentas e frameworks da Microsoft;
* Organização e estruturação de um projeto de software;
* Aplicação de conceitos de design e interface.

---

## 🛠️ Tecnologias Utilizadas

As principais tecnologias e ferramentas utilizadas no desenvolvimento foram:

| Tecnologia                  | Utilização                                |
| --------------------------- | ----------------------------------------- |
| **C#**                      | Linguagem principal do projeto            |
| **.NET Core**               | Framework de desenvolvimento              |
| **ASP.NET Core MVC**        | Estrutura MVC da aplicação                |
| **Entity Framework Core**   | Comunicação com o banco de dados          |
| **SQL Server**              | Banco de dados                            |
| **Microsoft Visual Studio** | Ambiente de desenvolvimento               |
| **HTML5**                   | Estrutura das páginas                     |
| **CSS3**                    | Estilização e design                      |
| **Bootstrap**               | Componentes e responsividade da interface |
| **Razor**                   | Criação das Views                         |

---

## 🏗️ Arquitetura MVC

O projeto utiliza o padrão **MVC — Model, View e Controller**.

### 📦 Model

Responsável por representar os dados e as regras relacionadas às entidades do sistema.

Exemplo:

```text
Models/
 └── Restaurante.cs
```

O Model representa as informações que serão armazenadas e manipuladas no banco de dados.

---

### 👁️ View

Responsável pela interface apresentada ao usuário.

Exemplo:

```text
Views/
 └── Restaurante/
      ├── Index.cshtml
      ├── Create.cshtml
      ├── Edit.cshtml
      ├── Details.cshtml
      └── Delete.cshtml
```

As Views permitem que o usuário visualize, cadastre, altere e exclua informações.

---

### 🎮 Controller

Responsável por receber as requisições do usuário, processar as informações e realizar a comunicação entre **Model** e **View**.

Exemplo:

```text
Controllers/
 └── RestauranteController.cs
```

O Controller contém as ações responsáveis pelas operações do CRUD.

---

## 🗄️ Banco de Dados

O banco de dados utilizado no projeto é o **Microsoft SQL Server**.

A aplicação utiliza o **Entity Framework Core** para facilitar a comunicação entre o sistema e o banco de dados.

A estrutura básica pode ser representada da seguinte forma:

```text
Banco de Dados
      │
      ▼
 SQL Server
      │
      ▼
Entity Framework Core
      │
      ▼
    Model
      │
      ▼
  Controller
      │
      ▼
    View
      │
      ▼
    Usuário
```

---

## 🔄 Operações CRUD

O sistema possui as quatro operações fundamentais de persistência de dados.

### ➕ Create

Permite cadastrar um novo restaurante no sistema.

```text
Usuário → Formulário → Controller → Model → SQL Server
```

### 🔎 Read

Permite consultar e visualizar os restaurantes cadastrados.

```text
SQL Server → Model → Controller → View → Usuário
```

### ✏️ Update

Permite alterar informações de um restaurante já cadastrado.

```text
Usuário → View → Controller → Model → SQL Server
```

### 🗑️ Delete

Permite excluir um restaurante do banco de dados.

```text
Usuário → Controller → Model → SQL Server
```

---

## 🎨 Design e Interface

A interface foi desenvolvida buscando proporcionar uma experiência simples e organizada ao usuário.

Foram utilizados recursos de **HTML, CSS e Bootstrap**, permitindo a criação de uma interface responsiva e adequada para diferentes tamanhos de tela.

Entre os elementos da interface estão:

* Página inicial;
* Listagem de restaurantes;
* Formulário de cadastro;
* Formulário de edição;
* Visualização de detalhes;
* Confirmação de exclusão;
* Botões de navegação e ações do CRUD.

---

## 📁 Estrutura do Projeto

Uma estrutura básica do projeto MVC pode ser organizada da seguinte maneira:

```text
CRUD-Restaurante/
│
├── Controllers/
│   └── RestauranteController.cs
│
├── Models/
│   └── Restaurante.cs
│
├── Views/
│   ├── Restaurante/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   ├── Details.cshtml
│   │   └── Delete.cshtml
│   │
│   └── Shared/
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── images/
│
├── appsettings.json
├── Program.cs
└── README.md
```

---

## ⚙️ Configuração do Projeto

Para executar o projeto, é necessário possuir um ambiente de desenvolvimento compatível com **.NET**, além do **SQL Server**.

### 1. Clonar o projeto

```bash
git clone URL_DO_REPOSITORIO
```

### 2. Acessar a pasta

```bash
cd CRUD-Restaurante
```

### 3. Configurar o banco de dados

A connection string deve ser configurada no arquivo:

```text
appsettings.json
```

Exemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=RestauranteDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

> A connection string deve ser ajustada de acordo com a configuração do SQL Server utilizado no ambiente.

### 4. Restaurar as dependências

```bash
dotnet restore
```

### 5. Executar as migrations

Caso o projeto utilize migrations do Entity Framework Core:

```bash
dotnet ef database update
```

### 6. Executar a aplicação

```bash
dotnet run
```

Depois, acessar o endereço disponibilizado pelo ASP.NET Core no terminal.

---

## 🧪 Funcionalidades

O sistema foi desenvolvido com foco nas seguintes funcionalidades:

* [x] Cadastro de restaurante
* [x] Listagem de restaurantes
* [x] Visualização dos detalhes
* [x] Edição de restaurante
* [x] Exclusão de restaurante
* [x] Integração com SQL Server
* [x] Arquitetura MVC
* [x] Interface com HTML/CSS
* [x] Utilização de ferramentas e frameworks Microsoft

---

## 📖 Conceitos Aplicados

Durante o desenvolvimento foram trabalhados conceitos importantes de desenvolvimento de software, como:

* Arquitetura MVC;
* Programação orientada a objetos;
* Separação de responsabilidades;
* Rotas e Controllers;
* Models e Views;
* Entity Framework Core;
* Migrations;
* Persistência de dados;
* SQL Server;
* Operações CRUD;
* Desenvolvimento de interfaces;
* Organização de projetos .NET.

---

## 👨‍💻 Autor

**David Kaio**

Projeto desenvolvido **individualmente** como atividade acadêmica.

### Professor

**Wallace Oliveira**

---

## 📄 Observação

Este projeto foi desenvolvido exclusivamente para fins **acadêmicos e de aprendizado**, com o objetivo de praticar o desenvolvimento de aplicações utilizando **MVC, .NET Core, ferramentas Microsoft, SQL Server, Entity Framework Core e conceitos de design de interfaces**.

---

## ⭐ Considerações Finais

O desenvolvimento deste CRUD de Restaurante possibilitou colocar em prática conceitos fundamentais do desenvolvimento de aplicações web, principalmente a utilização do padrão **MVC** e a integração entre uma aplicação **.NET Core** e um banco de dados **SQL Server**.

A atividade também contribuiu para o entendimento da organização de um projeto, separação de responsabilidades e implementação das operações de cadastro, consulta, edição e exclusão de dados.
