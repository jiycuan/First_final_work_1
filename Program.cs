﻿// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.

void FirstFinalWork1()
{
    string[] FirstArray = {":-)",";-)",":-(",":-))","^_^",">_<",":3"};
    string[] SecondArray = new string[FirstArray.Length];

    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length < 4)
        {
            SecondArray[i] = FirstArray[i];
        }
    }

    Console.Write("[ ");
    for (int i = 0; i < SecondArray.Length; i++)
    {
        Console.Write(SecondArray[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
FirstFinalWork1();

/* 
*/