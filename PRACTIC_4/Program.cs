//Программа №1 Принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
int a = InputDigital("Введите целое число А и нажмите клавишу <<Enter>> A=");
int b = InputDigital("Введите целое число B и нажмите клавишу <<Enter>> B=");
int result = ExponAinB(a,b);
Console.Write($"Результат A в степени B = {result}");

int InputDigital(string inAB)
{
 int ab; 
 Console.Write(inAB);  
 while (!int.TryParse(Console.ReadLine(), out ab))
 {
  Console.WriteLine("Вы ввели не целое число, попробуйте еще раз");
  Console.Write(inAB);
 }
 return ab;
}  

int ExponAinB(int A, int B)
 {int AA = A;
  for (int i = 1; i < B; i++)
  {
   A = A*AA;
  }
  return A;
 }

Console.WriteLine();


//Программа №2 Принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine();
Console.WriteLine("Принимает на вход число и выдаёт сумму цифр в числе.");
int d = InputDigital("Введите целое число D и нажмите клавишу <<Enter>> D=");
int l = CheckLength(d,"Количество цифр введенного числа =");
int summ =SummDigits(d,l);
Console.WriteLine(summ);


int CheckLength(int d, string len)
 { int ii=0;
  while(d > 0)
  {
    d = d / (10);
    ii++;
    //Console.WriteLine($"d= {d} ii= {ii}");
    //if (d < 2) ii = ii+1;
  }
  Console.WriteLine($"{len} {ii}");
 return ii;
 } 

 int SummDigits(int d, int iii)
 { int n = 0, p = 0, sum = 0; 
   int [] array = new int[iii]; 
   for (n = 0; n < iii; n++)
   {
     p = d % (10);
     array[n]=p;
     d = d/10;
     //Console.WriteLine($"array={array[n]}");
     sum = sum + array[n];
   }
   return sum;
 }

//Программа №3 Задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine();
Console.WriteLine("Задаёт массив из 8 элементов и выводит их на экран.");
int [] array2 = new int[8];
for (int ar = 0; ar < 8; ar++)
 {
  array2[ar] = InputDigital($"Введите элемент массива array2[{ar}] и нажмите <<Enter>>=");
 }

Console.Write("массив содержит следующие элементы");
for (int ar2 = 0; ar2 < 8; ar2++)
 {
  Console.Write($" [{array2[ar2]}]");
 }



