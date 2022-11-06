/*
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int[] factor(int N)
{

    int[] myArray = new int[N];
    int F = 1;
    for (int i = 1; i <= N; i++)
    {
        F = F * i;
        myArray[i - 1] = F;
    }
    return myArray;
}
PrintArray(factor(N));*/


//Решение в группах задач:
//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]


// void RndMass(int[] Mass)
// {
//     int strange = Mass.Length;
//     for (int index = 0; index < strange; index++)
//     {
//         Mass[index] = new Random().Next(0, 2);
//         Console.Write($"{Mass[index]} ");
//     }
// }

//int num = Convert.ToInt32(Console.ReadLine());
//int []array= new int[num];
//RndMass(array);



//Console.WriteLine("Введите число: ");
//int x = Convert.ToInt32(Console.ReadLine());
// int [] creat_mas (int x)
// {
//     int [] array = new int [x];
//     for (int i = 0; i < x; i++)
//         {
//             array[i] = new Random().Next(0,2);
//         }
//     return array;
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//         {
//             Console.Write($"{col[position]} ");
//             position++;
//         }
// }
//PrintArray(creat_mas (x));


//Console.WriteLine("Введите число");
//int s = Convert.ToInt32(Console.ReadLine());
//string ss = Console.ReadLine();
//Console.WriteLine(s.Length);
//int count = 0;
//if (s == 0) count = 1;

// while(s != 0)

//     {
//         s = s / 10;
//         count = count + 1;

//     }   
// //Console.Write(count);

// Console.WriteLine("Введите число");
// int s = Convert.ToInt32(Console.ReadLine());
// int num (int s)
//     {
//     int count = 0;
//     if (s == 0) count = 1;
//     while(s != 0)

//         {
//             s = s / 10;
//             count = count + 1;

//         }
//     return count; 
//     }       
// Console.Write(num(s));



// **Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А

// Console.WriteLine("Введтье число:");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSum(A)}");

// int GetSum(int limit)
// {
//     int sum = 0;
//     for (int i = 0; i < limit; i++)
//     {
//         sum = sum +1;
//     }
//     return sum;
// }





// ** Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 8945 -> 5

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Количество цифр в числе равно {CountNumber(number)}");

// */*через строку

// **int CountNumber = strnumber.Length;
// string number = Console.ReadLine()!
// if(number[0]== '-') Console.WriteLine("Введите число: ");
// else Console.WriteLine($"Количество цифр в числе {number} == {number.Lenght}");


// int CountNumber(int number)
// {
//     int count = 0;
//     do
//     {
//         number = number / 10;
//         count++;
//     }
//     while (number > 0);
//     return count;
// }

// **Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N
// 4 -> 24 
// 5-> 120

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"-> {MultNumbers(number)}");
int MultNumbers(int number)
{
    int result = 0;
    for (int i = 0; i < number; i++)
    {
        result = result + 1;
    }
    return result;
}

// **Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// //[1,0,1,1,0,1,0,0];

int[] arr = new int[8];
FillArray(arr.Length);
Console.WriteLine("[");
Console.WriteLine(String.Join(" | ", arr));
Console.WriteLine("]");
void FillArray(int size)
{
    for (int i = 0; i < size; i++)
    {
        int number = new Random().Next(0, 2);
    }
}

// **
// ViewArray(arr);
// void ViewArray(int[] arr)
// {   
//     Console.Write("");
//     for (int i = 0; i < arr.Length -1; i++)
//     {

//     }
// }
// **



// *** второй вариант

int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }
    return result;
}
