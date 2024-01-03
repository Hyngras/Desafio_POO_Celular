# Desafio_POO_Celular
Este projeto foi criado para aplicar conceitos de orientação a objetos em C# no contexto de desenvolvimento .NET. O objetivo é modelar um sistema que representa celulares de duas marcas: Nokia e iPhone, utilizando abstração e herança.

Estrutura do Projeto:

1. Smartphone (Smartphone.cs): Classe abstrata que serve como modelo genérico para celulares. Contém propriedades `Numero`, `Modelo`, `IMEI` e `Memoria`, além de métodos como `Ligar`, `ReceberLigacao` e `InstalarAplicativo` (método abstrato).

2. Nokia (Nokia.cs): Classe filha de `Smartphone` que representa um celular Nokia. Implementa o método `InstalarAplicativo` de acordo com o comportamento específico do Nokia.

3. Iphone (Iphone.cs): Classe filha de `Smartphone` que representa um celular iPhone. Implementa o método `InstalarAplicativo` de acordo com o comportamento específico do iPhone.

4. Program (Program.cs): Arquivo de entrada que contém um exemplo simples de uso das classes `Nokia` e `Iphone` para realizar testes.

Executando o Projeto:

1. Clone o repositório: `https://github.com/Hyngras/Desafio_POO_Celular.git`
2. Abra o projeto em um ambiente de desenvolvimento .NET (Visual Studio).
3. Execute o programa para observar a saída no console, demonstrando a interação com celulares Nokia e iPhone.

