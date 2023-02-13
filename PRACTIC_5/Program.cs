//  Программа 1. Задает массив заполненный случайными положительными 3-значными числами. 
//  Показывает количество чётных чисел в массиве.
 
OutInfo("__________________________________________________________");
OutInfo("№1 Задает массив заполненный случайными положительными 3-значными числами.");
OutInfo("Показывает количество чётных чисел в массиве.");
OutInfo("");
 
int [] array = GetRandomArray();
OutInfo($"Элементы массива {string.Join(" ", array)}");
 
int count = FindEvenArray(array);
OutInfo($"Количество четных чисел в массиве чисел {count}");
OutInfo("__________________________________________________________");
 
//  Программа 2. Задает одномерный массив, заполненный случайными числами. Находит сумму элементов, стоящих на нечётных позициях.
OutInfo("__________________________________________________________");
OutInfo("№2 Задает одномерный массив, заполненный случайными числами.");
OutInfo("Находит сумму элементов, стоящих на нечётных позициях.");
OutInfo("");
 
int [] array2 = GetRandomArray();
OutInfo($"Элементы массива {string.Join(" ", array2)}");
 
int summ = SummOddElemntArray(array2);
OutInfo($"Сумма нечетных элементов массива {summ}");
OutInfo("__________________________________________________________");
 
//  Программа 3.  Задает массив случайных вещественных чисел. Находит разницу между максимальным и минимальным элементов массива.
OutInfo("__________________________________________________________");
OutInfo("№3 Задает одномерный массив, заполненный случайными числами.");
OutInfo("Находит разницу между максимальным и минимальным элементов массива.");
OutInfo("");
 
double [] array3 = GetRandomArrayDouble();
OutInfo($"Элементы массива {string.Join(" ", array3)}");
OutInfo("");
 
double max = GetMaxElemntArray(array3);
double min = GetMinElemntArray(array3);
OutInfo("");
OutInfo($"Разница между максимальным и минимальным элементами массива = {max-min}");
OutInfo("__________________________________________________________");
 
void OutInfo(string info) //Выводит строковую информацию 
{
 Console.WriteLine(info);
}
 
int[] GetRandomArray() // Создает массив случайной длины(от 5 до 7) и заполняет его случайными трехзначными целыми числами
{
 Random rnd = new Random();
 int [] array = new int[rnd.Next(5,7)];
  for (int i=0; i < array.Length; i++)
 {
   array[i]=rnd.Next(100,999);
 } 
 return array;
}
 
double [] GetRandomArrayDouble() // Создает массив случайной длины(от 5 до 7) и заполняет его случайными числами в диапозоне от 1 до 100
{
 Random rnd = new Random();
 double [] array = new double [rnd.Next(5,7)];
  for (int i=0; i < array.Length; i++)
 {
   array[i]=rnd.NextDouble()*rnd.Next(1,100);
 } 
 return array;
}
 
int FindEvenArray(int[] array) // Проверка элементов массива на четность и поиск их кол-ва
{
  int count = 0;
  for (int i=0; i < array.Length; i++)
  {
   if (array[i] % 2 == 0)
    {
      count++;
    };
  }
 return count; 
}  
 
int SummOddElemntArray(int[] array) // Сумма нечетных элементов массива
{
  int summ = 0;
  Console.WriteLine();
  for (int i=0; i < array.Length; i=i+2)
  {
   summ = summ + array[i];
  }
 return summ; 
}
 
OutInfo("");
 
double GetMaxElemntArray(double[] array) // Максимальное значение массива
{
  double max = array[0];
  for (int i=0; i < array.Length; i++)
  {
   if (array[i] > max) 
    {
      max = array[i];
    }
  }
  Console.Write($"Максимальныйй элемент массива {max}"); 
 return max; 
}
 
double GetMinElemntArray(double[] array) // Минимальное значение массива
{
  double min = array[0];
  Console.WriteLine();
  for (int i=0; i < array.Length; i++)
  {
   if (array[i] < min) 
    {
      min = array[i];
    }
  }
 Console.Write($"Минимальный элемент массива {min}");
 return min; 
}