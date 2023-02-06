//Программа №1 Принимает на вход  вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Принимает на вход  вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write("Введите целое число пятизначное число и нажмите клавишу <<Enter>> а=");
if (int.TryParse(Console.ReadLine(), out int a) && a > 1000 && a<100000)
 {
  Console.WriteLine($"получено  a={a}");
  if (((a%100)/10) == ((a/1000)%10) && (a%10) == (a/10000) )
   {
     Console.WriteLine($"введенное число {a} полиндром ");
   }
  else
   { 
     Console.WriteLine($"введенное число {a} НЕ полиндром ");
   }
 }  
else Console.WriteLine("Вы ввели не пятизначное число, необходимо перезапустить программу");
Console.WriteLine();
 
//Программа №2  Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
 
float inXYZ()
{
 if (float.TryParse(Console.ReadLine(), out float c)) 
  {
  }
 else
  {
   Console.WriteLine($"вы ввели не число, необходимо перезагрузить программу");
  }
 return (c);
}
string[] array = {"x первой","y первой","z первой","x1 второй","y1 второй","z1 второй"}; 
float [] array1 = new float[6]; //массив координат 
 
for (int i=0; i < array.Length; i++)
 {
  Console.Write($"Введите координаты {array[i]} точки и нажмите клавишу <<Enter>> {array[i]} = ");
  array1[i] = inXYZ(); 
 }
 double L = Math.Pow(array1[0]-array1[3],2)+Math.Pow(array1[1]-array1[4],2)+Math.Pow(array1[2]-array1[5],2);
 Console.Write($"Длина отрезка равна {Math.Sqrt(L)}");
Console.WriteLine(" ");
Console.WriteLine(" ");
 
//Программа №3 Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Введите целое число от 1 и нажмите клавишу <<Enter>> n=");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
 {
  for (int k = 1; k < n+1; k++)
  {
   Console.Write($"{Math.Pow(k,3)}, "); 
  }
 }
else Console.WriteLine("Вы ввели не целое число");