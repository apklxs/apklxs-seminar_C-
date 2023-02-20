ChoiceTasks(OutIntDigit("Введите 1 для выполнения Задачи №1"+"\n"+ "Веедите 2 для выполнения Задачи №2"+"\n"+ "Веедите 3 для выполнения Задачи №3"+"\n"+"№="));
 
void ChoiceTasks(int task)
{
 switch(task)
 {
    
    case 1:
        RunTask1();
        break;
 
    case 2:
        RunTask2(); 
        break;
    
    case 3:
        RunTask3(); 
        break;
    default:
        Console.WriteLine("Выход из программы");
        break;
 }
}
 
void RunTask1()
{
  Console.WriteLine("Программа заполняет двумерный массив размером mxn, случайными вещественными числами.");
  double[,] array = CreateTwoDimensionArrayRandomDouble(OutIntDigit("Введите количество строк массива m="), OutIntDigit("Введите количество строк массива n="));
  PrintTwoDimensionArrayDouble(array);
}
 
void  RunTask2()
{
  Console.WriteLine("Программа принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
  Random rnd = new Random();
  int qtyStr = rnd.Next(2,7);
  int qtyColmn = rnd.Next(2,7);
  int[,] array = CreateTwoDimensionArrayRandomInt(qtyStr, qtyColmn);
  FindElementTwoDimensionsArray(array,OutIntDigit("Угадайте целое число содержащееся в массиве "+"\n"+"* подсказка число больше 1 но меньше 100 "+"\n"+"ваше число=" ));
  PrintTwoDimensionArrayInt(array);
}
 
void  RunTask3()
{
  Console.WriteLine("Программа в двумернном массиве из целых чисел находится среднее арифметическое элементов в каждом столбце.");
  Random rnd = new Random();
  int qtyStr = rnd.Next(2,7);
  int qtyColmn = rnd.Next(2,7);
  int[,] array = CreateTwoDimensionArrayRandomInt(qtyStr, qtyColmn);
  PrintTwoDimensionArrayInt(array);
  SummAverageColumnTwoDimensionsArray(array);
  
}
 
int OutIntDigit(string info)
{
 int i;   
 Console.Write(info);
 
 while (!int.TryParse(Console.ReadLine(), out i))
 {
  Console.WriteLine("Вы ввели не целое число повторите еще раз");
 }
 
 return i;
}
 
int GeneratePlusMinusDigit()
{
  Random rnd = new Random();
  int check = ((rnd.Next(1,11)%2) == 0 ? 1:-1);
  return check;
} 
 
void FindElementTwoDimensionsArray(int[,] array, int digit)
{
 int indexyes = 0, indexno=0;
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
       if (digit == array[i,j])
       {
        indexyes = indexyes + 1;
        Console.WriteLine($"есть число {digit} с номером индекса [{i+1},{j+1}]");
       }
       else
       {
         indexno = indexno + 1;
       }
    }
    if (indexno == array.GetLength(0)*array.GetLength(1))
    {
      Console.WriteLine($"число не содержится в массиве");
    }
  }
 }
 
 void SummAverageColumnTwoDimensionsArray(int[,] array)
{
 double summaverage = 0;
 int i,j;
  
  for(i = 0; i <array.GetLength(1); i++)
   {
    for(j = 0; j < array.GetLength(0); j++)
    {
     summaverage = summaverage+array[j,i];
    }
   Console.Write($"sumAvr {summaverage/array.GetLength(0)} ");
   summaverage = 0;
   }
}
 
double [,] CreateTwoDimensionArrayRandomDouble(int m, int n)
 {
 double[,] array = new double[m,n];
 Random rnd = new Random();
 
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
       array[i,j] = Math.Round(rnd.NextDouble()*GeneratePlusMinusDigit()*10,2);
    }
  }
 
  return array;
 }
 
 int[,] CreateTwoDimensionArrayRandomInt(int m, int n)
 {
  Random rnd = new Random();
  int[,] array = new int[m,n];
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
       array[i,j] = rnd.Next(1,99);
    }
  }  
  return array;
 } 
 
 void PrintTwoDimensionArrayDouble(double[,] array)
 {
 for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
       if (array[i,j]>0)
       {
        Console.Write($" {array[i,j]} ");
       }
       else
       {
        Console.Write($"{array[i,j]} ");
       }
    }
    Console.WriteLine();
  }
 }
 
void PrintTwoDimensionArrayInt(int[,] array)
 {
 for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"   {array[i,j]}    ");   
    }
    Console.WriteLine();
  }
 }
