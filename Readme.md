\# 📊 Sistema de Controle e Cálculo de Comissões



Aplicativo desktop desenvolvido em \*\*C# com Windows Forms\*\* para automatizar o processamento de vendas, calcular comissões de equipe com base em regras de negócio específicas e exibir indicadores de desempenho comercial.



\## 🚀 Funcionalidades

\* \*\*Leitura de Dados via JSON:\*\* Importa automaticamente registros estruturados de vendas a partir de arquivos locais.

\* \*\*Regras de Negócio Dinâmicas:\*\* Aplica faixas de comissão automatizadas com base no valor de cada venda:

&#x20; \* Vendas abaixo de R$ 100,00: Sem comissão.

&#x20; \* Vendas entre R$ 100,00 e R$ 499,99: 1% de comissão.

&#x20; \* Vendas a partir de R$ 500,00: 5% de comissão.

\* \*\*Painel de Indicadores (Dashboard):\*\* Exibe o total de vendedores ativos, a quantidade total de vendas processadas e o valor global das comissões calculadas.

\* \*\*Exibição em Tabela (`DataGridView`):\*\* Organiza os resultados consolidados por vendedor com formatação monetária (R$).



\## 🛠️ Tecnologias Utilizadas

\* \*\*Linguagem:\*\* C# (.NET)

\* \*\*Interface Gráfica:\*\* Windows Forms (WinForms)

\* \*\*Manipulação de Dados:\*\* System.Text.Json (Deserialização de arquivos JSON)

\* \*\*Arquitetura:\*\* Organização em camadas/pastas separando Modelos, Serviços, Controladores e Views.



\## 📂 Estrutura do Projeto

```text

calculoComissao/

│

├── Controllers/         # Regras de fluxo e intermediação de dados

├── Data/                # Arquivos de dados (ex: Vendas.json)

├── Models/              # Classes de mapeamento e entidades de negócio

├── Services/            # Lógica de cálculo e processamento de comissões

└── Views/               # Telas e interfaces do Windows Forms

