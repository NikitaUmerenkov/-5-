// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
Console.Clear();
const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;
int[] myArr = GetArr(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine();
System.Console.WriteLine(SumNumber(myArr));


int[] GetArr(int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
  int[] arr = new int[SIZE];
  for (int i = 0; i < SIZE; i++)
  {
    arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE + 1);
  }
  foreach (var item in arr)
  {
    System.Console.Write(item + ",  ");
  }
  return arr;
}

string SumNumber(int[] arr)
{
  int count = 0;
  foreach (var item in arr)
  {
    if (item%2 != 0)
    count+=0;
  
  else
  
    count+=1;
  }
  return $"количество четных чисел:   {count}";
}
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
Console.Clear();
const int SIZE = 10;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 10;
int[] myArr = GetArr(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine();
System.Console.WriteLine(SumNumber(myArr));


int[] GetArr(int SIZE, int LEFT_RANGE, int RIGHT_RANGE)
{
  int[] arr = new int[SIZE];
  for (int i = 0; i < SIZE; i++)
  {
    arr[i] = new Random().Next(LEFT_RANGE, RIGHT_RANGE);
  }
  foreach (var item in arr)
  {
    System.Console.Write(item + ",  ");
  }
  return arr;
}


string SumNumber(int[] GetArr)
{
  int count = 0;
  for (int i = 0; i < GetArr.Length; i++)
  {
    if ((i %2) != 0)
    count += GetArr[i];
  }
  return $"сумма числел на нечетных позициях равна:   {count}";
  }
*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
Console.Clear();
const int size = 5;
const int leftrange = -9;
const int rightrange = 9;
double[] myArr = ArrRandomNum(size, leftrange, rightrange);
System.Console.WriteLine("[" + string.Join("; ", myArr) + "]");
System.Console.WriteLine(SumNumber(myArr));



double[] ArrRandomNum(int size, int leftrange, int rightrange)
{
  double[] tempArr = new double[size];
  Random rand = new Random();
  for (int i = 0; i < tempArr.Length; i++)
  {
    tempArr[i] = Math.Round(rand.Next(leftrange, rightrange + 1) + rand.NextDouble(), 2);
  }
  return tempArr;
}

string SumNumber(double[] ArrRandomNum)
{
  double count = 0;
  double min = ArrRandomNum[0];
  double max = min;
  for (int i = 1; i < ArrRandomNum.Length; i++)
  {
    if (max < ArrRandomNum[i])
    {
      max = ArrRandomNum[i];
    }
    else
    {
      if (min > ArrRandomNum[i])
      {
        min = ArrRandomNum[i];
      } 
    }
  }
  count = max - min;
  return $"разница макс и мин равна:   {max - min}";
  }
*/