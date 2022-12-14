bool isWork = true;
Console.WriteLine("Сделайте выбор task:");
while (isWork)
{
	string command = Console.ReadLine()!;

	switch (command)
	{
		case "task1": Task1(); break;
		case "task2": Task2(); break;
		case "task3": Task3(); break;
		case "exit": isWork = false; break;
	}
}

int ReadLineInt(string p) // Ввод числа int
{
    Console.WriteLine($"Введите {p}");
    int n = int.Parse(Console.ReadLine()!);
    return n;
}

double [,] MadeArray(int length, int height) // Создание двумерного массива double
{
    double [,] array = new double [length,height];
    return array;
}

int [,] MadeArrayInt(int length, int height) // Создание двумерного массива int
{
    int [,] array = new int [length,height];
    return array;
}
void FillDimensionInt(int [,] massiv) //Заполнение массива int
{  Random r = new Random();
   for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)

        massiv[j, i ] = (r.Next(1,100));
    }
}
void GetArrayAsStringInt(int [,] massive)//Вывод массива int
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for( int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]} ");
        }
        Console.WriteLine();
    }
}

void GetArrayAsStringIntOne(int [] massive)//Вывод массива int
{
    for (int i = 0; i < massive.Length; i++)
    {
        {
            Console.Write($"{massive[i]}  ");
        }
    }
}



void FillDimension(double[,] massiv) // Заполнение массива double
{  Random r = new Random();
   for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)

        massiv[j, i ] = Math.Round(r.NextDouble()*100,2);
    }
}

void GetArrayAsString(double[,] massive)//Вывод массива double
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for( int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]} ");
        }
        Console.WriteLine();
    }
}


void Task1() //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

{
    double [,] array = MadeArray(ReadLineInt("длинну массива"),ReadLineInt("высоту массива"));
    FillDimension(array);
    GetArrayAsString(array);
}

void Task2() //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
{
    double SearchElement(double [,] array,
                         int i, 
                         int j)

{      double element = -1; 

       if(i < array.GetLength(0) && j < array.GetLength(1))                
       { 
          element = array[i,j];
       }
       return element;
    
                               
 }  
                
       double [,] array = MadeArray(ReadLineInt("длинну массива"),ReadLineInt("высоту массива"));
       FillDimension(array);
       GetArrayAsString(array);
       double element = SearchElement(array,ReadLineInt("координаты по длинне массива"),ReadLineInt("координаты по высоте массива"));
       Console.WriteLine($"Вы выбрали число {element}");

}   
	



void Task3() //Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
{
    int [] Amean (int [,] array)
    { 
      int [] amean = new int [array.GetLength(0)];
      for(int i = 0; i < array.GetLength(0); i++)
        {
           for(int j = 0; j < array.GetLength(1); j++)
           {
            amean[i] = amean[i] + array[j,i];
           }
        }
        for(int i = 0; i < amean.Length; i++)
       {
         amean[i] = amean [i]/amean.Length;
       }
       return amean;
     }
    
    int [,] array = MadeArrayInt(ReadLineInt("длинну массива"),ReadLineInt("высоту массива"));
    FillDimensionInt(array);
    GetArrayAsStringInt(array);
    System.Console.WriteLine();
    GetArrayAsStringIntOne(Amean(array));
}