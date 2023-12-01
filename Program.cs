﻿Console.WriteLine("+====Entrada Válida====+");

int NumeroDigitado = -1;
 
while (NumeroDigitado < 0 || NumeroDigitado > 9)
{
    Console.WriteLine("Digite um número de 1 a 9 ou 0 para encerrar a operação.");
        NumeroDigitado = Convert.ToInt32(Console.ReadLine());
}

 if (NumeroDigitado == 0)
 {
    Console.WriteLine("Operação encerrada por: usuário");
 }

 else
{
    Console.WriteLine($"Número selecionado = {NumeroDigitado}");
}