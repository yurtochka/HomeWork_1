﻿// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();

WriteLine("Enter a number A: "); 
int A = Convert.ToInt32(ReadLine());
WriteLine("Enter a number B: "); 
int B = Convert.ToInt32(ReadLine());

if (B >= 0)
{
    int result = NatDeg(A, B);
    WriteLine();
    WriteLine($"-- {A} ^ {B} = {result} --");
}
else
{
    WriteLine();
    WriteLine("B - не натуральное число!");
}




int NatDeg(int a, int b)
{
    int x = 1;
    for (int i = 1; i <= b; i++)
    {
        x = a * x;
    } 
    return x;
}