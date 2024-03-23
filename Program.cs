using System.Security.Cryptography;


Console.Write("Digite a quantidade de lados o dado tem: ");
int Dado = int.Parse(Console.ReadLine()!);
Dado ++;
int res = RandomNumberGenerator.GetInt32(1,Dado);
Console.Write("O numero rolado foi... ");
Thread.Sleep(1500);
Console.Write(res);