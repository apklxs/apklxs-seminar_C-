ChoiceTasks(OutIntDigit("Введите 1 для выполнения Задачи №1 или 2 для выполнения Задачи №2 №="));
 
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
    
    default:
        Console.WriteLine("Выход из программы");
        break;
 }
}
 
void RunTask1()
{
  Console.WriteLine("Программа подсчета положительных чисел введенных пользователем, кол-во введенных чисел определяется пользователем");
  int nint = OutIntDigit("Введите кол-во планируемых к вводу чисел N=");
  int j=0;
  for(int i = 0; i < nint; i++)
  {
    int lint = OutIntDigit("Введите целое положительное или отрицательно число l=");
    if (СheckPlusMinusDigitVar2(lint) > 0)
     {
        j++;
     }
  Console.WriteLine($"Из введенных чисел кол-во положительных = {j}");
  }
 
}
 
void  RunTask2()
{
Console.WriteLine("Программа подсчета поиска точку пересечения двух прямых, заданных уравнениями "+ Environment.NewLine +
"y = k1 * x + b1, y = k2 * x + b2; значения k1, k2, b1 и b2 задаются пользователем.");
float k1 = OutFloatDigit("введите коэфициент k1 первой линии k1=");
float b1 = OutFloatDigit("введите коэфициент b1 первой линии b1=");
float k2 = OutFloatDigit("введите коэфициент k2 второй линии k2=");
float b2 = OutFloatDigit("введите коэфициент b2 второй линии b2=");
FindCrossTwoLineInСoordinatesXY(k1,k2,b1,b2);
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
 
float OutFloatDigit(string info)
{
 float i;   
 Console.Write(info);
 
 while (!float.TryParse(Console.ReadLine(), out i))
 {
  Console.WriteLine("Вы ввели не целое число повторите еще раз");
 }
 
 return i;
}
 
bool СheckPlusMinusDigitVar1(int N)
{
 bool check;
 if (N < 0)
  {
   check = true; 
  }
 else
  { 
    check = false;
  }
 return check;
} 
 
int СheckPlusMinusDigitVar2(int N)
{
 int plus = 1, minus = -1, check;
 check = (N > 0 ? plus : minus);
 return check;
}
 
void FindCrossTwoLineInСoordinatesXY(float k1, float k2, float b1, float b2)
{
 if (k1 != k2) 
 {
  float xcoordinat = (b2-b1)/(k1-k2);
  float ycoordinat = k1*xcoordinat+b1;
  Console.WriteLine($"координаты точки пересечения линий y={k1}x+{b1} и y={k2}x+{b2} ({xcoordinat}; {ycoordinat})"); 
 }
 else
 {
   Console.WriteLine($"Линии y={k1}x+{b1} и y={k2}x+{b2} паралельны и не имет точек пересечения");  
 }
 
} 