
# 🏦 Fintech Bank — Sistema Bancário com Testes Unitários

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)
![C#](https://img.shields.io/badge/C%23-Linguagem-239120?logo=csharp)
![xUnit](https://img.shields.io/badge/Testes-xUnit-blue)
![GitHub](https://img.shields.io/badge/GitHub-Projeto_Colaborativo-181717?logo=github)
![License](https://img.shields.io/badge/License-MIT-green)

## 📖 Sobre o projeto

O **Fintech Bank** é um projeto acadêmico desenvolvido em **C# com .NET 10**, com foco na implementação de regras de negócio bancárias e na realização de testes unitários automatizados utilizando o framework **xUnit**.

O projeto simula operações relacionadas à conta corrente e à concessão de empréstimos, permitindo validar diferentes cenários financeiros.

O objetivo principal é aplicar conhecimentos de programação orientada a objetos, lógica de programação, testes de software e desenvolvimento colaborativo utilizando Git e GitHub.

> **Observação:** este projeto é uma simulação acadêmica de regras bancárias, não um sistema financeiro real.

---

## 🎯 Objetivos do projeto

- Desenvolver funcionalidades bancárias utilizando C#.
- Aplicar conceitos de programação orientada a objetos.
- Implementar regras de negócio.
- Criar testes unitários automatizados com xUnit.
- Validar diferentes cenários utilizando testes parametrizados.
- Praticar organização de projetos .NET.
- Utilizar Git e GitHub para colaboração em equipe.
- Documentar o projeto seguindo boas práticas.

---

## 🚀 Funcionalidades implementadas

### 💳 1. Conta Corrente

A classe `ContaCorrenteService` contém métodos responsáveis por calcular taxas de manutenção e verificar a disponibilidade de saldo para saques.

#### Cálculo de taxa de manutenção

As taxas são determinadas pelo saldo disponível e pela categoria do cliente.

| Condição | Taxa de manutenção |
|---|---|
| Cliente especial | R$ 0,00 |
| Saldo igual ou superior a R$ 5.000,00 | R$ 0,00 |
| Saldo de R$ 1.000,00 até R$ 4.999,99 | R$ 12,50 |
| Saldo inferior a R$ 1.000,00 | R$ 25,00 |

**Método utilizado:**

`CalcularTaxaManutencao()`

#### Validação de saques

O sistema verifica se o cliente possui saldo suficiente para realizar um saque, considerando o limite disponível do cheque especial.

**Regra aplicada:**

```text
Valor máximo para saque = Saldo + Limite do cheque especial
```

**Exemplo:**

- Saldo disponível: R$ 1.000,00
- Limite do cheque especial: R$ 500,00
- Valor solicitado: R$ 1.200,00

**Resultado:** saque permitido.

Se o saque solicitado fosse de R$ 1.600,00, a operação seria recusada.

**Método utilizado:**

`PodeRealizarSaque()`

---

### 💰 2. Empréstimos

A classe `EmprestimoService` implementa regras para cálculo de parcelas e aprovação de empréstimos.

#### Cálculo de parcelas

O sistema calcula o valor das parcelas considerando o valor solicitado, a quantidade de parcelas e o score de crédito.

| Score de crédito | Juros aplicados |
|---|---|
| Igual ou superior a 700 | 5% |
| De 500 até 699 | 12% |
| Inferior a 500 | 20% |

Os juros são aplicados sobre o valor total do empréstimo, que depois é dividido pela quantidade de parcelas.

**Método utilizado:**

`CalcularValorParcela()`

**Exemplo:**

```text
Valor do empréstimo: R$ 10.000,00
Score de crédito: 800
Juros: 5%
Quantidade de parcelas: 10

Valor total com juros: R$ 10.500,00
Valor de cada parcela: R$ 1.050,00
```

#### Aprovação de empréstimos

A aprovação considera o limite de comprometimento de até 30% da renda mensal do cliente.

**Regra aplicada:**

```text
Parcela máxima permitida = Renda mensal × 30%
```

**Exemplo:**

```text
Renda mensal: R$ 5.000,00
Limite de comprometimento: R$ 1.500,00

Parcela de R$ 1.500,00 → Aprovada
Parcela de R$ 1.600,00 → Reprovada
```

**Método utilizado:**

`AprovarEmprestimo()`

---

## 🛠️ Tecnologias utilizadas

| Tecnologia | Finalidade |
|---|---|
| C# | Linguagem de programação |
| .NET 10 | Plataforma de desenvolvimento |
| xUnit | Framework de testes unitários |
| Microsoft.NET.Test.Sdk | Execução de testes |
| Coverlet | Coleta de cobertura dos testes |
| Git | Controle de versão |
| GitHub | Hospedagem e colaboração |
| Visual Studio Code | Ambiente de desenvolvimento |

---

## 📂 Estrutura do projeto

```text
fintech-bank-xunit/
│
├── FintechBank.App/
│   ├── ContaCorrenteService.cs
│   ├── EmprestimoService.cs
│   ├── Program.cs
│   └── FintechBank.App.csproj
│
├── FintechBank.Tests/
│   ├── ContaCorrenteServiceTests.cs
│   ├── EmprestimoServiceTests.cs
│   └── FintechBank.Tests.csproj
│
├── FintechBank.slnx
├── .gitignore
└── LICENSE
```

### Organização

**FintechBank.App**

Contém a aplicação principal e as classes responsáveis pela implementação das regras de negócio.

**FintechBank.Tests**

Contém os testes automatizados para verificar o comportamento dos métodos implementados.

**FintechBank.slnx**

Arquivo que organiza os projetos da solução .NET.

---

## 🧪 Testes unitários com xUnit

Os testes automatizados verificam se os métodos retornam os resultados esperados para diferentes entradas.

O framework utilizado é o **xUnit**, que permite desenvolver testes de forma organizada e reutilizável.

### Testes de Conta Corrente

Arquivo:

`ContaCorrenteServiceTests.cs`

**Cenários implementados:**

1. Cliente com saldo elevado isento de taxa.
2. Cliente especial isento de taxa.
3. Cliente com saldo intermediário pagando R$ 12,50.
4. Cliente com saldo inferior a R$ 1.000,00 pagando R$ 25,00.
5. Saque permitido dentro do limite disponível.
6. Saque recusado por ultrapassar o limite disponível.

### Testes de Empréstimos

Arquivo:

`EmprestimoServiceTests.cs`

**Cenários implementados:**

1. Aplicação de juros de 5% para score elevado.
2. Aplicação de juros de 12% para score intermediário.
3. Aplicação de juros de 20% para score baixo.
4. Aprovação de empréstimo dentro do limite de renda.
5. Reprovação de empréstimo acima do limite permitido.

### Resumo

| Módulo | Cenários de teste |
|---|---:|
| Conta Corrente | 6 |
| Empréstimos | 5 |
| **Total** | **11** |

Os 11 cenários estão distribuídos em quatro métodos de teste parametrizados.

### Conceitos de testes utilizados

**[Theory]**

Permite executar o mesmo teste utilizando diferentes conjuntos de dados.

**[InlineData]**

Fornece os valores de entrada e o resultado esperado para cada cenário.

**Assert.Equal()**

Compara o resultado obtido com o resultado esperado.

---

## ⚙️ Como executar o projeto

### Pré-requisitos

Antes de iniciar, é necessário possuir:

- .NET SDK 10 instalado.
- Git instalado.
- Visual Studio Code ou IDE compatível.

### 1. Clonar o repositório

Abra o terminal e execute:

```bash
git clone https://github.com/M4RCOSx15/fintech-bank-xunit.git
```

### 2. Acessar a pasta do projeto

```bash
cd fintech-bank-xunit
```

### 3. Restaurar as dependências

```bash
dotnet restore
```

### 4. Compilar a solução

```bash
dotnet build
```

### 5. Executar os testes unitários

```bash
dotnet test
```

O comando executa os testes configurados na solução.

### 6. Executar a aplicação principal

```bash
dotnet run --project FintechBank.App
```

**Observação:** a aplicação de console ainda contém uma mensagem inicial de exemplo. As funcionalidades bancárias são implementadas nas classes de serviço e verificadas pelos testes unitários.

---

## 📊 Cobertura de testes

O projeto possui o pacote **Coverlet Collector**, utilizado para coletar dados de cobertura de código.

Para executar os testes com coleta de cobertura:

```bash
dotnet test --collect:"XPlat Code Coverage"
```

Os resultados podem ser utilizados para identificar quais partes do código foram executadas durante os testes.

A presença do Coverlet não significa, por si só, que toda a aplicação esteja coberta por testes.

---

## 🧠 Conceitos aplicados

Durante o desenvolvimento foram utilizados conceitos importantes da engenharia de software:

- **Programação orientada a objetos:** organização das funcionalidades em classes e métodos.
- **Regras de negócio:** implementação de condições para operações bancárias.
- **Testes unitários:** validação isolada do comportamento dos métodos.
- **Testes parametrizados:** execução de vários cenários com um único método de teste.
- **Separação de responsabilidades:** organização do código de aplicação e dos testes em projetos distintos.
- **Versionamento:** acompanhamento das alterações com Git.
- **Colaboração:** desenvolvimento em equipe utilizando GitHub.
- **Documentação:** apresentação da estrutura e das instruções de utilização do projeto.

---

## 🔮 Possíveis melhorias futuras

O projeto pode evoluir com a implementação de novas funcionalidades:

- Cadastro de clientes e contas.
- Depósitos e transferências.
- Histórico de movimentações bancárias.
- Validação de valores negativos.
- Tratamento de divisão por zero no cálculo de parcelas.
- Novos cenários de teste.
- Persistência de dados utilizando banco de dados.
- Desenvolvimento de uma API REST.
- Integração contínua com GitHub Actions.

Essas funcionalidades são sugestões de evolução e ainda não fazem parte da implementação documentada.

---

## 👥 Colaboradores

Projeto acadêmico desenvolvido de forma colaborativa.

| Colaborador | GitHub |
|---|---|
| Miguel Alchaar | [@miguelalchaar](https://github.com/miguelalchaar) |
| Vinicius | [@Viniciushdb](https://github.com/Viniciushdb) |
| Marcos Gabriel | [@M4RCOSx15](https://github.com/M4RCOSx15) |
| Michele Carvalho | [@MicheleUai](https://github.com/MicheleUai) |

### 🤖 Ferramentas de apoio

O histórico de contribuições do GitHub também apresenta o **Cursor Agent**, uma ferramenta de inteligência artificial para assistência no desenvolvimento de software.

---

## 📚 Referências

- [.NET — Microsoft](https://dotnet.microsoft.com/)
- [Documentação C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- [xUnit](https://xunit.net/)
- [Git](https://git-scm.com/)
- [GitHub Docs](https://docs.github.com/)

---

## 📄 Licença

Este projeto está disponibilizado sob a **Licença MIT**.

Consulte o arquivo [LICENSE](LICENSE) para mais informações.

---

### 🏦 Fintech Bank

**Projeto acadêmico de desenvolvimento C#, regras de negócio bancárias e testes unitários com xUnit.**

Desenvolvido com foco em aprendizagem, qualidade de software e colaboração em equipe.
