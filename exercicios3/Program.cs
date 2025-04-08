using System;

Console.WriteLine("Digite a sua nota 1 : "); 
float num1 = float.Parse(Console.ReadLine()); 

Console.WriteLine("Digite a sua nota 2 : "); 
float num2 = float.Parse(Console.ReadLine()); 

Console.WriteLine("Digite a sua nota 3 : "); 
float num3 = float.Parse(Console.ReadLine()); 

float media = (num1 + num2 + num3) / 3;

Console.WriteLine("A sua media de notas é: " + media);