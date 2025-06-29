# Sistema de Pedidos com Notificações - Aplicando SOLID em C#

Este é um projeto simples desenvolvido em C# com o objetivo de demonstrar a aplicação prática dos **5 princípios SOLID** em um sistema de pedidos com envio de notificações por diferentes canais (e-mail ou SMS).

---

## 📦 Funcionalidades

- Registrar pedidos com produto e valor
- Enviar notificação automaticamente após registro
- Suporte a múltiplas estratégias de notificação (Email, SMS)
- Estrutura desacoplada, extensível e fácil de manter

---

## 🔧 Tecnologias

- C#
- .NET (console app simples)
- Orientação a Objetos

---

## 🧱 Princípios SOLID Aplicados

### 1. SRP - Single Responsibility Principle
Cada classe tem uma responsabilidade única:
- `PedidoService` → registra pedidos
- `NotificacaoEmail`, `NotificacaoSMS` → cuidam do envio
- `Pedido` → representa os dados do pedido

### 2. OCP - Open/Closed Principle
Novos tipos de pedidos ou notificações podem ser adicionados **sem alterar código existente**, apenas estendendo interfaces.

### 3. LSP - Liskov Substitution Principle
Subclasses como `PedidoComum` funcionam onde `Pedido` é esperado, sem alterar comportamento ou quebrar lógica.

### 4. ISP - Interface Segregation Principle
A interface `INotificacao` é simples e enxuta. Nenhuma classe é forçada a implementar métodos desnecessários.

### 5. DIP - Dependency Inversion Principle
`PedidoService` depende da abstração `INotificacao`, e não de implementações concretas como `NotificacaoEmail`.

---

## 🚀 Como usar

1. Clone o repositório:
```bash
git clone https://github.com/afrain/solid-aplicado-sistema-de-pedidos.git
```
