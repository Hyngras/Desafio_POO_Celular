﻿using DesafioPOO.Componentes;
using System;

class Program
{
    static void Main()
    {
        // Criando uma instância de Nokia
        var nokia = new Nokia("123456789", "Nokia 8", "ABC123", 64);

        // Testando métodos da classe Nokia
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando uma instância de Iphone
        var iphone = new Iphone("987654321", "iPhone 12", "XYZ789", 128);

        // Testando métodos da classe Iphone
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.ReadLine();
    }
}