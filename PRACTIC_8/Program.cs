ChoiceTasks(OutIntDigit(@"Введите 1 для выполнения Задачи №1"+"\n"+ "Веедите 2 для выполнения Задачи №2"+"\n"+ 
"Веедите 3 для выполнения Задачи №3"+"\n"+"Веедите 4 для выполнения Задачи №4"+"\n"+"№="));


void ChoiceTasks(int task)
{
 switch(task)
 {
    
    case 1:
        RunTask1();
        break;
 
    case 2:
        Runtask2(); 
        break;
    
    case 3:
        RunTask3(); 
        break;
    
    case 4:
        RunTask4(); 
        break;
    default:
        Console.WriteLine("Выход из программы");
        break;
 }
}
//Программа №4 Формирует и выводит трёхмерный массив из неповторяющихся двузначных чисел. 
//Размер массива вводит пользователь

void RunTask4()
{
Console.WriteLine("Программа №4 Формирует трёхмерный массив размера MхNхL из неповторяющихся двузначных чисел. Выводит получившийся массив.");
Console.WriteLine("Внимание !!! т.к. массив заполняется двузначными уникальными числами, количество элементов З-х мерного массива не может превышать 90 элементов");
int lengthX= OutIntDigit("Введите количество элементов 3D массива по оси y= ");
int lengthY= OutIntDigit("Введите количество элементов 3D массива по оси x= ");
int lengthZ= OutIntDigit("Введите количество элементов 3D массива по оси z= ");
 
if (CheckExists3DArray(lengthX, lengthY, lengthZ) == true)
 {
  int[] array = CreateArrayRandomInt(lengthX*lengthY*lengthZ);
  int[] arrayUniq = CreateArrayUniqElement(array);
  int [,,] array3D = Create3DArrayInt(arrayUniq, lengthX, lengthY, lengthZ);
  PrintArrayInt(arrayUniq);
  Print3DArrayInt(array3D);
 }
else
 {
  Console.WriteLine("Перезапустите программу");
 }
}
 
//Программа №3 Находит и выводит  произведение двух матриц, размер матриц вводит пользователь, элементы матриц заполняются случайно.
void RunTask3()
{
Console.WriteLine("Программа №3 Находит и выводит произведение двух матриц, размер матриц вводит пользователь, элементы матриц заполняются случайно.");
Console.WriteLine("Внимание. Перемножение матриц возможно только вида lxm и mxn т.е. кол-во столбцов первой матрицы должно быть равно кол-ву строк второй");
 
int lengthY= OutIntDigit("Введите количество строк первой матрицы(массива) = ");
int lengthX= OutIntDigit("Введите количество столбцов первой матрицы(массива) = ");
int[,] arrayMatrix1 = Create2DArrayInt(lengthY,lengthX); 
int checklengthXmatrix1=lengthX;
lengthY= OutIntDigit("Введите количество срок второй матрицы(массива) = ");
lengthX= OutIntDigit("Введите количество столбцов второй матрицы(массива) = ");
int [,] arrayMatrix2 = Create2DArrayInt(lengthY,lengthX);
int checklengthYmatrix2=lengthY;
if (checklengthXmatrix1 == checklengthYmatrix2 )
 { 
  int[,] arrayOut = MultiplicationTwo2DArrayInt(arrayMatrix1,arrayMatrix2); 
  Print2DArrayInt(arrayOut);
 }
else
 {
  Console.WriteLine("Матрицы введенных размеров нельзя перемножать,кол-во столбцов первой матрицы должно быть равно кол-ву строк второй");
 }
}
 
//Программа №1 Упорядочит по убыванию элементы каждой строки двумерного массива. Размер массива вводит пользователь. 
//Элементы массива заполняются случайно.
void RunTask1()
{
Console.WriteLine("Упорядочит по убыванию элементы каждой строки двумерного массива. Размер массива вводит пользователь.");
Console.WriteLine("Элементы массива заполняются случайно.");
int lengthX= OutIntDigit("Введите количество строк  массива =  ");
int lengthY= OutIntDigit("Введите количество столбцов массива = ");
int[,] array = Create2DArrayInt(lengthY,lengthX);
Print2DArrayInt(array);
int[,] arrayout = SortedArrayMaxtoMin2D(array);
Console.WriteLine();
Print2DArrayInt(arrayout);
}
 
//Программа №2 Задает двумерный массив, находит строку с наименьшей суммой элементов и сообщает номер этой строки. 
void Runtask2()
{
Console.WriteLine("Задает двумерный массив, находит строку с наименьшей суммой элементов и сообщает номер этой строки.");
Console.WriteLine("Элементы массива заполняются случайно.");   
int lengthX= OutIntDigit("Введите количество строк  массива =  ");
int lengthY= OutIntDigit("Введите количество столбцов массива = ");
int[,] array2d = Create2DArrayInt(lengthX,lengthY); 
Print2DArrayInt(array2d);
int [] array = SummStringElement2DarrayToArray(array2d); 
Console.WriteLine($"Номер строки с максимальгной сумой элементов №{OutIndexMaxElementArray(array)+1}");  
}


int [] SummStringElement2DarrayToArray(int [,] array) 
{
int [] arrayout = new int[array.GetLength(0)];
int summ=0;
for(int i = 0; i < array.GetLength(0); i++)
 {    
  for(int j = 0; j < array.GetLength(1); j++)
  {    
   summ = summ + array[i,j];
  }
 arrayout[i] = summ;
 Console.WriteLine($"Сумма строки №{i+1}={arrayout[i]}");
 summ = 0;
 }
return arrayout;
}

int OutIndexMaxElementArray(int [] array) 
{
  int max = array[0], maxi = 0;
  for(int i = 0; i < array.Length; i++)
  {    
   if (max < array[i])
    {
     max = array[i];
     maxi=i;
    }
  }
 //Console.WriteLine($" a[{maxi}]={array[maxi]}");
return maxi;
}


int [,] SortedArrayMaxtoMin2D(int [,] array) 
{
for(int j = 0; j < array.GetLength(0); j++)
{    
for(int count = 0; count < array.GetLength(1); count++)
{    
 int tempi = count;
 int max = array[j,count];
 int temp = array[j,count]; 
  for(int i = count; i < array.GetLength(1); i++)
   {
    if (max < array[j,i])
    {
     max = array[j,i];
     tempi = i;
    }
   }
  array[j,count]=max;
  array[j,tempi]=temp;
 }
}
return array;
}
 
  
bool CheckExists3DArray(int lengthX, int lengthY, int lengthZ)
 { 
  bool check= true;
  if (lengthX*lengthY*lengthZ > 90)
   {
     check = false;
     Console.WriteLine($"Массив с количеством элементов {lengthX*lengthY*lengthZ } не может содержать только уникальные двухзначные числа" ); 
   }
  return check;
 } 
 
int[] CreateArrayRandomInt(int n)
 {
  Random rnd = new Random();
  int[] array = new int[n];
 
  for(int j = 0; j < array.Length; j++)
   {
     array[j] = rnd.Next(10,100);
     //Console.Write($" {array[j]} ");
   }
    Console.WriteLine();
   return array;
 } 
 
 int[,,] Create3DArrayInt(int[] array, int lengthX, int lengthY, int lengthZ)
 {
  int count = 0;
  int[,,] arrayout = new int[lengthX,lengthY,lengthZ];
 
  for(int i = 0; i < arrayout.GetLength(0); i++)
  {
   for(int j = 0; j < arrayout.GetLength(1); j++)
   {
    for(int k = 0; k < arrayout.GetLength(2); k++)
    {
     arrayout[i,j,k] = array[count];
     //Console.Write($" arrayout[{i},{j},{k}]{arrayout[i,j,k]}= array[{count}]{array[count]} ");
     count++;
    }
   }
  }
    Console.WriteLine();
   return arrayout;
 } 
 
int[,] Create2DArrayInt(int lengthY, int lengthX) 
 {
  int[,] arrayout = new int[lengthY,lengthX];
  Random rnd = new Random();
  
  for(int i = 0; i < arrayout.GetLength(0); i++)
  {
   for(int j = 0; j < arrayout.GetLength(1); j++)
   {
    arrayout[i,j] = rnd.Next(1,10);
   }
  }
   return arrayout;
 } 
 
 int[,] MultiplicationTwo2DArrayInt(int[,] matrix1, int[,] matrix2) 
 {
  int[,] arrayout = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    
  for(int i = 0; i < arrayout.GetLength(0); i++)
  {
   for(int j = 0; j < arrayout.GetLength(1); j++)
   {
     for(int k = 0; k < arrayout.GetLength(0); k++)
     {
     arrayout[i,j] += matrix1[i,k]*matrix2[k,j];
     }
   }
    Console.WriteLine();
  }
   return arrayout;
 } 
 
int[] CreateArrayUniqElement(int [] array)
{
 Random rnd = new Random(); 
 int indexRepeat=0;
 for(int j = 0; j < array.Length; j++)
   { 
    for(int i = 0; i < array.Length-j-1; i++)
     { 
     if (array[j] == array[i+j+1])
      {
       Console.Write($" повторный элемент {array[j]} ");
       array[j] = rnd.Next(10,100);
       indexRepeat++;
       Console.Write($" заменен на {array[j]} ");
       Console.WriteLine();
      }
     }
   }
   if (indexRepeat>0)
     {
        array = CreateArrayUniqElement(array);
        //Console.WriteLine($"были повторы в количестве {indexRepeat}");
     }
 
  return array;
 }  
 
 void Print3DArrayInt(int[,,] array)
 {
  
  for(int i = 0; i < array.GetLength(0); i++)
  {
   for(int j = 0; j < array.GetLength(1); j++)
   {
    for(int k = 0; k < array.GetLength(2); k++)
    {
      Console.WriteLine($" {array[i,j,k]} ({i},{j},{k})");
    }
   }
  }
 }
 
void Print2DArrayInt(int[,] array)
 {
  
  for(int i = 0; i < array.GetLength(0); i++)
  {
   for(int j = 0; j < array.GetLength(1); j++)
   {
     Console.Write($"{array[i,j]} ");
   }
     Console.WriteLine();
  }
 }
 
 
 void PrintArrayInt(int[] array)
 {
 for(int i = 0; i < array.Length; i++)
  {
     Console.Write($" {array[i]}");
  }
    Console.WriteLine();
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