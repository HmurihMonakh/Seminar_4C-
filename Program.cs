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


void RndMass(int[] Mass)
{
    int strange = Mass.Length;
    for (int index = 0; index < strange; index++)
    {
        Mass[index] = new Random().Next(0, 2);
        Console.Write($"{Mass[index]} ");
    }
}

//int num = Convert.ToInt32(Console.ReadLine());
//int []array= new int[num];
//RndMass(array);



//Console.WriteLine("Введите число: ");
//int x = Convert.ToInt32(Console.ReadLine());
int [] creat_mas (int x)
{
    int [] array = new int [x];
    for (int i = 0; i < x; i++)
        {
            array[i] = new Random().Next(0,2);
        }
    return array;
}
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
//PrintArray(creat_mas (x));


//Console.WriteLine("Введите число");
//int s = Convert.ToInt32(Console.ReadLine());
//string ss = Console.ReadLine();
//Console.WriteLine(s.Length);
//int count = 0;
//if (s == 0) count = 1;
/*
while(s != 0)

    {
        s = s / 10;
        count = count + 1;
        
    }   
//Console.Write(count);
*/
Console.WriteLine("Введите число");
int s = Convert.ToInt32(Console.ReadLine());
int num (int s)
    {
    int count = 0;
    if (s == 0) count = 1;
    while(s != 0)

        {
            s = s / 10;
            count = count + 1;
            
        }
    return count; 
    }       
Console.Write(num(s));


