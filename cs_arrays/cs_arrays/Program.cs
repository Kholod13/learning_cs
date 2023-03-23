using System;

//task1
/*
int[] arr = new int[10];
Random rand = new Random();

for (int i = 0;i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 30);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
int min = int.MaxValue, max = int.MinValue;

foreach (int i in arr)
{
    if (i < min)
    {
        min= i;
    }
    if (i > max)
    {
        max= i;
    }
}

Console.WriteLine($"min = {min}, max = {max}");
*/
//task2
/*
int[] arr = new int[5];
Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 20);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

bool p = false;
for(int i = 0;i < arr.Length; i++)
{
    for(int j = 0; j < arr.Length; j++)
    {
        if (arr[i] == arr[j] && i != j)
        {
            Console.Write("There are even elelments!");
            p = true;
            return;
        }
    }
}
if (p == false)
{
    Console.Write("There are not even elelments!");
}
*/
//task 3
/*
int[] arr = new int[10];
int counter = 0;
int arf = 0;

Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 30);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

for (int i = 0;i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        if (arr[i] % 2 == 0) {
            counter++;
            arf += arr[i];
        }
    }
}
arf = arf / counter;

Console.WriteLine($"Arifmetic number = {arf}");
*/
//task4
/*
int[] arr = new int[10];

Random rand = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(-30, 30);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

int[] arrCopy = new int[10];
int count = 0;

for (int i = 0;i < arr.Length; i++)
{
    if (arr[i] % 2 != 0 && arr[i] < 0)
    {
        arrCopy[count] = arr[i];
        count++;
    }
}

foreach(int i in arrCopy)
{
    if (i < 0) {
        Console.Write($"{i} ");
    }
}
*/
//task 5

const int size = 10;
int[] arr = new int[size];
int[] arr1 = new int[size];
int[] arr2 = new int[size];

Random rand = new Random();

for (int i = 0; i < size; i++)
{
    arr[i] = rand.Next(10, 30);
    arr1[i] = rand.Next(10, 30);
    arr2[i] = arr[i] + arr1[i];
}

Console.Write("arr1 = ");
foreach (var i in arr)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.Write("arr2 = ");
foreach (var i in arr1)
{
    Console.Write($"{i} ");
}
Console.WriteLine();

Console.Write("arr3 = ");
foreach (var i in arr2)
{
    Console.Write($"{i} ");
}
Console.WriteLine();