// See https://aka.ms/new-console-template for more information
//Задача 10
//Напишите програамму, которая на вход принимает трехзначное число, и на выходе  
//показывает вторую цифру этого числа. Через строку решать нельзя.
//756 -> 5
//982 -> 8
//918 -> 1
//https://github.com/profimars/C_SharpTask10
Console.WriteLine("Ведите трехзначное число");
int q = Convert.ToInt32(Console.ReadLine());
int q12 = q / 10;
Console.WriteLine("Первые две цифры трехзначного числа = " + q12);
int q2 = q12 % 10;
Console.WriteLine("вторая цифра трехзначного числа = " + q2);
